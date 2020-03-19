namespace Esercizio4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPiu = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnDiviso = new System.Windows.Forms.Button();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.lblUltimeOp = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPiu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMeno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPer, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDiviso, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtOp1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOp2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRisultato, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUltimeOp, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primo operando";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 115);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secondo operando";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPiu
            // 
            this.btnPiu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiu.Location = new System.Drawing.Point(3, 233);
            this.btnPiu.Name = "btnPiu";
            this.btnPiu.Size = new System.Drawing.Size(216, 54);
            this.btnPiu.TabIndex = 4;
            this.btnPiu.Text = "+";
            this.btnPiu.UseVisualStyleBackColor = true;
            this.btnPiu.Click += new System.EventHandler(this.BtnTutti_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeno.Location = new System.Drawing.Point(225, 233);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(216, 54);
            this.btnMeno.TabIndex = 5;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.BtnTutti_Click);
            // 
            // btnPer
            // 
            this.btnPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPer.Location = new System.Drawing.Point(447, 233);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(216, 54);
            this.btnPer.TabIndex = 6;
            this.btnPer.Text = "*";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.BtnTutti_Click);
            // 
            // btnDiviso
            // 
            this.btnDiviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiviso.Location = new System.Drawing.Point(669, 233);
            this.btnDiviso.Name = "btnDiviso";
            this.btnDiviso.Size = new System.Drawing.Size(218, 54);
            this.btnDiviso.TabIndex = 7;
            this.btnDiviso.Text = "/";
            this.btnDiviso.UseVisualStyleBackColor = true;
            this.btnDiviso.Click += new System.EventHandler(this.BtnTutti_Click);
            // 
            // txtOp1
            // 
            this.txtOp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtOp1, 2);
            this.txtOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp1.Location = new System.Drawing.Point(447, 37);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(440, 41);
            this.txtOp1.TabIndex = 2;
            // 
            // txtOp2
            // 
            this.txtOp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtOp2, 2);
            this.txtOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOp2.Location = new System.Drawing.Point(447, 152);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(440, 41);
            this.txtOp2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "Risultato";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRisultato, 3);
            this.lblRisultato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(225, 290);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(662, 60);
            this.lblRisultato.TabIndex = 9;
            // 
            // lblUltimeOp
            // 
            this.lblUltimeOp.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblUltimeOp, 4);
            this.lblUltimeOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUltimeOp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimeOp.Location = new System.Drawing.Point(3, 350);
            this.lblUltimeOp.Name = "lblUltimeOp";
            this.lblUltimeOp.Size = new System.Drawing.Size(884, 151);
            this.lblUltimeOp.TabIndex = 10;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FmMain";
            this.Text = "Calcolatrice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Button btnPiu;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnDiviso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Label lblUltimeOp;
    }
}

