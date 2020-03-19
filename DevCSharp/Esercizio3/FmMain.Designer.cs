namespace Esercizio3
{
    partial class FmMain
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnViaggio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(346, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(344, 46);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Gara di automobili";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 71);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1096, 294);
            this.txtOutput.TabIndex = 1;
            // 
            // btnViaggio
            // 
            this.btnViaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaggio.Location = new System.Drawing.Point(12, 380);
            this.btnViaggio.Name = "btnViaggio";
            this.btnViaggio.Size = new System.Drawing.Size(1096, 58);
            this.btnViaggio.TabIndex = 2;
            this.btnViaggio.Text = "Inizia il viaggio";
            this.btnViaggio.UseVisualStyleBackColor = true;
            this.btnViaggio.Click += new System.EventHandler(this.BtnViaggio_Click);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 463);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnViaggio);
            this.Controls.Add(this.txtOutput);
            this.Name = "FmMain";
            this.Text = "Gara di automobili";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnViaggio;
    }
}

