namespace PasiekaMainProject
{
    partial class PasiekaMap
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
            panelMain = new Panel();
            panelPasiekaGrid = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdd = new Button();
            btnRemove = new Button();
            btnMove = new Button();
            cbColor = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelMain, 0, 0);
            tableLayoutPanel1.Controls.Add(panelPasiekaGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(863, 615);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(857, 494);
            panelMain.TabIndex = 0;
            // 
            // panelPasiekaGrid
            // 
            panelPasiekaGrid.AutoSize = true;
            panelPasiekaGrid.Dock = DockStyle.Fill;
            panelPasiekaGrid.Location = new Point(3, 553);
            panelPasiekaGrid.Name = "panelPasiekaGrid";
            panelPasiekaGrid.Size = new Size(857, 59);
            panelPasiekaGrid.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(btnRemove, 1, 0);
            tableLayoutPanel2.Controls.Add(btnMove, 2, 0);
            tableLayoutPanel2.Controls.Add(cbColor, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 503);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(857, 44);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(208, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.Enabled = false;
            btnRemove.Location = new Point(217, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(208, 38);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnMove
            // 
            btnMove.Dock = DockStyle.Fill;
            btnMove.Enabled = false;
            btnMove.Location = new Point(431, 3);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(208, 38);
            btnMove.TabIndex = 2;
            btnMove.Text = "Przesuń";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // cbColor
            // 
            cbColor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbColor.Enabled = false;
            cbColor.Location = new Point(645, 10);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(209, 23);
            cbColor.TabIndex = 3;
            cbColor.SelectedIndexChanged += cbColor_SelectedIndexChanged;
            // 
            // PasiekaMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "PasiekaMap";
            Size = new Size(863, 615);
            Load += PasiekaMap_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelMain;
        private Panel panelPasiekaGrid;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnMove;
        private ComboBox cbColor;
    }
}
