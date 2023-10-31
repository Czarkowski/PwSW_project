namespace PasiekaMainProject
{
    partial class OverviewHistory
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
            dgvOverview = new DataGridView();
            przegladIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CelEnum = new DataGridViewTextBoxColumn();
            DataZaplanowana = new DataGridViewTextBoxColumn();
            dataPrzegladuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsCompleted = new DataGridViewCheckBoxColumn();
            opisUlPrzegladModelBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMain = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dtpDataWykonania = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            lblCel = new Label();
            lblPrzegladId = new Label();
            label3 = new Label();
            dtpDataUtworzenia = new DateTimePicker();
            label4 = new Label();
            dtpDataZaPlanowana = new DateTimePicker();
            label6 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            tbUlOpis = new TextBox();
            tbPrzegldOpis = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            cbFilterCel = new ComboBox();
            label9 = new Label();
            chFilterNotDone = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opisUlPrzegladModelBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOverview
            // 
            dgvOverview.AllowUserToAddRows = false;
            dgvOverview.AllowUserToDeleteRows = false;
            dgvOverview.AutoGenerateColumns = false;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Columns.AddRange(new DataGridViewColumn[] { przegladIdDataGridViewTextBoxColumn, CelEnum, DataZaplanowana, dataPrzegladuDataGridViewTextBoxColumn, IsCompleted });
            dgvOverview.DataSource = opisUlPrzegladModelBindingSource;
            dgvOverview.Dock = DockStyle.Fill;
            dgvOverview.Location = new Point(3, 66);
            dgvOverview.Name = "dgvOverview";
            dgvOverview.ReadOnly = true;
            dgvOverview.RowTemplate.Height = 25;
            dgvOverview.Size = new Size(553, 542);
            dgvOverview.TabIndex = 0;
            dgvOverview.CellDoubleClick += dgvOverview_CellDoubleClick;
            // 
            // przegladIdDataGridViewTextBoxColumn
            // 
            przegladIdDataGridViewTextBoxColumn.DataPropertyName = "PrzegladId";
            przegladIdDataGridViewTextBoxColumn.HeaderText = "PrzegladId";
            przegladIdDataGridViewTextBoxColumn.Name = "przegladIdDataGridViewTextBoxColumn";
            przegladIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CelEnum
            // 
            CelEnum.DataPropertyName = "CelEnum";
            CelEnum.HeaderText = "CelEnum";
            CelEnum.Name = "CelEnum";
            CelEnum.ReadOnly = true;
            // 
            // DataZaplanowana
            // 
            DataZaplanowana.DataPropertyName = "DataZaplanowana";
            DataZaplanowana.HeaderText = "Data Zaplanowana";
            DataZaplanowana.Name = "DataZaplanowana";
            DataZaplanowana.ReadOnly = true;
            // 
            // dataPrzegladuDataGridViewTextBoxColumn
            // 
            dataPrzegladuDataGridViewTextBoxColumn.DataPropertyName = "DataPrzegladu";
            dataPrzegladuDataGridViewTextBoxColumn.HeaderText = "Data Wykonania";
            dataPrzegladuDataGridViewTextBoxColumn.Name = "dataPrzegladuDataGridViewTextBoxColumn";
            dataPrzegladuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsCompleted
            // 
            IsCompleted.DataPropertyName = "IsCompleted";
            IsCompleted.HeaderText = "Ukończono";
            IsCompleted.Name = "IsCompleted";
            IsCompleted.ReadOnly = true;
            // 
            // opisUlPrzegladModelBindingSource
            // 
            opisUlPrzegladModelBindingSource.DataSource = typeof(Model.OpisUlPrzegladModel);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 578F));
            tableLayoutPanel1.Controls.Add(dgvOverview, 0, 1);
            tableLayoutPanel1.Controls.Add(lblMain, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4746313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.52537F));
            tableLayoutPanel1.Size = new Size(1137, 611);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Dock = DockStyle.Fill;
            lblMain.Location = new Point(3, 0);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(553, 63);
            lblMain.TabIndex = 1;
            lblMain.Text = "_";
            lblMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(562, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.82143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.17857F));
            tableLayoutPanel2.Size = new Size(572, 542);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(dtpDataWykonania, 1, 4);
            tableLayoutPanel4.Controls.Add(label5, 0, 4);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(lblCel, 1, 1);
            tableLayoutPanel4.Controls.Add(lblPrzegladId, 1, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(dtpDataUtworzenia, 1, 2);
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(dtpDataZaPlanowana, 1, 3);
            tableLayoutPanel4.Controls.Add(label6, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.Size = new Size(566, 182);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // dtpDataWykonania
            // 
            dtpDataWykonania.Dock = DockStyle.Fill;
            dtpDataWykonania.Enabled = false;
            dtpDataWykonania.Format = DateTimePickerFormat.Short;
            dtpDataWykonania.Location = new Point(153, 123);
            dtpDataWykonania.Name = "dtpDataWykonania";
            dtpDataWykonania.Size = new Size(410, 23);
            dtpDataWykonania.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 120);
            label5.Name = "label5";
            label5.Size = new Size(144, 62);
            label5.TabIndex = 12;
            label5.Text = "Data Wykonania";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 4;
            label2.Text = "Wybrany Przegląd:";
            // 
            // lblCel
            // 
            lblCel.AutoSize = true;
            lblCel.Dock = DockStyle.Fill;
            lblCel.Location = new Point(153, 30);
            lblCel.Name = "lblCel";
            lblCel.Size = new Size(410, 30);
            lblCel.TabIndex = 7;
            lblCel.Text = "_";
            // 
            // lblPrzegladId
            // 
            lblPrzegladId.AutoSize = true;
            lblPrzegladId.Dock = DockStyle.Fill;
            lblPrzegladId.Location = new Point(153, 0);
            lblPrzegladId.Name = "lblPrzegladId";
            lblPrzegladId.Size = new Size(410, 30);
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
            // dtpDataUtworzenia
            // 
            dtpDataUtworzenia.Dock = DockStyle.Fill;
            dtpDataUtworzenia.Enabled = false;
            dtpDataUtworzenia.Format = DateTimePickerFormat.Short;
            dtpDataUtworzenia.Location = new Point(153, 63);
            dtpDataUtworzenia.Name = "dtpDataUtworzenia";
            dtpDataUtworzenia.Size = new Size(410, 23);
            dtpDataUtworzenia.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(144, 30);
            label4.TabIndex = 8;
            label4.Text = "Data Utworzenia:";
            // 
            // dtpDataZaPlanowana
            // 
            dtpDataZaPlanowana.Dock = DockStyle.Fill;
            dtpDataZaPlanowana.Enabled = false;
            dtpDataZaPlanowana.Format = DateTimePickerFormat.Short;
            dtpDataZaPlanowana.Location = new Point(153, 93);
            dtpDataZaPlanowana.Name = "dtpDataZaPlanowana";
            dtpDataZaPlanowana.Size = new Size(410, 23);
            dtpDataZaPlanowana.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(144, 30);
            label6.TabIndex = 11;
            label6.Text = "Data Zaplanowana:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label7, 0, 0);
            tableLayoutPanel5.Controls.Add(label8, 1, 0);
            tableLayoutPanel5.Controls.Add(tbUlOpis, 0, 1);
            tableLayoutPanel5.Controls.Add(tbPrzegldOpis, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 191);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10.13986F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 89.86014F));
            tableLayoutPanel5.Size = new Size(566, 348);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(277, 35);
            label7.TabIndex = 0;
            label7.Text = "Opis wykonania dla wybranego ula ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(286, 0);
            label8.Name = "label8";
            label8.Size = new Size(277, 35);
            label8.TabIndex = 1;
            label8.Text = "Opis Przeglądu";
            // 
            // tbUlOpis
            // 
            tbUlOpis.Dock = DockStyle.Fill;
            tbUlOpis.Enabled = false;
            tbUlOpis.Location = new Point(3, 38);
            tbUlOpis.Multiline = true;
            tbUlOpis.Name = "tbUlOpis";
            tbUlOpis.Size = new Size(277, 307);
            tbUlOpis.TabIndex = 2;
            // 
            // tbPrzegldOpis
            // 
            tbPrzegldOpis.Dock = DockStyle.Fill;
            tbPrzegldOpis.Enabled = false;
            tbPrzegldOpis.Location = new Point(286, 38);
            tbPrzegldOpis.Multiline = true;
            tbPrzegldOpis.Name = "tbPrzegldOpis";
            tbPrzegldOpis.Size = new Size(277, 307);
            tbPrzegldOpis.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(cbFilterCel, 0, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(chFilterNotDone, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(562, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(572, 57);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // cbFilterCel
            // 
            cbFilterCel.Anchor = AnchorStyles.None;
            cbFilterCel.FormattingEnabled = true;
            cbFilterCel.Location = new Point(36, 17);
            cbFilterCel.Name = "cbFilterCel";
            cbFilterCel.Size = new Size(121, 23);
            cbFilterCel.TabIndex = 17;
            cbFilterCel.SelectedIndexChanged += cbFilterCel_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(27, 57);
            label9.TabIndex = 16;
            label9.Text = "Cel:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chFilterNotDone
            // 
            chFilterNotDone.AutoSize = true;
            chFilterNotDone.Dock = DockStyle.Fill;
            chFilterNotDone.Location = new Point(163, 3);
            chFilterNotDone.Name = "chFilterNotDone";
            chFilterNotDone.Size = new Size(106, 51);
            chFilterNotDone.TabIndex = 15;
            chFilterNotDone.Text = "Do Wykonania:";
            chFilterNotDone.UseVisualStyleBackColor = true;
            chFilterNotDone.CheckedChanged += chFilterNotDone_CheckedChanged;
            // 
            // OverviewHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 611);
            Controls.Add(tableLayoutPanel1);
            Name = "OverviewHistory";
            Text = "OverviewHistory";
            Load += OverviewHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)opisUlPrzegladModelBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOverview;
        private BindingSource opisUlPrzegladModelBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMain;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private DateTimePicker dtpDataWykonania;
        private Label label5;
        private Label label2;
        private Label lblCel;
        private Label lblPrzegladId;
        private Label label3;
        private DateTimePicker dtpDataUtworzenia;
        private Label label4;
        private DateTimePicker dtpDataZaPlanowana;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
        private Label label8;
        private TextBox tbUlOpis;
        private TextBox tbPrzegldOpis;
        private CheckBox chFilterNotDone;
        private Label label9;
        private ComboBox cbFilterCel;
        private DataGridViewTextBoxColumn przegladIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CelEnum;
        private DataGridViewTextBoxColumn DataZaplanowana;
        private DataGridViewTextBoxColumn dataPrzegladuDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsCompleted;
    }
}