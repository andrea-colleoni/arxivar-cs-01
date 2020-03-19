namespace _05_WinForms
{
    partial class FmPrincipale
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.btnComando = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(12, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(299, 39);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Il mio primo Form!!";
            // 
            // txtTesto
            // 
            this.txtTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTesto.Location = new System.Drawing.Point(339, 12);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(495, 38);
            this.txtTesto.TabIndex = 1;
            // 
            // btnComando
            // 
            this.btnComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComando.Location = new System.Drawing.Point(19, 63);
            this.btnComando.Name = "btnComando";
            this.btnComando.Size = new System.Drawing.Size(815, 86);
            this.btnComando.TabIndex = 2;
            this.btnComando.Text = "Clicca qui!";
            this.btnComando.UseVisualStyleBackColor = true;
            this.btnComando.Click += new System.EventHandler(this.BtnComando_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.Location = new System.Drawing.Point(19, 156);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(815, 366);
            this.txtOutput.TabIndex = 3;
            // 
            // FmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 534);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnComando);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.lblTitolo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FmPrincipale";
            this.Text = "La mia prima APP";
            this.Click += new System.EventHandler(this.FmPrincipale_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Button btnComando;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

