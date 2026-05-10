// Agrega esta propiedad en la clase Settings para exponer la cadena de conexión.
// Asegúrate de que el nombre y el valor coincidan con la configuración real de tu proyecto.

[global::System.Configuration.ApplicationScopedSettingAttribute()]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
public string DatosConnectionString
{
    get
    {
        return ((string)(this["DatosConnectionString"]));
    }
}
