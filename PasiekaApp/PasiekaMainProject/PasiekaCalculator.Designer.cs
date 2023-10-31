namespace PasiekaMainProject
{
    partial class PasiekaCalculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbCalcType = new ComboBox();
            chbAllHive = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            nudHalf = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            nudHive = new NumericUpDown();
            panelCalc = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHalf).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHive).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panelCalc, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1047, 129);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(cbCalcType, 0, 1);
            tableLayoutPanel2.Controls.Add(chbAllHive, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 2, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1041, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbCalcType
            // 
            cbCalcType.Dock = DockStyle.Fill;
            cbCalcType.FormattingEnabled = true;
            cbCalcType.Location = new Point(3, 53);
            cbCalcType.Name = "cbCalcType";
            cbCalcType.Size = new Size(410, 23);
            cbCalcType.TabIndex = 0;
            cbCalcType.SelectedIndexChanged += cbCalcType_SelectedIndexChanged;
            // 
            // chbAllHive
            // 
            chbAllHive.AutoSize = true;
            chbAllHive.Dock = DockStyle.Fill;
            chbAllHive.Location = new Point(731, 3);
            chbAllHive.Name = "chbAllHive";
            chbAllHive.Size = new Size(307, 44);
            chbAllHive.TabIndex = 2;
            chbAllHive.TextAlign = ContentAlignment.MiddleCenter;
            chbAllHive.UseVisualStyleBackColor = true;
            chbAllHive.CheckedChanged += chbAllHive_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(nudHalf, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(731, 53);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(307, 38);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 38);
            label4.TabIndex = 5;
            label4.Text = "Odkłady";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // nudHalf
            // 
            nudHalf.Dock = DockStyle.Fill;
            nudHalf.Location = new Point(156, 3);
            nudHalf.Name = "nudHalf";
            nudHalf.Size = new Size(148, 23);
            nudHalf.TabIndex = 6;
            nudHalf.ValueChanged += nudHalf_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 1;
            label1.Text = "Rodzaj Kalkulatora:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(419, 0);
            label2.Name = "label2";
            label2.Size = new Size(306, 50);
            label2.TabIndex = 3;
            label2.Text = "Dla całej pasieki?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(nudHive, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(419, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(306, 38);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 4;
            label3.Text = "Pełne";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // nudHive
            // 
            nudHive.Dock = DockStyle.Fill;
            nudHive.Location = new Point(156, 3);
            nudHive.Name = "nudHive";
            nudHive.Size = new Size(147, 23);
            nudHive.TabIndex = 5;
            nudHive.ValueChanged += nudHive_ValueChanged;
            // 
            // panelCalc
            // 
            panelCalc.AutoSize = true;
            panelCalc.Dock = DockStyle.Fill;
            panelCalc.Location = new Point(3, 103);
            panelCalc.Name = "panelCalc";
            panelCalc.Size = new Size(1041, 23);
            panelCalc.TabIndex = 1;
            // 
            // PasiekaCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "PasiekaCalculator";
            Size = new Size(1047, 129);
            Load += PasiekaCalculator_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHalf).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbCalcType;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private NumericUpDown nudHalf;
        private CheckBox chbAllHive;
        private NumericUpDown nudHive;
        private Panel panelCalc;
    }
}
