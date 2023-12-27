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
    public partial class Encuesta : Form
    {
        public Encuesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Resultado = "";

            if (Chbox_CSharp.Checked == true)
            {
                Resultado += Chbox_CSharp.Text + ", ";
            }
            if (Chbox_JavaScript.Checked == true)
            {
                Resultado += Chbox_JavaScript.Text + ", ";
            }
            if (Chbox_NodeJs.Checked == true)
            {
                Resultado += Chbox_NodeJs.Text + ", ";
            }
            if (Chbox_React.Checked == true)
            {
                Resultado += Chbox_React.Text + ", ";
            }
            if (Chbox_TypeScript.Checked == true)
            {
                Resultado += Chbox_TypeScript.Text;
            }

            //seleccion radiobutton

            if (Rdb_Ingles.Checked == true)
            {
                Resultado += ">>>>>>>" + Rdb_Ingles.Text + "<<<<<<<";
            } 
            else
            {
                Resultado += ">>>>>>>" + Rdb_Español.Text + "<<<<<<<";
            }

            Txt_Resultado.Text = Resultado;
        }
    }
}
