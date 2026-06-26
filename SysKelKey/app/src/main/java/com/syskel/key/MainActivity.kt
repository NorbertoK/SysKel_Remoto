package com.syskel.key

import android.content.ClipData
import android.content.ClipboardManager
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.Spinner
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.android.material.datepicker.MaterialDatePicker
import com.google.android.material.textfield.TextInputEditText
import java.security.MessageDigest
import java.text.SimpleDateFormat
import java.util.Calendar
import java.util.Date
import java.util.Locale
import java.util.TimeZone
import javax.crypto.Cipher
import javax.crypto.spec.SecretKeySpec

class MainActivity : AppCompatActivity() {

    private var fechaSeleccionada: Date = Date()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val spinnerEmpresa = findViewById<Spinner>(R.id.spinnerEmpresa)
        val btnFecha = findViewById<Button>(R.id.btnFecha)
        val btnGenerar = findViewById<Button>(R.id.btnGenerar)
        val txtClave = findViewById<TextInputEditText>(R.id.txtClave)
        val btnCopiar = findViewById<Button>(R.id.btnCopiar)

        actualizarBotonFecha(btnFecha)

        btnFecha.setOnClickListener {
            val picker = MaterialDatePicker.Builder.datePicker()
                .setTitleText("Vigencia hasta la medianoche del")
                .setSelection(fechaSeleccionada.time)
                .build()
            picker.addOnPositiveButtonClickListener { millis ->
                val cal = Calendar.getInstance(TimeZone.getTimeZone("UTC"))
                cal.timeInMillis = millis
                val local = Calendar.getInstance()
                local.set(cal.get(Calendar.YEAR), cal.get(Calendar.MONTH), cal.get(Calendar.DAY_OF_MONTH))
                fechaSeleccionada = local.time
                actualizarBotonFecha(btnFecha)
            }
            picker.show(supportFragmentManager, "date")
        }

        btnGenerar.setOnClickListener {
            val empresa = spinnerEmpresa.selectedItem.toString()
            val fechaStr = SimpleDateFormat("yyyyMMdd", Locale.US).format(fechaSeleccionada)

            val random = java.util.Random()
            val prefijo = "_".repeat(random.nextInt(7))
            val sufijo = "_".repeat(random.nextInt(7))
            val cadena = prefijo + fechaStr + empresa + sufijo

            txtClave.setText(encriptar(cadena))
            btnCopiar.visibility = View.VISIBLE
        }

        btnCopiar.setOnClickListener {
            val texto = txtClave.text.toString()
            if (texto.isNotEmpty()) {
                val clipboard = getSystemService(CLIPBOARD_SERVICE) as ClipboardManager
                clipboard.setPrimaryClip(ClipData.newPlainText("clave", texto))
                Toast.makeText(this, "Copiado", Toast.LENGTH_SHORT).show()
            }
        }
    }

    private fun actualizarBotonFecha(btn: Button) {
        btn.text = SimpleDateFormat("dd/MM/yyyy", Locale("es")).format(fechaSeleccionada)
    }

    companion object {
        private const val KEY = "ABCDEFGHIJKLMÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz"

        fun encriptar(texto: String): String {
            val keyBytes = MessageDigest.getInstance("MD5")
                .digest(KEY.toByteArray(Charsets.UTF_8))

            // Java TripleDES needs 24 bytes; .NET uses 16 (K1,K2 → K3=K1)
            val key24 = ByteArray(24)
            System.arraycopy(keyBytes, 0, key24, 0, 16)
            System.arraycopy(keyBytes, 0, key24, 16, 8)

            val cipher = Cipher.getInstance("DESede/ECB/PKCS5Padding")
            cipher.init(Cipher.ENCRYPT_MODE, SecretKeySpec(key24, "DESede"))
            val encrypted = cipher.doFinal(texto.toByteArray(Charsets.UTF_8))
            return android.util.Base64.encodeToString(encrypted, android.util.Base64.NO_WRAP)
        }
    }
}
