namespace Presentacion
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_reportar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_codigo = new System.Windows.Forms.TextBox();
            this.Txb_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_salir.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = global::Presentacion.Properties.Resources.boton_de_encendido;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.Location = new System.Drawing.Point(640, 344);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(122, 59);
            this.Btn_salir.TabIndex = 4;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            // 
            // Btn_reportar
            // 
            this.Btn_reportar.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_reportar.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reportar.Image = global::Presentacion.Properties.Resources.lista_de_verificacion;
            this.Btn_reportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reportar.Location = new System.Drawing.Point(499, 344);
            this.Btn_reportar.Name = "Btn_reportar";
            this.Btn_reportar.Size = new System.Drawing.Size(122, 59);
            this.Btn_reportar.TabIndex = 3;
            this.Btn_reportar.Text = "Reporte";
            this.Btn_reportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reportar.UseVisualStyleBackColor = false;
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_borrar.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = global::Presentacion.Properties.Resources.borrar;
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(360, 344);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(122, 59);
            this.Btn_borrar.TabIndex = 2;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_actualizar.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Image = global::Presentacion.Properties.Resources.actualizar;
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_actualizar.Location = new System.Drawing.Point(220, 344);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(122, 59);
            this.Btn_actualizar.TabIndex = 1;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.LightCyan;
            this.Btn_nuevo.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevo.Image = global::Presentacion.Properties.Resources.carpeta;
            this.Btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_nuevo.Location = new System.Drawing.Point(81, 344);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(122, 59);
            this.Btn_nuevo.TabIndex = 0;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo:";
            // 
            // Txb_codigo
            // 
            this.Txb_codigo.Location = new System.Drawing.Point(174, 165);
            this.Txb_codigo.MaxLength = 4;
            this.Txb_codigo.Name = "Txb_codigo";
            this.Txb_codigo.Size = new System.Drawing.Size(100, 20);
            this.Txb_codigo.TabIndex = 6;
            // 
            // Txb_descripcion
            // 
            this.Txb_descripcion.Location = new System.Drawing.Point(174, 225);
            this.Txb_descripcion.MaxLength = 50;
            this.Txb_descripcion.Name = "Txb_descripcion";
            this.Txb_descripcion.Size = new System.Drawing.Size(294, 20);
            this.Txb_descripcion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(876, 493);
            this.Controls.Add(this.Txb_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reportar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primer Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_reportar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_codigo;
        private System.Windows.Forms.TextBox Txb_descripcion;
        private System.Windows.Forms.Label label2;
    }
}