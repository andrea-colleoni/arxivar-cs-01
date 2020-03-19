namespace _06_Eccezioni
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
            this.components = new System.ComponentModel.Container();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnViaggio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtCilindrata = new System.Windows.Forms.TextBox();
            this.txtCapacita = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cilindrataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitaSerbatoioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livelloCarburanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumoKmLitroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblTitolo, 2);
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(3, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(1114, 60);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Gara di automobili";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 63);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(554, 213);
            this.txtOutput.TabIndex = 1;
            // 
            // btnViaggio
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnViaggio, 2);
            this.btnViaggio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaggio.Location = new System.Drawing.Point(3, 501);
            this.btnViaggio.Name = "btnViaggio";
            this.btnViaggio.Size = new System.Drawing.Size(1114, 55);
            this.btnViaggio.TabIndex = 2;
            this.btnViaggio.Text = "Inizia il viaggio";
            this.btnViaggio.UseVisualStyleBackColor = true;
            this.btnViaggio.Click += new System.EventHandler(this.BtnViaggio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modello";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cilindrata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacita serbatoio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Consumo (km/l)";
            // 
            // txtMarca
            // 
            this.txtMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(280, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(271, 30);
            this.txtMarca.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMarca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtModello, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCilindrata, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCapacita, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtConsumo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAggiungi, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(563, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 213);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txtModello
            // 
            this.txtModello.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModello.Location = new System.Drawing.Point(280, 33);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(271, 30);
            this.txtModello.TabIndex = 9;
            // 
            // txtCilindrata
            // 
            this.txtCilindrata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCilindrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilindrata.Location = new System.Drawing.Point(280, 63);
            this.txtCilindrata.Name = "txtCilindrata";
            this.txtCilindrata.Size = new System.Drawing.Size(271, 30);
            this.txtCilindrata.TabIndex = 10;
            // 
            // txtCapacita
            // 
            this.txtCapacita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapacita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacita.Location = new System.Drawing.Point(280, 93);
            this.txtCapacita.Name = "txtCapacita";
            this.txtCapacita.Size = new System.Drawing.Size(271, 30);
            this.txtCapacita.TabIndex = 11;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(280, 123);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(271, 30);
            this.txtConsumo.TabIndex = 12;
            // 
            // btnAggiungi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAggiungi, 2);
            this.btnAggiungi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAggiungi.Location = new System.Drawing.Point(3, 153);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(548, 57);
            this.btnAggiungi.TabIndex = 13;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnViaggio, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTitolo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtOutput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1120, 559);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modelloDataGridViewTextBoxColumn,
            this.cilindrataDataGridViewTextBoxColumn,
            this.capacitaSerbatoioDataGridViewTextBoxColumn,
            this.livelloCarburanteDataGridViewTextBoxColumn,
            this.consumoKmLitroDataGridViewTextBoxColumn});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DataSource = this.automobileBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 213);
            this.dataGridView1.TabIndex = 10;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelloDataGridViewTextBoxColumn
            // 
            this.modelloDataGridViewTextBoxColumn.DataPropertyName = "Modello";
            this.modelloDataGridViewTextBoxColumn.HeaderText = "Modello";
            this.modelloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelloDataGridViewTextBoxColumn.Name = "modelloDataGridViewTextBoxColumn";
            this.modelloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelloDataGridViewTextBoxColumn.Width = 125;
            // 
            // cilindrataDataGridViewTextBoxColumn
            // 
            this.cilindrataDataGridViewTextBoxColumn.DataPropertyName = "Cilindrata";
            this.cilindrataDataGridViewTextBoxColumn.HeaderText = "Cilindrata";
            this.cilindrataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cilindrataDataGridViewTextBoxColumn.Name = "cilindrataDataGridViewTextBoxColumn";
            this.cilindrataDataGridViewTextBoxColumn.ReadOnly = true;
            this.cilindrataDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacitaSerbatoioDataGridViewTextBoxColumn
            // 
            this.capacitaSerbatoioDataGridViewTextBoxColumn.DataPropertyName = "CapacitaSerbatoio";
            this.capacitaSerbatoioDataGridViewTextBoxColumn.HeaderText = "CapacitaSerbatoio";
            this.capacitaSerbatoioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacitaSerbatoioDataGridViewTextBoxColumn.Name = "capacitaSerbatoioDataGridViewTextBoxColumn";
            this.capacitaSerbatoioDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacitaSerbatoioDataGridViewTextBoxColumn.Width = 125;
            // 
            // livelloCarburanteDataGridViewTextBoxColumn
            // 
            this.livelloCarburanteDataGridViewTextBoxColumn.DataPropertyName = "LivelloCarburante";
            this.livelloCarburanteDataGridViewTextBoxColumn.HeaderText = "LivelloCarburante";
            this.livelloCarburanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livelloCarburanteDataGridViewTextBoxColumn.Name = "livelloCarburanteDataGridViewTextBoxColumn";
            this.livelloCarburanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.livelloCarburanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // consumoKmLitroDataGridViewTextBoxColumn
            // 
            this.consumoKmLitroDataGridViewTextBoxColumn.DataPropertyName = "ConsumoKmLitro";
            this.consumoKmLitroDataGridViewTextBoxColumn.HeaderText = "ConsumoKmLitro";
            this.consumoKmLitroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consumoKmLitroDataGridViewTextBoxColumn.Name = "consumoKmLitroDataGridViewTextBoxColumn";
            this.consumoKmLitroDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumoKmLitroDataGridViewTextBoxColumn.Width = 125;
            // 
            // automobileBindingSource
            // 
            this.automobileBindingSource.DataSource = typeof(_06_Eccezioni.Automobile);
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 559);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FmMain";
            this.Text = "Gara di automobili";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnViaggio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtCilindrata;
        private System.Windows.Forms.TextBox txtCapacita;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource automobileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cilindrataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitaSerbatoioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livelloCarburanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumoKmLitroDataGridViewTextBoxColumn;
    }
}

