using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Txb_codigo.Text = "";
            Txb_codigo.Enabled = true;
            Txb_descripcion.Text = "";
            Txb_descripcion.Enabled = true;
            Txb_codigo.Focus();
        }
    }
}
