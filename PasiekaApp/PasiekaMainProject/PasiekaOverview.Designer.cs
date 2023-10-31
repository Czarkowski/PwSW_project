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
            przegladModelBindingSource = new BindingSource(components);
            tbOpis = new TextBox();
            btnNew = new Button();
            dgvDescriptionUl = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            UlNr = new DataGridViewTextBoxColumn();
            DataPrzegladu = new DataGridViewTextBoxColumn();
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
            label6 = new Label();
            cbFilterCel = new ComboBox();
            chFilterNotDone = new CheckBox();
            btnForce = new Button();
            btnDelete = new Button();
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
            dgvPrzeglad.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, CelEnum, celDataGridViewTextBoxColumn, IsComplete });
            dgvPrzeglad.DataSource = przegladModelBindingSource;
            dgvPrzeglad.Location = new Point(3, 32);
            dgvPrzeglad.Name = "dgvPrzeglad";
            dgvPrzeglad.ReadOnly = true;
            dgvPrzeglad.RowTemplate.Height = 25;
            dgvPrzeglad.Size = new Size(597, 349);
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
            // przegladModelBindingSource
            // 
            przegladModelBindingSource.DataSource = typeof(Model.PrzegladModel);
            // 
            // tbOpis
            // 
            tbOpis.Enabled = false;
            tbOpis.Location = new Point(306, 387);
            tbOpis.Multiline = true;
            tbOpis.Name = "tbOpis";
            tbOpis.Size = new Size(294, 150);
            tbOpis.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(3, 3);
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
            dgvDescriptionUl.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, UlNr, DataPrzegladu });
            dgvDescriptionUl.DataSource = opisUlPrzegladModelBindingSource;
            dgvDescriptionUl.Location = new Point(678, 32);
            dgvDescriptionUl.Name = "dgvDescriptionUl";
            dgvDescriptionUl.ReadOnly = true;
            dgvDescriptionUl.RowTemplate.Height = 25;
            dgvDescriptionUl.Size = new Size(324, 349);
            dgvDescriptionUl.TabIndex = 3;
            dgvDescriptionUl.CellDoubleClick += dgvDescriptionUl_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 30;
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
            tableLayoutPanel1.Location = new Point(3, 387);
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
            label4.Text = "Data Zaplanowana:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tbOpisUl, 0, 1);
            tableLayoutPanel2.Controls.Add(lblSelectedUl, 0, 0);
            tableLayoutPanel2.Controls.Add(btnComplete, 0, 2);
            tableLayoutPanel2.Location = new Point(678, 387);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.2452831F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.754715F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.Size = new Size(324, 150);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tbOpisUl
            // 
            tbOpisUl.Dock = DockStyle.Fill;
            tbOpisUl.Enabled = false;
            tbOpisUl.Location = new Point(3, 34);
            tbOpisUl.Multiline = true;
            tbOpisUl.Name = "tbOpisUl";
            tbOpisUl.Size = new Size(318, 69);
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
            btnComplete.Size = new Size(318, 38);
            btnComplete.TabIndex = 12;
            btnComplete.Text = "Wykonanj Przegląd ";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(162, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(153, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Edytuj";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 7);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 11;
            label6.Text = "Cel:";
            // 
            // cbFilterCel
            // 
            cbFilterCel.FormattingEnabled = true;
            cbFilterCel.Location = new Point(367, 3);
            cbFilterCel.Name = "cbFilterCel";
            cbFilterCel.Size = new Size(121, 23);
            cbFilterCel.TabIndex = 12;
            cbFilterCel.SelectedIndexChanged += cbFilterCel_SelectedIndexChanged;
            // 
            // chFilterNotDone
            // 
            chFilterNotDone.AutoSize = true;
            chFilterNotDone.Location = new Point(494, 7);
            chFilterNotDone.Name = "chFilterNotDone";
            chFilterNotDone.Size = new Size(106, 19);
            chFilterNotDone.TabIndex = 14;
            chFilterNotDone.Text = "Do Wykonania:";
            chFilterNotDone.UseVisualStyleBackColor = true;
            chFilterNotDone.CheckedChanged += chFilterIsDone_CheckedChanged;
            // 
            // btnForce
            // 
            btnForce.Location = new Point(6, 543);
            btnForce.Name = "btnForce";
            btnForce.Size = new Size(297, 32);
            btnForce.TabIndex = 15;
            btnForce.Text = "Wymuś Wykonanie";
            btnForce.UseVisualStyleBackColor = true;
            btnForce.Click += btnForce_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(309, 543);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(291, 32);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Usuń";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // PasiekaOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnForce);
            Controls.Add(chFilterNotDone);
            Controls.Add(cbFilterCel);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvDescriptionUl);
            Controls.Add(btnNew);
            Controls.Add(tbOpis);
            Controls.Add(dgvPrzeglad);
            Name = "PasiekaOverview";
            Size = new Size(1038, 610);
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
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbOpisUl;
        private Label lblSelectedUl;
        private Button btnComplete;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn UlNr;
        private DataGridViewTextBoxColumn DataPrzegladu;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CelEnum;
        private DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsComplete;
        private DataGridViewTextBoxColumn dataZaPlanowanaDataGridViewTextBoxColumn;
        private Label label6;
        private ComboBox cbFilterCel;
        private CheckBox chFilterNotDone;
        private Button btnForce;
        private Button btnDelete;
    }
}