
namespace alumnos
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
            this.btnParcial2 = new System.Windows.Forms.Button();
            this.ltbresultado = new System.Windows.Forms.ListBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncargarArchivo = new System.Windows.Forms.Button();
            this.btnNombres = new System.Windows.Forms.Button();
            this.parcial1 = new System.Windows.Forms.Button();
            this.btnParcial3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParcial2
            // 
            this.btnParcial2.Location = new System.Drawing.Point(568, 172);
            this.btnParcial2.Name = "btnParcial2";
            this.btnParcial2.Size = new System.Drawing.Size(92, 66);
            this.btnParcial2.TabIndex = 0;
            this.btnParcial2.Text = "nota mayor P2";
            this.btnParcial2.UseVisualStyleBackColor = true;
            this.btnParcial2.Click += new System.EventHandler(this.btnarreglo_Click);
            // 
            // ltbresultado
            // 
            this.ltbresultado.FormattingEnabled = true;
            this.ltbresultado.Location = new System.Drawing.Point(349, 12);
            this.ltbresultado.Name = "ltbresultado";
            this.ltbresultado.Size = new System.Drawing.Size(416, 134);
            this.ltbresultado.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(12, 12);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtresultado.Size = new System.Drawing.Size(289, 136);
            this.txtresultado.TabIndex = 2;
            // 
            // btncargarArchivo
            // 
            this.btncargarArchivo.Location = new System.Drawing.Point(12, 154);
            this.btncargarArchivo.Name = "btncargarArchivo";
            this.btncargarArchivo.Size = new System.Drawing.Size(94, 57);
            this.btncargarArchivo.TabIndex = 3;
            this.btncargarArchivo.Text = "cargar Archivo";
            this.btncargarArchivo.UseVisualStyleBackColor = true;
            this.btncargarArchivo.Click += new System.EventHandler(this.btncargarArchivo_Click);
            // 
            // btnNombres
            // 
            this.btnNombres.Location = new System.Drawing.Point(349, 172);
            this.btnNombres.Name = "btnNombres";
            this.btnNombres.Size = new System.Drawing.Size(93, 66);
            this.btnNombres.TabIndex = 4;
            this.btnNombres.Text = "nombres";
            this.btnNombres.UseVisualStyleBackColor = true;
            this.btnNombres.Click += new System.EventHandler(this.btnNombres_Click);
            // 
            // parcial1
            // 
            this.parcial1.Location = new System.Drawing.Point(458, 172);
            this.parcial1.Name = "parcial1";
            this.parcial1.Size = new System.Drawing.Size(95, 66);
            this.parcial1.TabIndex = 5;
            this.parcial1.Text = "nota mayor P1";
            this.parcial1.UseVisualStyleBackColor = true;
            this.parcial1.Click += new System.EventHandler(this.parcial1_Click);
            // 
            // btnParcial3
            // 
            this.btnParcial3.Location = new System.Drawing.Point(666, 172);
            this.btnParcial3.Name = "btnParcial3";
            this.btnParcial3.Size = new System.Drawing.Size(99, 65);
            this.btnParcial3.TabIndex = 6;
            this.btnParcial3.Text = "nota mayor P3";
            this.btnParcial3.UseVisualStyleBackColor = true;
            this.btnParcial3.Click += new System.EventHandler(this.btnParcial3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.btnParcial3);
            this.Controls.Add(this.parcial1);
            this.Controls.Add(this.btnNombres);
            this.Controls.Add(this.btncargarArchivo);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.ltbresultado);
            this.Controls.Add(this.btnParcial2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParcial2;
        private System.Windows.Forms.ListBox ltbresultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncargarArchivo;
        private System.Windows.Forms.Button btnNombres;
        private System.Windows.Forms.Button parcial1;
        private System.Windows.Forms.Button btnParcial3;
    }
}

