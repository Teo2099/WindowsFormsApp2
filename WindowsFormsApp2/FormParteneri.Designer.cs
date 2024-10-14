namespace WindowsFormsApp2
{
    partial class FormParteneri
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
            this.textBoxCUI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewParteneri = new System.Windows.Forms.DataGridView();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDenumire = new System.Windows.Forms.ComboBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParteneri)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCUI
            // 
            this.textBoxCUI.Location = new System.Drawing.Point(369, 53);
            this.textBoxCUI.Name = "textBoxCUI";
            this.textBoxCUI.Size = new System.Drawing.Size(151, 22);
            this.textBoxCUI.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "CUI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Denumire";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(273, 165);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 32);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(153, 165);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 32);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(30, 165);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(98, 32);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewParteneri
            // 
            this.dataGridViewParteneri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParteneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParteneri.Location = new System.Drawing.Point(30, 219);
            this.dataGridViewParteneri.Name = "dataGridViewParteneri";
            this.dataGridViewParteneri.RowTemplate.Height = 24;
            this.dataGridViewParteneri.Size = new System.Drawing.Size(997, 267);
            this.dataGridViewParteneri.TabIndex = 9;
            this.dataGridViewParteneri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParteneri_CellClick);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(369, 97);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(151, 22);
            this.textBoxAdresa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Adresa";
            // 
            // comboBoxDenumire
            // 
            this.comboBoxDenumire.FormattingEnabled = true;
            this.comboBoxDenumire.Items.AddRange(new object[] {
            "furnizor",
            "client"});
            this.comboBoxDenumire.Location = new System.Drawing.Point(369, 3);
            this.comboBoxDenumire.Name = "comboBoxDenumire";
            this.comboBoxDenumire.Size = new System.Drawing.Size(151, 24);
            this.comboBoxDenumire.TabIndex = 19;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(71, 53);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(151, 22);
            this.textBoxCod.TabIndex = 23;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(71, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(151, 22);
            this.textBoxId.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Id";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(391, 165);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 32);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormParteneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 612);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDenumire);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewParteneri);
            this.Name = "FormParteneri";
            this.Text = "FormParteneri";
            this.Load += new System.EventHandler(this.FormParteneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParteneri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCUI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewParteneri;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDenumire;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
    }
}