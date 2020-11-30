
namespace Presentacion
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMostrarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbelRespuesta1 = new System.Windows.Forms.Label();
            this.LbelRespuesta2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblResultadoEjecucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMostrarDatos
            // 
            this.BtnMostrarDatos.Location = new System.Drawing.Point(269, 337);
            this.BtnMostrarDatos.Name = "BtnMostrarDatos";
            this.BtnMostrarDatos.Size = new System.Drawing.Size(139, 35);
            this.BtnMostrarDatos.TabIndex = 0;
            this.BtnMostrarDatos.Text = "Mostrar Datos";
            this.BtnMostrarDatos.UseVisualStyleBackColor = true;
            this.BtnMostrarDatos.Click += new System.EventHandler(this.BtnMostrarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "La conexion esta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Se accede a la base de datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ahora la conexion esta:";
            // 
            // LbelRespuesta1
            // 
            this.LbelRespuesta1.AutoSize = true;
            this.LbelRespuesta1.Location = new System.Drawing.Point(363, 187);
            this.LbelRespuesta1.Name = "LbelRespuesta1";
            this.LbelRespuesta1.Size = new System.Drawing.Size(46, 17);
            this.LbelRespuesta1.TabIndex = 4;
            this.LbelRespuesta1.Text = "label4";
            // 
            // LbelRespuesta2
            // 
            this.LbelRespuesta2.AutoSize = true;
            this.LbelRespuesta2.Location = new System.Drawing.Point(400, 245);
            this.LbelRespuesta2.Name = "LbelRespuesta2";
            this.LbelRespuesta2.Size = new System.Drawing.Size(46, 17);
            this.LbelRespuesta2.TabIndex = 5;
            this.LbelRespuesta2.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Version:";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(305, 161);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(46, 17);
            this.LblVersion.TabIndex = 7;
            this.LblVersion.Text = "label5";
            // 
            // LblResultadoEjecucion
            // 
            this.LblResultadoEjecucion.AutoSize = true;
            this.LblResultadoEjecucion.Location = new System.Drawing.Point(311, 279);
            this.LblResultadoEjecucion.Name = "LblResultadoEjecucion";
            this.LblResultadoEjecucion.Size = new System.Drawing.Size(46, 17);
            this.LblResultadoEjecucion.TabIndex = 8;
            this.LblResultadoEjecucion.Text = "label5";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.LblResultadoEjecucion);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbelRespuesta2);
            this.Controls.Add(this.LbelRespuesta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMostrarDatos);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbelRespuesta1;
        private System.Windows.Forms.Label LbelRespuesta2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblResultadoEjecucion;
    }
}

