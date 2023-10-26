namespace PasiekaMainProject
{
    partial class PasiekaOverview
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
            components = new System.ComponentModel.Container();
            dgvPrzeglad = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CelEnum = new DataGridViewTextBoxColumn();
            celDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsComplete = new DataGridViewCheckBoxColumn();
            dataZaPlanowanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            przegladModelBindingSource = new BindingSource(components);
            tbOpis = new TextBox();
            btnNew = new Button();
            dgvDescriptionUl = new DataGridView();
            UlNr = new DataGridViewTextBoxColumn();
            DataPrzegladu = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataPrzegladuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ulIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ulDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            przegladIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            przegladDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opisUlPrzegladModelBindingSource = new BindingSource(components);
            label1 = new Label();
            lblPrzegladId = new Label();
            label3 = new Label();
            lblCel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtpDataWykonania = new DateTimePicker();
            label5 = new Label();
            dtpDataUtworzenia = new DateTimePicker();
            label2 = new Label();
            dtpDataZaPlanowana = new DateTimePicker();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbOpisUl = new TextBox();
            lblSelectedUl = new Label();
            btnComplete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrzeglad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)przegladModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescriptionUl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opisUlPrzegladModelBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPrzeglad
            // 
            dgvPrzeglad.AllowUserToAddRows = false;
            dgvPrzeglad.AllowUserToDeleteRows = false;
            dgvPrzeglad.AutoGenerateColumns = false;
            dgvPrzeglad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrzeglad.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, CelEnum, celDataGridViewTextBoxColumn, IsComplete, dataZaPlanowanaDataGridViewTextBoxColumn });
            dgvPrzeglad.DataSource = przegladModelBindingSource;
            dgvPrzeglad.Location = new Point(12, 108);
            dgvPrzeglad.Name = "dgvPrzeglad";
            dgvPrzeglad.ReadOnly = true;
            dgvPrzeglad.RowTemplate.Height = 25;
            dgvPrzeglad.Size = new Size(597, 150);
            dgvPrzeglad.TabIndex = 0;
            dgvPrzeglad.CellDoubleClick += dgvPrzeglad_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CelEnum
            // 
            CelEnum.DataPropertyName = "CelEnum";
            CelEnum.HeaderText = "CelEnum";
            CelEnum.Name = "CelEnum";
            CelEnum.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn
            // 
            celDataGridViewTextBoxColumn.DataPropertyName = "Cel";
            celDataGridViewTextBoxColumn.HeaderText = "Cel";
            celDataGridViewTextBoxColumn.Name = "celDataGridViewTextBoxColumn";
            celDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsComplete
            // 
            IsComplete.DataPropertyName = "IsCompleted";
            IsComplete.HeaderText = "Wykonany";
            IsComplete.Name = "IsComplete";
            IsComplete.ReadOnly = true;
            IsComplete.Resizable = DataGridViewTriState.True;
            IsComplete.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataZaPlanowanaDataGridViewTextBoxColumn
            // 
            dataZaPlanowanaDataGridViewTextBoxColumn.DataPropertyName = "DataZaPlanowana";
            dataZaPlanowanaDataGridViewTextBoxColumn.HeaderText = "DataZaPlanowana";
            dataZaPlanowanaDataGridViewTextBoxColumn.Name = "dataZaPlanowanaDataGridViewTextBoxColumn";
            dataZaPlanowanaDataGridViewTextBoxColumn.ReadOnly = true;
            dataZaPlanowanaDataGridViewTextBoxColumn.Width = 150;
            // 
            // przegladModelBindingSource
            // 
            przegladModelBindingSource.DataSource = typeof(Model.PrzegladModel);
            // 
            // tbOpis
            // 
            tbOpis.Enabled = false;
            tbOpis.Location = new Point(315, 264);
            tbOpis.Multiline = true;
            tbOpis.Name = "tbOpis";
            tbOpis.Size = new Size(294, 150);
            tbOpis.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(12, 79);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(153, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nowy Przegląd";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvDescriptionUl
            // 
            dgvDescriptionUl.AllowUserToAddRows = false;
            dgvDescriptionUl.AllowUserToDeleteRows = false;
            dgvDescriptionUl.AutoGenerateColumns = false;
            dgvDescriptionUl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescriptionUl.Columns.AddRange(new DataGridViewColumn[] { UlNr, DataPrzegladu, idDataGridViewTextBoxColumn1, dataPrzegladuDataGridViewTextBoxColumn, opisDataGridViewTextBoxColumn, ulIdDataGridViewTextBoxColumn, ulDataGridViewTextBoxColumn, przegladIdDataGridViewTextBoxColumn, przegladDataGridViewTextBoxColumn, numerDataGridViewTextBoxColumn });
            dgvDescriptionUl.DataSource = opisUlPrzegladModelBindingSource;
            dgvDescriptionUl.Location = new Point(687, 108);
            dgvDescriptionUl.Name = "dgvDescriptionUl";
            dgvDescriptionUl.ReadOnly = true;
            dgvDescriptionUl.RowTemplate.Height = 25;
            dgvDescriptionUl.Size = new Size(298, 150);
            dgvDescriptionUl.TabIndex = 3;
            dgvDescriptionUl.CellDoubleClick += dgvDescriptionUl_CellDoubleClick;
            // 
            // UlNr
            // 
            UlNr.DataPropertyName = "Numer";
            UlNr.HeaderText = "Numer Ula";
            UlNr.Name = "UlNr";
            UlNr.ReadOnly = true;
            // 
            // DataPrzegladu
            // 
            DataPrzegladu.DataPropertyName = "DataPrzegladu";
            DataPrzegladu.HeaderText = "Data Przegladu";
            DataPrzegladu.Name = "DataPrzegladu";
            DataPrzegladu.ReadOnly = true;
            DataPrzegladu.Width = 150;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataPrzegladuDataGridViewTextBoxColumn
            // 
            dataPrzegladuDataGridViewTextBoxColumn.DataPropertyName = "DataPrzegladu";
            dataPrzegladuDataGridViewTextBoxColumn.HeaderText = "DataPrzegladu";
            dataPrzegladuDataGridViewTextBoxColumn.Name = "dataPrzegladuDataGridViewTextBoxColumn";
            dataPrzegladuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulIdDataGridViewTextBoxColumn
            // 
            ulIdDataGridViewTextBoxColumn.DataPropertyName = "UlId";
            ulIdDataGridViewTextBoxColumn.HeaderText = "UlId";
            ulIdDataGridViewTextBoxColumn.Name = "ulIdDataGridViewTextBoxColumn";
            ulIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulDataGridViewTextBoxColumn
            // 
            ulDataGridViewTextBoxColumn.DataPropertyName = "Ul";
            ulDataGridViewTextBoxColumn.HeaderText = "Ul";
            ulDataGridViewTextBoxColumn.Name = "ulDataGridViewTextBoxColumn";
            ulDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // przegladIdDataGridViewTextBoxColumn
            // 
            przegladIdDataGridViewTextBoxColumn.DataPropertyName = "PrzegladId";
            przegladIdDataGridViewTextBoxColumn.HeaderText = "PrzegladId";
            przegladIdDataGridViewTextBoxColumn.Name = "przegladIdDataGridViewTextBoxColumn";
            przegladIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // przegladDataGridViewTextBoxColumn
            // 
            przegladDataGridViewTextBoxColumn.DataPropertyName = "Przeglad";
            przegladDataGridViewTextBoxColumn.HeaderText = "Przeglad";
            przegladDataGridViewTextBoxColumn.Name = "przegladDataGridViewTextBoxColumn";
            przegladDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            numerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisUlPrzegladModelBindingSource
            // 
            opisUlPrzegladModelBindingSource.DataSource = typeof(Model.OpisUlPrzegladModel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 4;
            label1.Text = "Wybrany Przegląd:";
            // 
            // lblPrzegladId
            // 
            lblPrzegladId.AutoSize = true;
            lblPrzegladId.Dock = DockStyle.Fill;
            lblPrzegladId.Location = new Point(153, 0);
            lblPrzegladId.Name = "lblPrzegladId";
            lblPrzegladId.Size = new Size(144, 30);
            lblPrzegladId.TabIndex = 5;
            lblPrzegladId.Text = "_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 6;
            label3.Text = "Cel Przeglądu:";
            // 
            // lblCel
            // 
            lblCel.AutoSize = true;
            lblCel.Dock = DockStyle.Fill;
            lblCel.Location = new Point(153, 30);
            lblCel.Name = "lblCel";
            lblCel.Size = new Size(144, 30);
            lblCel.TabIndex = 7;
            lblCel.Text = "_";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(dtpDataWykonania, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCel, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPrzegladId, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpDataUtworzenia, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpDataZaPlanowana, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 264);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(300, 150);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // dtpDataWykonania
            // 
            dtpDataWykonania.Enabled = false;
            dtpDataWykonania.Format = DateTimePickerFormat.Short;
            dtpDataWykonania.Location = new Point(153, 123);
            dtpDataWykonania.Name = "dtpDataWykonania";
            dtpDataWykonania.Size = new Size(144, 23);
            dtpDataWykonania.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(144, 30);
            label5.TabIndex = 12;
            label5.Text = "Data Wykonania";
            // 
            // dtpDataUtworzenia
            // 
            dtpDataUtworzenia.Dock = DockStyle.Fill;
            dtpDataUtworzenia.Enabled = false;
            dtpDataUtworzenia.Format = DateTimePickerFormat.Short;
            dtpDataUtworzenia.Location = new Point(153, 63);
            dtpDataUtworzenia.Name = "dtpDataUtworzenia";
            dtpDataUtworzenia.Size = new Size(144, 23);
            dtpDataUtworzenia.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 8;
            label2.Text = "Data Utworzenia:";
            // 
            // dtpDataZaPlanowana
            // 
            dtpDataZaPlanowana.Dock = DockStyle.Fill;
            dtpDataZaPlanowana.Enabled = false;
            dtpDataZaPlanowana.Format = DateTimePickerFormat.Short;
            dtpDataZaPlanowana.Location = new Point(153, 93);
            dtpDataZaPlanowana.Name = "dtpDataZaPlanowana";
            dtpDataZaPlanowana.Size = new Size(144, 23);
            dtpDataZaPlanowana.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(144, 30);
            label4.TabIndex = 11;
            label4.Text = "Data Za Planowana:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tbOpisUl, 0, 1);
            tableLayoutPanel2.Controls.Add(lblSelectedUl, 0, 0);
            tableLayoutPanel2.Controls.Add(btnComplete, 0, 2);
            tableLayoutPanel2.Location = new Point(687, 264);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.2452831F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.754715F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(298, 150);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tbOpisUl
            // 
            tbOpisUl.Dock = DockStyle.Fill;
            tbOpisUl.Enabled = false;
            tbOpisUl.Location = new Point(3, 34);
            tbOpisUl.Multiline = true;
            tbOpisUl.Name = "tbOpisUl";
            tbOpisUl.Size = new Size(292, 69);
            tbOpisUl.TabIndex = 10;
            // 
            // lblSelectedUl
            // 
            lblSelectedUl.AutoSize = true;
            lblSelectedUl.Location = new Point(3, 0);
            lblSelectedUl.Name = "lblSelectedUl";
            lblSelectedUl.Size = new Size(12, 15);
            lblSelectedUl.TabIndex = 11;
            lblSelectedUl.Text = "_";
            // 
            // btnComplete
            // 
            btnComplete.Dock = DockStyle.Fill;
            btnComplete.Enabled = false;
            btnComplete.Location = new Point(3, 109);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(292, 38);
            btnComplete.TabIndex = 12;
            btnComplete.Text = "Wykonanj Przegląd ";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(171, 79);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Edytuj";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // PasiekaOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 570);
            Controls.Add(btnUpdate);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvDescriptionUl);
            Controls.Add(btnNew);
            Controls.Add(tbOpis);
            Controls.Add(dgvPrzeglad);
            Name = "PasiekaOverview";
            Text = "PasiekaOverview";
            Load += PasiekaOverview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrzeglad).EndInit();
            ((System.ComponentModel.ISupportInitialize)przegladModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescriptionUl).EndInit();
            ((System.ComponentModel.ISupportInitialize)opisUlPrzegladModelBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrzeglad;
        private BindingSource przegladModelBindingSource;
        private TextBox tbOpis;
        private Button btnNew;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CelEnum;
        private DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsComplete;
        private DataGridViewTextBoxColumn dataZaPlanowanaDataGridViewTextBoxColumn;
        private DataGridView dgvDescriptionUl;
        private Label label1;
        private Label lblPrzegladId;
        private Label label3;
        private Label lblCel;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtpDataUtworzenia;
        private Label label2;
        private DateTimePicker dtpDataWykonania;
        private Label label5;
        private DateTimePicker dtpDataZaPlanowana;
        private Label label4;
        private BindingSource opisUlPrzegladModelBindingSource;
        private DataGridViewTextBoxColumn UlNr;
        private DataGridViewTextBoxColumn DataPrzegladu;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataPrzegladuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ulIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ulDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn przegladIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn przegladDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbOpisUl;
        private Label lblSelectedUl;
        private Button btnComplete;
        private Button btnUpdate;
    }
}