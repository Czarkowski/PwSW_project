namespace PasiekaMainProject
{
    partial class SugarCalc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbIn = new TextBox();
            tbOutWater = new TextBox();
            tbOutSugar = new TextBox();
            tbOutSyurp = new TextBox();
            cbElementType = new ComboBox();
            cbSyurpType = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbOutCitricAcid = new TextBox();
            tbOutProbio = new TextBox();
            chbPerHive = new CheckBox();
            tbMultiply = new TrackBar();
            lblTrB = new Label();
            tpPerHive = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbMultiply).BeginInit();
            SuspendLayout();
            // 
            // tbIn
            // 
            tbIn.Dock = DockStyle.Fill;
            tbIn.Location = new Point(130, 54);
            tbIn.Name = "tbIn";
            tbIn.Size = new Size(144, 23);
            tbIn.TabIndex = 0;
            tpPerHive.SetToolTip(tbIn, "[kg / L]");
            tbIn.KeyPress += tbIn_KeyPress;
            tbIn.Leave += tbIn_Leave;
            // 
            // tbOutWater
            // 
            tbOutWater.Dock = DockStyle.Fill;
            tbOutWater.Enabled = false;
            tbOutWater.Location = new Point(130, 98);
            tbOutWater.Name = "tbOutWater";
            tbOutWater.Size = new Size(144, 23);
            tbOutWater.TabIndex = 1;
            // 
            // tbOutSugar
            // 
            tbOutSugar.Dock = DockStyle.Fill;
            tbOutSugar.Enabled = false;
            tbOutSugar.Location = new Point(3, 98);
            tbOutSugar.Name = "tbOutSugar";
            tbOutSugar.Size = new Size(121, 23);
            tbOutSugar.TabIndex = 2;
            // 
            // tbOutSyurp
            // 
            tbOutSyurp.Dock = DockStyle.Fill;
            tbOutSyurp.Enabled = false;
            tbOutSyurp.Location = new Point(280, 98);
            tbOutSyurp.Name = "tbOutSyurp";
            tbOutSyurp.Size = new Size(152, 23);
            tbOutSyurp.TabIndex = 3;
            // 
            // cbElementType
            // 
            cbElementType.Dock = DockStyle.Fill;
            cbElementType.FormattingEnabled = true;
            cbElementType.Location = new Point(3, 54);
            cbElementType.Name = "cbElementType";
            cbElementType.Size = new Size(121, 23);
            cbElementType.TabIndex = 4;
            cbElementType.SelectedIndexChanged += cbElementType_SelectedIndexChanged;
            // 
            // cbSyurpType
            // 
            cbSyurpType.Dock = DockStyle.Fill;
            cbSyurpType.FormattingEnabled = true;
            cbSyurpType.Location = new Point(280, 54);
            cbSyurpType.Name = "cbSyurpType";
            cbSyurpType.Size = new Size(152, 23);
            cbSyurpType.TabIndex = 5;
            cbSyurpType.SelectedIndexChanged += cbSyurpType_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label3, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(cbElementType, 0, 1);
            tableLayoutPanel1.Controls.Add(tbOutSugar, 0, 3);
            tableLayoutPanel1.Controls.Add(tbOutSyurp, 2, 3);
            tableLayoutPanel1.Controls.Add(cbSyurpType, 2, 1);
            tableLayoutPanel1.Controls.Add(tbIn, 1, 1);
            tableLayoutPanel1.Controls.Add(tbOutWater, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 2, 4);
            tableLayoutPanel1.Controls.Add(tbOutCitricAcid, 1, 5);
            tableLayoutPanel1.Controls.Add(tbOutProbio, 2, 5);
            tableLayoutPanel1.Controls.Add(chbPerHive, 0, 0);
            tableLayoutPanel1.Controls.Add(tbMultiply, 2, 0);
            tableLayoutPanel1.Controls.Add(lblTrB, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(445, 179);
            tableLayoutPanel1.TabIndex = 6;
            tpPerHive.SetToolTip(tableLayoutPanel1, "Jeżeli wybrane: żądana wartość będzie pomnożona przez ilość uli,\r\nz uwzględnieniem mnożnika dla odkładów");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(280, 80);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 8;
            label3.Text = "Syrop[L]:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(130, 80);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 7;
            label2.Text = "Woda[L]:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 80);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 6;
            label1.Text = "Cukier[kg]:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 9;
            label4.Text = "Dodatki:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(130, 124);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 10;
            label5.Text = "Kwasek Cytrynowy[g]:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 124);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 11;
            label6.Text = "Probiotyk[ml]:";
            // 
            // tbOutCitricAcid
            // 
            tbOutCitricAcid.Dock = DockStyle.Fill;
            tbOutCitricAcid.Enabled = false;
            tbOutCitricAcid.Location = new Point(130, 142);
            tbOutCitricAcid.Name = "tbOutCitricAcid";
            tbOutCitricAcid.Size = new Size(144, 23);
            tbOutCitricAcid.TabIndex = 12;
            // 
            // tbOutProbio
            // 
            tbOutProbio.Dock = DockStyle.Fill;
            tbOutProbio.Enabled = false;
            tbOutProbio.Location = new Point(280, 142);
            tbOutProbio.Name = "tbOutProbio";
            tbOutProbio.Size = new Size(152, 23);
            tbOutProbio.TabIndex = 13;
            // 
            // chbPerHive
            // 
            chbPerHive.AutoSize = true;
            chbPerHive.Dock = DockStyle.Fill;
            chbPerHive.Location = new Point(3, 3);
            chbPerHive.Name = "chbPerHive";
            chbPerHive.Size = new Size(121, 45);
            chbPerHive.TabIndex = 14;
            chbPerHive.Text = "Per Ul";
            chbPerHive.TextAlign = ContentAlignment.MiddleCenter;
            tpPerHive.SetToolTip(chbPerHive, "Jeżeli wybrane: podana wartoś jest mnożona przez liczbe uli,\r\nz uwzględnieniem odkładów i mnożnika dla nich\r\n");
            chbPerHive.UseVisualStyleBackColor = true;
            chbPerHive.CheckedChanged += chbPerHive_CheckedChanged;
            // 
            // tbMultiply
            // 
            tbMultiply.Dock = DockStyle.Fill;
            tbMultiply.LargeChange = 1;
            tbMultiply.Location = new Point(280, 3);
            tbMultiply.Name = "tbMultiply";
            tbMultiply.Size = new Size(152, 45);
            tbMultiply.TabIndex = 15;
            tbMultiply.Value = 1;
            tbMultiply.ValueChanged += tbMultiply_ValueChanged;
            // 
            // lblTrB
            // 
            lblTrB.AutoSize = true;
            lblTrB.Dock = DockStyle.Fill;
            lblTrB.Location = new Point(130, 0);
            lblTrB.Name = "lblTrB";
            lblTrB.Size = new Size(144, 51);
            lblTrB.TabIndex = 16;
            lblTrB.Text = "Mnożnik dla odkładu (0.0)";
            lblTrB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SugarCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "SugarCalc";
            Size = new Size(445, 179);
            Load += SugarCalc_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbMultiply).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbIn;
        private TextBox tbOutWater;
        private TextBox tbOutSugar;
        private TextBox tbOutSyurp;
        private ComboBox cbElementType;
        private ComboBox cbSyurpType;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbOutCitricAcid;
        private TextBox tbOutProbio;
        private CheckBox chbPerHive;
        private TrackBar tbMultiply;
        private Label lblTrB;
        private ToolTip tpPerHive;
    }
}
