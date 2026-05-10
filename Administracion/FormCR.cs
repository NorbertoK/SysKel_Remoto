using System;
using System.Windows.Forms;

namespace Administracion
{
    public partial class FormCR : Form
    {
        protected FormCR()
        {
            InitializeComponent();
        }

        private void ButtonSalirClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}