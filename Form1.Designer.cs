namespace Evidencia_.Net
{
    partial class Form1
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
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.numero_uno = new System.Windows.Forms.TextBox();
            this.numero_dos = new System.Windows.Forms.TextBox();
            this.respuesta = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(162, 12);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(106, 35);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "SUMA";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(162, 53);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(106, 35);
            this.restar.TabIndex = 1;
            this.restar.Text = "RESTA";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(162, 135);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(106, 35);
            this.dividir.TabIndex = 2;
            this.dividir.Text = "DIVISIÓN";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(162, 94);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(106, 35);
            this.multiplicar.TabIndex = 3;
            this.multiplicar.Text = "MULTIPLICACIÓN";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // numero_uno
            // 
            this.numero_uno.Location = new System.Drawing.Point(22, 20);
            this.numero_uno.Name = "numero_uno";
            this.numero_uno.Size = new System.Drawing.Size(125, 20);
            this.numero_uno.TabIndex = 4;
            // 
            // numero_dos
            // 
            this.numero_dos.Location = new System.Drawing.Point(22, 61);
            this.numero_dos.Name = "numero_dos";
            this.numero_dos.Size = new System.Drawing.Size(125, 20);
            this.numero_dos.TabIndex = 5;
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(70, 96);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(24, 25);
            this.respuesta.TabIndex = 6;
            this.respuesta.Text = "0";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(22, 135);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(125, 35);
            this.borrar.TabIndex = 0;
            this.borrar.Text = "BORRAR";
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 188);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.numero_dos);
            this.Controls.Add(this.numero_uno);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.TextBox numero_uno;
        private System.Windows.Forms.TextBox numero_dos;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Button borrar;
    }
}

