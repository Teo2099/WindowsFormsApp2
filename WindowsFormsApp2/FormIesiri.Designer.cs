namespace WindowsFormsApp2
{
    partial class FormIesiri
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label gestiuneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIesiri));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonUpdate = new System.Windows.Forms.ToolStripButton();
            this.buttonDelete = new System.Windows.Forms.ToolStripButton();
            this.buttonInsert = new System.Windows.Forms.ToolStripButton();
            this.buttonClear = new System.Windows.Forms.ToolStripButton();
            this.gestiuneComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.iesiri_detaliuDataGridView = new System.Windows.Forms.DataGridView();
            this.detaliu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliu_id_iesiri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuProdus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detaliuCantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliuValoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            gestiuneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iesiri_detaliuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(30, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 95;
            idLabel.Text = "id:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.Location = new System.Drawing.Point(30, 77);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(52, 17);
            numarLabel.TabIndex = 96;
            numarLabel.Text = "numar:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(30, 106);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(40, 17);
            dataLabel.TabIndex = 97;
            dataLabel.Text = "data:";
            // 
            // gestiuneLabel
            // 
            gestiuneLabel.AutoSize = true;
            gestiuneLabel.Location = new System.Drawing.Point(30, 130);
            gestiuneLabel.Name = "gestiuneLabel";
            gestiuneLabel.Size = new System.Drawing.Size(66, 17);
            gestiuneLabel.TabIndex = 99;
            gestiuneLabel.Text = "gestiune:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.buttonUpdate,
            this.buttonDelete,
            this.buttonInsert,
            this.buttonClear});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1444, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(67, 24);
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(63, 24);
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonInsert
            // 
            this.buttonInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
            this.buttonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(60, 24);
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 24);
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // gestiuneComboBox
            // 
            this.gestiuneComboBox.FormattingEnabled = true;
            this.gestiuneComboBox.Location = new System.Drawing.Point(102, 130);
            this.gestiuneComboBox.Name = "gestiuneComboBox";
            this.gestiuneComboBox.Size = new System.Drawing.Size(243, 24);
            this.gestiuneComboBox.TabIndex = 104;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(102, 102);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker.TabIndex = 102;
            // 
            // numarTextBox
            // 
            this.numarTextBox.Location = new System.Drawing.Point(102, 74);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(243, 22);
            this.numarTextBox.TabIndex = 101;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(102, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(243, 22);
            this.idTextBox.TabIndex = 100;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // iesiri_detaliuDataGridView
            // 
            this.iesiri_detaliuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iesiri_detaliuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iesiri_detaliuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detaliu_id,
            this.detaliu_id_iesiri,
            this.detaliuProdus,
            this.detaliuCantitate,
            this.detaliuValoare});
            this.iesiri_detaliuDataGridView.Location = new System.Drawing.Point(59, 289);
            this.iesiri_detaliuDataGridView.Name = "iesiri_detaliuDataGridView";
            this.iesiri_detaliuDataGridView.RowTemplate.Height = 24;
            this.iesiri_detaliuDataGridView.Size = new System.Drawing.Size(1084, 194);
            this.iesiri_detaliuDataGridView.TabIndex = 105;
            this.iesiri_detaliuDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.iesiri_detaliuDataGridView_CellEndEdit);
            this.iesiri_detaliuDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.iesiri_detaliuDataGridView_DataError);
            // 
            // detaliu_id
            // 
            this.detaliu_id.DataPropertyName = "id";
            this.detaliu_id.HeaderText = "id";
            this.detaliu_id.Name = "detaliu_id";
            this.detaliu_id.Visible = false;
            // 
            // detaliu_id_iesiri
            // 
            this.detaliu_id_iesiri.DataPropertyName = "id_iesiri";
            this.detaliu_id_iesiri.HeaderText = "id_intrari";
            this.detaliu_id_iesiri.Name = "detaliu_id_iesiri";
            this.detaliu_id_iesiri.Visible = false;
            // 
            // detaliuProdus
            // 
            this.detaliuProdus.DataPropertyName = "produs";
            this.detaliuProdus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.detaliuProdus.HeaderText = "produs";
            this.detaliuProdus.Name = "detaliuProdus";
            this.detaliuProdus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detaliuProdus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // detaliuCantitate
            // 
            this.detaliuCantitate.DataPropertyName = "cantitate";
            this.detaliuCantitate.HeaderText = "cantitate";
            this.detaliuCantitate.Name = "detaliuCantitate";
            // 
            // detaliuValoare
            // 
            this.detaliuValoare.DataPropertyName = "valoare";
            this.detaliuValoare.HeaderText = "valoare";
            this.detaliuValoare.Name = "detaliuValoare";
            // 
            // FormIesiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 513);
            this.Controls.Add(this.iesiri_detaliuDataGridView);
            this.Controls.Add(this.gestiuneComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(numarLabel);
            this.Controls.Add(dataLabel);
            this.Controls.Add(gestiuneLabel);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "FormIesiri";
            this.Text = "FormIesiri";
            this.Load += new System.EventHandler(this.FormIesiri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iesiri_detaliuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton buttonUpdate;
        private System.Windows.Forms.ToolStripButton buttonDelete;
        private System.Windows.Forms.ToolStripButton buttonInsert;
        private System.Windows.Forms.ComboBox gestiuneComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView iesiri_detaliuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliu_id_iesiri;
        private System.Windows.Forms.DataGridViewComboBoxColumn detaliuProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliuCantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliuValoare;
        private System.Windows.Forms.ToolStripButton buttonClear;
    }
}