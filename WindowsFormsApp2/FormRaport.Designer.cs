namespace WindowsFormsApp2
{
    partial class FormRaport
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
            this.groupBox1Liste = new System.Windows.Forms.GroupBox();
            this.radioButtonListaIesiri = new System.Windows.Forms.RadioButton();
            this.radioButtonListIntrari = new System.Windows.Forms.RadioButton();
            this.dataInceput = new System.Windows.Forms.DateTimePicker();
            this.dataSfarsit = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1Gestiuni = new System.Windows.Forms.GroupBox();
            this.radioButtonOGestiune = new System.Windows.Forms.RadioButton();
            this.radioButtonToateGestiunile = new System.Windows.Forms.RadioButton();
            this.comboBoxGestiune = new System.Windows.Forms.ComboBox();
            this.buttonAccepta = new System.Windows.Forms.Button();
            this.buttonListeaza = new System.Windows.Forms.Button();
            this.dataGridViewRaport = new System.Windows.Forms.DataGridView();
            this.groupBox1Liste.SuspendLayout();
            this.groupBox1Gestiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1Liste
            // 
            this.groupBox1Liste.Controls.Add(this.radioButtonListaIesiri);
            this.groupBox1Liste.Controls.Add(this.radioButtonListIntrari);
            this.groupBox1Liste.Location = new System.Drawing.Point(25, 29);
            this.groupBox1Liste.Name = "groupBox1Liste";
            this.groupBox1Liste.Size = new System.Drawing.Size(200, 100);
            this.groupBox1Liste.TabIndex = 0;
            this.groupBox1Liste.TabStop = false;
            this.groupBox1Liste.Text = "Liste";
            // 
            // radioButtonListaIesiri
            // 
            this.radioButtonListaIesiri.AutoSize = true;
            this.radioButtonListaIesiri.Location = new System.Drawing.Point(6, 57);
            this.radioButtonListaIesiri.Name = "radioButtonListaIesiri";
            this.radioButtonListaIesiri.Size = new System.Drawing.Size(92, 21);
            this.radioButtonListaIesiri.TabIndex = 2;
            this.radioButtonListaIesiri.Text = "Lista Iesiri";
            this.radioButtonListaIesiri.UseVisualStyleBackColor = true;
            // 
            // radioButtonListIntrari
            // 
            this.radioButtonListIntrari.AutoSize = true;
            this.radioButtonListIntrari.Location = new System.Drawing.Point(6, 21);
            this.radioButtonListIntrari.Name = "radioButtonListIntrari";
            this.radioButtonListIntrari.Size = new System.Drawing.Size(99, 21);
            this.radioButtonListIntrari.TabIndex = 1;
            this.radioButtonListIntrari.TabStop = true;
            this.radioButtonListIntrari.Text = "Liste Intrari";
            this.radioButtonListIntrari.UseVisualStyleBackColor = true;
            // 
            // dataInceput
            // 
            this.dataInceput.Location = new System.Drawing.Point(246, 38);
            this.dataInceput.Name = "dataInceput";
            this.dataInceput.Size = new System.Drawing.Size(243, 22);
            this.dataInceput.TabIndex = 1;
            // 
            // dataSfarsit
            // 
            this.dataSfarsit.Location = new System.Drawing.Point(246, 107);
            this.dataSfarsit.Name = "dataSfarsit";
            this.dataSfarsit.Size = new System.Drawing.Size(243, 22);
            this.dataSfarsit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Inceput:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Sfarsit:";
            // 
            // groupBox1Gestiuni
            // 
            this.groupBox1Gestiuni.Controls.Add(this.radioButtonOGestiune);
            this.groupBox1Gestiuni.Controls.Add(this.radioButtonToateGestiunile);
            this.groupBox1Gestiuni.Location = new System.Drawing.Point(246, 151);
            this.groupBox1Gestiuni.Name = "groupBox1Gestiuni";
            this.groupBox1Gestiuni.Size = new System.Drawing.Size(200, 100);
            this.groupBox1Gestiuni.TabIndex = 3;
            this.groupBox1Gestiuni.TabStop = false;
            this.groupBox1Gestiuni.Text = "Gestiuni";
            // 
            // radioButtonOGestiune
            // 
            this.radioButtonOGestiune.AutoSize = true;
            this.radioButtonOGestiune.Location = new System.Drawing.Point(6, 57);
            this.radioButtonOGestiune.Name = "radioButtonOGestiune";
            this.radioButtonOGestiune.Size = new System.Drawing.Size(98, 21);
            this.radioButtonOGestiune.TabIndex = 2;
            this.radioButtonOGestiune.Text = "O gestiune";
            this.radioButtonOGestiune.UseVisualStyleBackColor = true;
            this.radioButtonOGestiune.CheckedChanged += new System.EventHandler(this.radioButtonOGestiune_CheckedChanged);
            // 
            // radioButtonToateGestiunile
            // 
            this.radioButtonToateGestiunile.AutoSize = true;
            this.radioButtonToateGestiunile.Location = new System.Drawing.Point(6, 21);
            this.radioButtonToateGestiunile.Name = "radioButtonToateGestiunile";
            this.radioButtonToateGestiunile.Size = new System.Drawing.Size(130, 21);
            this.radioButtonToateGestiunile.TabIndex = 1;
            this.radioButtonToateGestiunile.TabStop = true;
            this.radioButtonToateGestiunile.Text = "Toate gestiunile";
            this.radioButtonToateGestiunile.UseVisualStyleBackColor = true;
            // 
            // comboBoxGestiune
            // 
            this.comboBoxGestiune.FormattingEnabled = true;
            this.comboBoxGestiune.Location = new System.Drawing.Point(452, 208);
            this.comboBoxGestiune.Name = "comboBoxGestiune";
            this.comboBoxGestiune.Size = new System.Drawing.Size(151, 24);
            this.comboBoxGestiune.TabIndex = 5;
            // 
            // buttonAccepta
            // 
            this.buttonAccepta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccepta.Location = new System.Drawing.Point(653, 38);
            this.buttonAccepta.Name = "buttonAccepta";
            this.buttonAccepta.Size = new System.Drawing.Size(170, 61);
            this.buttonAccepta.TabIndex = 6;
            this.buttonAccepta.Text = "Accepta";
            this.buttonAccepta.UseVisualStyleBackColor = true;
            this.buttonAccepta.Click += new System.EventHandler(this.buttonAccepta_Click);
            // 
            // buttonListeaza
            // 
            this.buttonListeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListeaza.Location = new System.Drawing.Point(653, 104);
            this.buttonListeaza.Name = "buttonListeaza";
            this.buttonListeaza.Size = new System.Drawing.Size(170, 61);
            this.buttonListeaza.TabIndex = 7;
            this.buttonListeaza.Text = "Listeaza";
            this.buttonListeaza.UseVisualStyleBackColor = true;
            this.buttonListeaza.Click += new System.EventHandler(this.buttonListeaza_Click);
            // 
            // dataGridViewRaport
            // 
            this.dataGridViewRaport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaport.Location = new System.Drawing.Point(12, 308);
            this.dataGridViewRaport.Name = "dataGridViewRaport";
            this.dataGridViewRaport.RowTemplate.Height = 24;
            this.dataGridViewRaport.Size = new System.Drawing.Size(1009, 273);
            this.dataGridViewRaport.TabIndex = 8;
            // 
            // FormRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 615);
            this.Controls.Add(this.dataGridViewRaport);
            this.Controls.Add(this.buttonListeaza);
            this.Controls.Add(this.buttonAccepta);
            this.Controls.Add(this.comboBoxGestiune);
            this.Controls.Add(this.groupBox1Gestiuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSfarsit);
            this.Controls.Add(this.dataInceput);
            this.Controls.Add(this.groupBox1Liste);
            this.Name = "FormRaport";
            this.Text = "FormRaport";
            this.Load += new System.EventHandler(this.FormRaport_Load);
            this.groupBox1Liste.ResumeLayout(false);
            this.groupBox1Liste.PerformLayout();
            this.groupBox1Gestiuni.ResumeLayout(false);
            this.groupBox1Gestiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1Liste;
        private System.Windows.Forms.RadioButton radioButtonListaIesiri;
        private System.Windows.Forms.RadioButton radioButtonListIntrari;
        private System.Windows.Forms.DateTimePicker dataInceput;
        private System.Windows.Forms.DateTimePicker dataSfarsit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1Gestiuni;
        private System.Windows.Forms.RadioButton radioButtonOGestiune;
        private System.Windows.Forms.RadioButton radioButtonToateGestiunile;
        private System.Windows.Forms.ComboBox comboBoxGestiune;
        private System.Windows.Forms.Button buttonAccepta;
        private System.Windows.Forms.Button buttonListeaza;
        public System.Windows.Forms.DataGridView dataGridViewRaport;
    }
}