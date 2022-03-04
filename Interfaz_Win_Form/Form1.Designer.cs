
namespace Interfaz_Win_Form
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
            this.btn_CambiarTexto = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CambiarTexto
            // 
            this.btn_CambiarTexto.Location = new System.Drawing.Point(98, 235);
            this.btn_CambiarTexto.Name = "btn_CambiarTexto";
            this.btn_CambiarTexto.Size = new System.Drawing.Size(299, 54);
            this.btn_CambiarTexto.TabIndex = 0;
            this.btn_CambiarTexto.Text = "Mostrar Texto";
            this.btn_CambiarTexto.UseVisualStyleBackColor = true;
            this.btn_CambiarTexto.Click += new System.EventHandler(this.btn_CambiarTexto_Click);
            this.btn_CambiarTexto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_CambiarTexto_MouseClick);
            this.btn_CambiarTexto.MouseLeave += new System.EventHandler(this.btn_CambiarTexto_MouseLeave);
            this.btn_CambiarTexto.MouseHover += new System.EventHandler(this.btn_CambiarTexto_MouseHover);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(227, 150);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(42, 36);
            this.lbl_Texto.TabIndex = 1;
            this.lbl_Texto.Text = "---";
            this.lbl_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "1 clic \"HOLA\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dejar cursor arriba \"ADIOS\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.btn_CambiarTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CambiarTexto;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

