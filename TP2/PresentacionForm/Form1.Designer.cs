
namespace PresentacionForm
{
    partial class FormPresentacion
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
            this.btn_DividirPorCero = new System.Windows.Forms.Button();
            this.btn_DividirPorDivisor = new System.Windows.Forms.Button();
            this.nud_Dividendo = new System.Windows.Forms.NumericUpDown();
            this.nud_Divisor = new System.Windows.Forms.NumericUpDown();
            this.lbl_Dividendo = new System.Windows.Forms.Label();
            this.lbl_Divisor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dividendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Divisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DividirPorCero
            // 
            this.btn_DividirPorCero.Location = new System.Drawing.Point(76, 276);
            this.btn_DividirPorCero.Name = "btn_DividirPorCero";
            this.btn_DividirPorCero.Size = new System.Drawing.Size(120, 60);
            this.btn_DividirPorCero.TabIndex = 0;
            this.btn_DividirPorCero.Text = "Dividir por 0";
            this.btn_DividirPorCero.UseVisualStyleBackColor = true;
            this.btn_DividirPorCero.Click += new System.EventHandler(this.btn_DividirPorCero_Click);
            // 
            // btn_DividirPorDivisor
            // 
            this.btn_DividirPorDivisor.Location = new System.Drawing.Point(345, 276);
            this.btn_DividirPorDivisor.Name = "btn_DividirPorDivisor";
            this.btn_DividirPorDivisor.Size = new System.Drawing.Size(120, 60);
            this.btn_DividirPorDivisor.TabIndex = 1;
            this.btn_DividirPorDivisor.Text = "Ingresar divisor";
            this.btn_DividirPorDivisor.UseVisualStyleBackColor = true;
            this.btn_DividirPorDivisor.Click += new System.EventHandler(this.btn_DividirPorDivisor_Click);
            // 
            // nud_Dividendo
            // 
            this.nud_Dividendo.Location = new System.Drawing.Point(76, 126);
            this.nud_Dividendo.Name = "nud_Dividendo";
            this.nud_Dividendo.Size = new System.Drawing.Size(120, 20);
            this.nud_Dividendo.TabIndex = 2;
            // 
            // nud_Divisor
            // 
            this.nud_Divisor.Location = new System.Drawing.Point(345, 126);
            this.nud_Divisor.Name = "nud_Divisor";
            this.nud_Divisor.Size = new System.Drawing.Size(120, 20);
            this.nud_Divisor.TabIndex = 3;
            // 
            // lbl_Dividendo
            // 
            this.lbl_Dividendo.AutoSize = true;
            this.lbl_Dividendo.Location = new System.Drawing.Point(73, 71);
            this.lbl_Dividendo.Name = "lbl_Dividendo";
            this.lbl_Dividendo.Size = new System.Drawing.Size(55, 13);
            this.lbl_Dividendo.TabIndex = 4;
            this.lbl_Dividendo.Text = "Dividendo";
            // 
            // lbl_Divisor
            // 
            this.lbl_Divisor.AutoSize = true;
            this.lbl_Divisor.Location = new System.Drawing.Point(342, 71);
            this.lbl_Divisor.Name = "lbl_Divisor";
            this.lbl_Divisor.Size = new System.Drawing.Size(39, 13);
            this.lbl_Divisor.TabIndex = 5;
            this.lbl_Divisor.Text = "Divisor";
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.lbl_Divisor);
            this.Controls.Add(this.lbl_Dividendo);
            this.Controls.Add(this.nud_Divisor);
            this.Controls.Add(this.nud_Dividendo);
            this.Controls.Add(this.btn_DividirPorDivisor);
            this.Controls.Add(this.btn_DividirPorCero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Dividendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Divisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DividirPorCero;
        private System.Windows.Forms.Button btn_DividirPorDivisor;
        private System.Windows.Forms.NumericUpDown nud_Dividendo;
        private System.Windows.Forms.NumericUpDown nud_Divisor;
        private System.Windows.Forms.Label lbl_Dividendo;
        private System.Windows.Forms.Label lbl_Divisor;
    }
}

