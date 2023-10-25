namespace PasiekaMainProject
{
    partial class ChagneQueen
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
            rasaModelBindingSource = new BindingSource(components);
            cbRace = new ComboBox();
            btnOk = new Button();
            nudAge = new NumericUpDown();
            btnCancle = new Button();
            pb1 = new ProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pb2 = new ProgressBar();
            pb3 = new ProgressBar();
            pb4 = new ProgressBar();
            pb5 = new ProgressBar();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)rasaModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rasaModelBindingSource
            // 
            rasaModelBindingSource.DataSource = typeof(Model.RasaModel);
            // 
            // cbRace
            // 
            cbRace.DataSource = rasaModelBindingSource;
            cbRace.DisplayMember = "Nazwa";
            cbRace.Dock = DockStyle.Fill;
            cbRace.FormattingEnabled = true;
            cbRace.Location = new Point(175, 3);
            cbRace.Name = "cbRace";
            cbRace.Size = new Size(166, 23);
            cbRace.TabIndex = 4;
            cbRace.ValueMember = "Id";
            cbRace.SelectedIndexChanged += cbRace_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Fill;
            btnOk.Location = new Point(3, 253);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(344, 24);
            btnOk.TabIndex = 0;
            btnOk.Text = "Zatwierdź";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // nudAge
            // 
            nudAge.Dock = DockStyle.Fill;
            nudAge.Location = new Point(175, 50);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(166, 23);
            nudAge.TabIndex = 2;
            // 
            // btnCancle
            // 
            btnCancle.Dock = DockStyle.Fill;
            btnCancle.Location = new Point(353, 253);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(345, 24);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "Anuluj";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // pb1
            // 
            pb1.Dock = DockStyle.Fill;
            pb1.Location = new Point(353, 3);
            pb1.Name = "pb1";
            pb1.Size = new Size(345, 24);
            pb1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(pb1, 1, 0);
            tableLayoutPanel1.Controls.Add(pb2, 1, 1);
            tableLayoutPanel1.Controls.Add(pb3, 1, 2);
            tableLayoutPanel1.Controls.Add(pb4, 1, 3);
            tableLayoutPanel1.Controls.Add(pb5, 1, 4);
            tableLayoutPanel1.Controls.Add(btnCancle, 1, 6);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(tbDescription, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(701, 293);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 120);
            label7.Name = "label7";
            label7.Size = new Size(344, 30);
            label7.TabIndex = 17;
            label7.Text = "Liczność";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(344, 30);
            label6.TabIndex = 16;
            label6.Text = "Higieniczność";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 60);
            label5.Name = "label5";
            label5.Size = new Size(344, 30);
            label5.TabIndex = 15;
            label5.Text = "Miodność";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(344, 30);
            label4.TabIndex = 14;
            label4.Text = "Łagodność";
            // 
            // pb2
            // 
            pb2.Dock = DockStyle.Fill;
            pb2.Location = new Point(353, 33);
            pb2.Name = "pb2";
            pb2.Size = new Size(345, 24);
            pb2.TabIndex = 7;
            // 
            // pb3
            // 
            pb3.Dock = DockStyle.Fill;
            pb3.Location = new Point(353, 63);
            pb3.Name = "pb3";
            pb3.Size = new Size(345, 24);
            pb3.TabIndex = 8;
            // 
            // pb4
            // 
            pb4.Dock = DockStyle.Fill;
            pb4.Location = new Point(353, 93);
            pb4.Name = "pb4";
            pb4.Size = new Size(345, 24);
            pb4.TabIndex = 9;
            // 
            // pb5
            // 
            pb5.Dock = DockStyle.Fill;
            pb5.Location = new Point(353, 123);
            pb5.Name = "pb5";
            pb5.Size = new Size(345, 24);
            pb5.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(nudAge, 1, 1);
            tableLayoutPanel2.Controls.Add(cbRace, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(344, 94);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 47);
            label1.TabIndex = 5;
            label1.Text = "Rasa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(166, 47);
            label2.TabIndex = 6;
            label2.Text = "Aktualny Wiek";
            // 
            // tbDescription
            // 
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Location = new Point(353, 153);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(345, 94);
            tbDescription.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 30);
            label3.TabIndex = 13;
            label3.Text = "Rojliwość";
            // 
            // ChagneQueen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 293);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ChagneQueen";
            Text = "Wymiana";
            Load += ChagneQueen_Load;
            ((System.ComponentModel.ISupportInitialize)rasaModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource rasaModelBindingSource;
        private ComboBox cbRace;
        private Button btnOk;
        private NumericUpDown nudAge;
        private Button btnCancle;
        private ProgressBar pb1;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar pb2;
        private ProgressBar pb3;
        private ProgressBar pb4;
        private ProgressBar pb5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private TextBox tbDescription;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}