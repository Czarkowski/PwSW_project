namespace PasiekaMainProject
{
    partial class Pasieka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnRemove = new Button();
            btnShow = new Button();
            btnPrzeglady = new Button();
            panelMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMain = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(593, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(289, 85);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Location = new Point(888, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(290, 85);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnShow
            // 
            btnShow.Dock = DockStyle.Fill;
            btnShow.Location = new Point(3, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(289, 85);
            btnShow.TabIndex = 2;
            btnShow.Text = "Pokaż Stan Pasieki";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnPrzeglady
            // 
            btnPrzeglady.Dock = DockStyle.Fill;
            btnPrzeglady.Location = new Point(298, 3);
            btnPrzeglady.Name = "btnPrzeglady";
            btnPrzeglady.Size = new Size(289, 85);
            btnPrzeglady.TabIndex = 3;
            btnPrzeglady.Text = "Zarządzaj Przeglądami";
            btnPrzeglady.UseVisualStyleBackColor = true;
            btnPrzeglady.Click += btnPrzeglady_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 203);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1187, 564);
            panelMain.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblMain, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.MinimumSize = new Size(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1187, 194);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Dock = DockStyle.Fill;
            lblMain.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMain.Location = new Point(3, 97);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(1181, 97);
            lblMain.TabIndex = 1;
            lblMain.Text = "_";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnShow, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPrzeglady, 1, 0);
            tableLayoutPanel2.Controls.Add(btnRemove, 3, 0);
            tableLayoutPanel2.Controls.Add(btnAdd, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1181, 91);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panelMain, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1193, 706);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // Pasieka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 706);
            Controls.Add(tableLayoutPanel3);
            Name = "Pasieka";
            Text = "Pasieka";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Button btnShow;
        private Button btnPrzeglady;
        private Panel panelMain;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMain;
        private TableLayoutPanel tableLayoutPanel3;
    }
}