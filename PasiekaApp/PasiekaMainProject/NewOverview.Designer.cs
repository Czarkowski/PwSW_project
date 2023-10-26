namespace PasiekaMainProject
{
    partial class NewOverview
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            rtbOpis = new RichTextBox();
            tbCel = new TextBox();
            cbCelEnum = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvSelected = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ulModelBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            dgvAvailable = new DataGridView();
            numerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RasaNazwa = new DataGridViewTextBoxColumn();
            DataOstatniegoPrzegladu = new DataGridViewTextBoxColumn();
            btnOk = new Button();
            btnCancle = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ulModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.06497F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.93503F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancle, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1222, 612);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel2.Controls.Add(rtbOpis, 1, 3);
            tableLayoutPanel2.Controls.Add(tbCel, 1, 1);
            tableLayoutPanel2.Controls.Add(cbCelEnum, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(410, 494);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 0;
            label3.Text = "Planowana Data: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(117, 404);
            label4.TabIndex = 1;
            label4.Text = "Opis ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(117, 30);
            label5.TabIndex = 2;
            label5.Text = "Cel:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 60);
            label6.Name = "label6";
            label6.Size = new Size(117, 30);
            label6.TabIndex = 3;
            label6.Text = "Cel Enum:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(126, 3);
            dtpDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(281, 23);
            dtpDate.TabIndex = 4;
            // 
            // rtbOpis
            // 
            rtbOpis.Dock = DockStyle.Fill;
            rtbOpis.Location = new Point(126, 93);
            rtbOpis.Name = "rtbOpis";
            rtbOpis.Size = new Size(281, 398);
            rtbOpis.TabIndex = 5;
            rtbOpis.Text = "";
            // 
            // tbCel
            // 
            tbCel.Dock = DockStyle.Fill;
            tbCel.Location = new Point(126, 33);
            tbCel.Name = "tbCel";
            tbCel.Size = new Size(281, 23);
            tbCel.TabIndex = 6;
            // 
            // cbCelEnum
            // 
            cbCelEnum.Dock = DockStyle.Fill;
            cbCelEnum.FormattingEnabled = true;
            cbCelEnum.Location = new Point(126, 63);
            cbCelEnum.Name = "cbCelEnum";
            cbCelEnum.Size = new Size(281, 23);
            cbCelEnum.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dgvSelected, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvAvailable, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(419, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(800, 494);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dgvSelected
            // 
            dgvSelected.AllowUserToAddRows = false;
            dgvSelected.AllowUserToDeleteRows = false;
            dgvSelected.AutoGenerateColumns = false;
            dgvSelected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelected.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvSelected.DataSource = ulModelBindingSource;
            dgvSelected.Dock = DockStyle.Fill;
            dgvSelected.Location = new Point(403, 43);
            dgvSelected.Name = "dgvSelected";
            dgvSelected.ReadOnly = true;
            dgvSelected.RowTemplate.Height = 25;
            dgvSelected.Size = new Size(394, 448);
            dgvSelected.TabIndex = 3;
            dgvSelected.CellContentDoubleClick += dgvSelected_CellContentDoubleClick;
            dgvSelected.CellDoubleClick += dgvSelected_CellContentDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Numer";
            dataGridViewTextBoxColumn1.HeaderText = "Numer";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "RasaNazwa";
            dataGridViewTextBoxColumn2.HeaderText = "RasaNazwa";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "DataOstatniegoPrzegladu";
            dataGridViewTextBoxColumn3.HeaderText = "DataOstatniegoPrzegladu";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ulModelBindingSource
            // 
            ulModelBindingSource.DataSource = typeof(Model.UlModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(403, 0);
            label2.Name = "label2";
            label2.Size = new Size(394, 40);
            label2.TabIndex = 1;
            label2.Text = "Wybrane";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 40);
            label1.TabIndex = 0;
            label1.Text = "Dostępne";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAvailable
            // 
            dgvAvailable.AllowUserToAddRows = false;
            dgvAvailable.AllowUserToDeleteRows = false;
            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Columns.AddRange(new DataGridViewColumn[] { numerDataGridViewTextBoxColumn, RasaNazwa, DataOstatniegoPrzegladu });
            dgvAvailable.DataSource = ulModelBindingSource;
            dgvAvailable.Dock = DockStyle.Fill;
            dgvAvailable.Location = new Point(3, 43);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.ReadOnly = true;
            dgvAvailable.RowTemplate.Height = 25;
            dgvAvailable.Size = new Size(394, 448);
            dgvAvailable.TabIndex = 2;
            dgvAvailable.CellContentDoubleClick += dgvAvailable_CellContentDoubleClick;
            dgvAvailable.CellDoubleClick += dgvAvailable_CellContentDoubleClick;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            numerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RasaNazwa
            // 
            RasaNazwa.DataPropertyName = "RasaNazwa";
            RasaNazwa.HeaderText = "RasaNazwa";
            RasaNazwa.Name = "RasaNazwa";
            RasaNazwa.ReadOnly = true;
            // 
            // DataOstatniegoPrzegladu
            // 
            DataOstatniegoPrzegladu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataOstatniegoPrzegladu.DataPropertyName = "DataOstatniegoPrzegladu";
            DataOstatniegoPrzegladu.HeaderText = "DataOstatniegoPrzegladu";
            DataOstatniegoPrzegladu.Name = "DataOstatniegoPrzegladu";
            DataOstatniegoPrzegladu.ReadOnly = true;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Fill;
            btnOk.Location = new Point(3, 503);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(410, 106);
            btnOk.TabIndex = 2;
            btnOk.Text = "Utwórz";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancle
            // 
            btnCancle.Dock = DockStyle.Fill;
            btnCancle.Location = new Point(419, 503);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(800, 106);
            btnCancle.TabIndex = 3;
            btnCancle.Text = "Anuluj";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // NewOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1222, 612);
            Controls.Add(tableLayoutPanel1);
            Name = "NewOverview";
            Text = "NewOverview";
            Load += NewOverview_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)ulModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDate;
        private RichTextBox rtbOpis;
        private TextBox tbCel;
        private DataGridView dgvAvailable;
        private BindingSource ulModelBindingSource;
        private Button btnOk;
        private Button btnCancle;
        private DataGridView dgvSelected;
        private DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RasaNazwa;
        private DataGridViewTextBoxColumn DataOstatniegoPrzegladu;
        private ComboBox cbCelEnum;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}