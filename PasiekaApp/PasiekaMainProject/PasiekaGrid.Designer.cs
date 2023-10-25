namespace PasiekaMainProject
{
    partial class PasiekaGrid
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
            dataGridView = new DataGridView();
            numerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rasaNazwaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ulModelBindingSource = new BindingSource(components);
            btnNewUl = new Button();
            btnUpdateUl = new Button();
            btnRemoveUl = new Button();
            rtbState = new RichTextBox();
            rtbFuture = new RichTextBox();
            btnUnlock = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNr = new Label();
            label4 = new Label();
            clbStan = new CheckedListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            rtbFrame = new RichTextBox();
            label10 = new Label();
            nudGniazdo = new NumericUpDown();
            nudNadStawka = new NumericUpDown();
            dtpPrzeglad = new DateTimePicker();
            lblWiekMatki = new Label();
            btnChangeQueen = new Button();
            lblRaceName = new Label();
            label11 = new Label();
            dtpQueenAge = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ulModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGniazdo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNadStawka).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { numerDataGridViewTextBoxColumn, rasaNazwaDataGridViewTextBoxColumn, dataOstatniegoPrzegladuDataGridViewTextBoxColumn });
            dataGridView.DataSource = ulModelBindingSource;
            dataGridView.Location = new Point(12, 151);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(344, 287);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellDoubleClick += dataGridView_CellContentClick;
            // 
            // numerDataGridViewTextBoxColumn
            // 
            numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            numerDataGridViewTextBoxColumn.ReadOnly = true;
            numerDataGridViewTextBoxColumn.Width = 50;
            // 
            // rasaNazwaDataGridViewTextBoxColumn
            // 
            rasaNazwaDataGridViewTextBoxColumn.DataPropertyName = "RasaNazwa";
            rasaNazwaDataGridViewTextBoxColumn.HeaderText = "RasaNazwa";
            rasaNazwaDataGridViewTextBoxColumn.Name = "rasaNazwaDataGridViewTextBoxColumn";
            rasaNazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataOstatniegoPrzegladuDataGridViewTextBoxColumn
            // 
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn.DataPropertyName = "DataOstatniegoPrzegladu";
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn.HeaderText = "DataOstatniegoPrzegladu";
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn.Name = "dataOstatniegoPrzegladuDataGridViewTextBoxColumn";
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn.ReadOnly = true;
            dataOstatniegoPrzegladuDataGridViewTextBoxColumn.Width = 150;
            // 
            // ulModelBindingSource
            // 
            ulModelBindingSource.DataSource = typeof(Model.UlModel);
            // 
            // btnNewUl
            // 
            btnNewUl.Location = new Point(12, 110);
            btnNewUl.Name = "btnNewUl";
            btnNewUl.Size = new Size(75, 23);
            btnNewUl.TabIndex = 1;
            btnNewUl.Text = "Nowy";
            btnNewUl.UseVisualStyleBackColor = true;
            btnNewUl.Click += btnNewUl_Click;
            // 
            // btnUpdateUl
            // 
            btnUpdateUl.Location = new Point(1037, 628);
            btnUpdateUl.Name = "btnUpdateUl";
            btnUpdateUl.Size = new Size(75, 23);
            btnUpdateUl.TabIndex = 2;
            btnUpdateUl.Text = "Modyfikuj";
            btnUpdateUl.UseVisualStyleBackColor = true;
            btnUpdateUl.Click += btnUpdateUl_Click;
            // 
            // btnRemoveUl
            // 
            btnRemoveUl.Location = new Point(199, 110);
            btnRemoveUl.Name = "btnRemoveUl";
            btnRemoveUl.Size = new Size(75, 23);
            btnRemoveUl.TabIndex = 3;
            btnRemoveUl.Text = "Usuń";
            btnRemoveUl.UseVisualStyleBackColor = true;
            btnRemoveUl.Click += btnRemoveUl_Click;
            // 
            // rtbState
            // 
            rtbState.Location = new Point(448, 192);
            rtbState.Name = "rtbState";
            rtbState.Size = new Size(317, 96);
            rtbState.TabIndex = 5;
            rtbState.Text = "";
            // 
            // rtbFuture
            // 
            rtbFuture.Location = new Point(448, 294);
            rtbFuture.Name = "rtbFuture";
            rtbFuture.Size = new Size(317, 96);
            rtbFuture.TabIndex = 6;
            rtbFuture.Text = "";
            // 
            // btnUnlock
            // 
            btnUnlock.Location = new Point(448, 504);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(75, 23);
            btnUnlock.TabIndex = 7;
            btnUnlock.Text = "Odblokuj";
            btnUnlock.UseVisualStyleBackColor = true;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(620, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Location = new Point(362, 297);
            label1.Name = "label1";
            label1.Size = new Size(80, 57);
            label1.TabIndex = 9;
            label1.Text = "Zaplanowane czynności";
            // 
            // label2
            // 
            label2.Location = new Point(373, 192);
            label2.Name = "label2";
            label2.Size = new Size(63, 52);
            label2.TabIndex = 10;
            label2.Text = "Aktualny Opis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 151);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "Numer:";
            // 
            // lblNr
            // 
            lblNr.AutoSize = true;
            lblNr.Location = new Point(426, 151);
            lblNr.Name = "lblNr";
            lblNr.Size = new Size(12, 15);
            lblNr.TabIndex = 12;
            lblNr.Text = "_";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 151);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "Rasa:";
            // 
            // clbStan
            // 
            clbStan.FormattingEnabled = true;
            clbStan.Items.AddRange(new object[] { "Odkład ", "Nowa Matka", "Wyrojone" });
            clbStan.Location = new Point(783, 434);
            clbStan.Name = "clbStan";
            clbStan.Size = new Size(120, 58);
            clbStan.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(783, 396);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 15;
            label5.Text = "Stan:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 195);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 16;
            label6.Text = "Data Przeglądu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(616, 151);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 17;
            label7.Text = "Wiek Matki:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(783, 294);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 18;
            label8.Text = "Ramki Gniazdo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(783, 349);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 19;
            label9.Text = "Ramki Nad Stawka";
            // 
            // rtbFrame
            // 
            rtbFrame.Location = new Point(448, 396);
            rtbFrame.Name = "rtbFrame";
            rtbFrame.Size = new Size(317, 96);
            rtbFrame.TabIndex = 20;
            rtbFrame.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(373, 399);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 21;
            label10.Text = "Opis Ramek";
            // 
            // nudGniazdo
            // 
            nudGniazdo.Location = new Point(783, 313);
            nudGniazdo.Name = "nudGniazdo";
            nudGniazdo.Size = new Size(120, 23);
            nudGniazdo.TabIndex = 22;
            // 
            // nudNadStawka
            // 
            nudNadStawka.Location = new Point(783, 367);
            nudNadStawka.Name = "nudNadStawka";
            nudNadStawka.Size = new Size(120, 23);
            nudNadStawka.TabIndex = 23;
            // 
            // dtpPrzeglad
            // 
            dtpPrzeglad.Checked = false;
            dtpPrzeglad.Enabled = false;
            dtpPrzeglad.Format = DateTimePickerFormat.Short;
            dtpPrzeglad.Location = new Point(783, 221);
            dtpPrzeglad.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpPrzeglad.Name = "dtpPrzeglad";
            dtpPrzeglad.Size = new Size(120, 23);
            dtpPrzeglad.TabIndex = 24;
            dtpPrzeglad.TabStop = false;
            dtpPrzeglad.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblWiekMatki
            // 
            lblWiekMatki.AutoSize = true;
            lblWiekMatki.Location = new Point(691, 151);
            lblWiekMatki.Name = "lblWiekMatki";
            lblWiekMatki.Size = new Size(12, 15);
            lblWiekMatki.TabIndex = 25;
            lblWiekMatki.Text = "_";
            // 
            // btnChangeQueen
            // 
            btnChangeQueen.Enabled = false;
            btnChangeQueen.Location = new Point(448, 110);
            btnChangeQueen.Name = "btnChangeQueen";
            btnChangeQueen.Size = new Size(317, 23);
            btnChangeQueen.TabIndex = 26;
            btnChangeQueen.Text = "Wymiana Matki Pszczelej";
            btnChangeQueen.UseVisualStyleBackColor = true;
            btnChangeQueen.Click += btnChangeQueen_Click;
            // 
            // lblRaceName
            // 
            lblRaceName.AutoSize = true;
            lblRaceName.Location = new Point(522, 151);
            lblRaceName.Name = "lblRaceName";
            lblRaceName.Size = new Size(12, 15);
            lblRaceName.TabIndex = 27;
            lblRaceName.Text = "_";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(783, 247);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 28;
            label11.Text = "Data Poddania Matki:";
            // 
            // dtpQueenAge
            // 
            dtpQueenAge.Checked = false;
            dtpQueenAge.Enabled = false;
            dtpQueenAge.Format = DateTimePickerFormat.Short;
            dtpQueenAge.Location = new Point(782, 265);
            dtpQueenAge.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpQueenAge.Name = "dtpQueenAge";
            dtpQueenAge.Size = new Size(121, 23);
            dtpQueenAge.TabIndex = 29;
            dtpQueenAge.TabStop = false;
            dtpQueenAge.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // PasiekaGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 681);
            Controls.Add(dtpQueenAge);
            Controls.Add(label11);
            Controls.Add(lblRaceName);
            Controls.Add(btnChangeQueen);
            Controls.Add(lblWiekMatki);
            Controls.Add(dtpPrzeglad);
            Controls.Add(nudNadStawka);
            Controls.Add(nudGniazdo);
            Controls.Add(label10);
            Controls.Add(rtbFrame);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clbStan);
            Controls.Add(label4);
            Controls.Add(lblNr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnUnlock);
            Controls.Add(rtbFuture);
            Controls.Add(rtbState);
            Controls.Add(btnRemoveUl);
            Controls.Add(btnUpdateUl);
            Controls.Add(btnNewUl);
            Controls.Add(dataGridView);
            Name = "PasiekaGrid";
            Text = "PasiekaStan";
            Load += PasiekaGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ulModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGniazdo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNadStawka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private BindingSource ulModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rasaNazwaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataOstatniegoPrzegladuDataGridViewTextBoxColumn;
        private Button btnNewUl;
        private Button btnUpdateUl;
        private Button btnRemoveUl;
        private RichTextBox rtbState;
        private RichTextBox rtbFuture;
        private Button btnUnlock;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNr;
        private Label label4;
        private CheckedListBox clbStan;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private RichTextBox rtbFrame;
        private Label label10;
        private NumericUpDown nudGniazdo;
        private NumericUpDown nudNadStawka;
        private DateTimePicker dtpPrzeglad;
        private Label lblWiekMatki;
        private Button btnChangeQueen;
        private Label lblRaceName;
        private Label label11;
        private DateTimePicker dtpQueenAge;
    }
}