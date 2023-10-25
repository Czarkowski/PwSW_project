using PasiekaMainProject.Helpers;

namespace PasiekaMainProject
{
    partial class NewHive
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            nudNr = new NumericUpDown();
            btnOK = new Button();
            btnCancle = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNr).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(nudNr, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOK, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancle, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(389, 104);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 0;
            label1.Text = "Numer:";
            // 
            // nudNr
            // 
            nudNr.Dock = DockStyle.Fill;
            nudNr.Location = new Point(197, 3);
            nudNr.Name = "nudNr";
            nudNr.Size = new Size(189, 23);
            nudNr.TabIndex = 1;
            nudNr.ValueChanged += nudNr_ValueChanged;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Location = new Point(3, 33);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(188, 68);
            btnOK.TabIndex = 2;
            btnOK.Text = "Utwórz";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancle
            // 
            btnCancle.Dock = DockStyle.Fill;
            btnCancle.Location = new Point(197, 33);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(189, 68);
            btnCancle.TabIndex = 3;
            btnCancle.Text = "Anuluj";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(389, 102);
            label2.TabIndex = 1;
            label2.Text = "Utwórz Nowy Ul";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewHive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 206);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Name = "NewHive";
            Text = "NewHive";
            Load += NewHive_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private NumericUpDown nudNr;
        private Button btnOK;
        private Button btnCancle;
        private Label label2;
    }
}