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
            celDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsComplete = new DataGridViewTextBoxColumn();
            dataZaPlanowanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            przegladModelBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            btnNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrzeglad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)przegladModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPrzeglad
            // 
            dgvPrzeglad.AutoGenerateColumns = false;
            dgvPrzeglad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrzeglad.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, celDataGridViewTextBoxColumn, IsComplete, dataZaPlanowanaDataGridViewTextBoxColumn });
            dgvPrzeglad.DataSource = przegladModelBindingSource;
            dgvPrzeglad.Location = new Point(12, 108);
            dgvPrzeglad.Name = "dgvPrzeglad";
            dgvPrzeglad.RowTemplate.Height = 25;
            dgvPrzeglad.Size = new Size(495, 150);
            dgvPrzeglad.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn
            // 
            celDataGridViewTextBoxColumn.DataPropertyName = "Cel";
            celDataGridViewTextBoxColumn.HeaderText = "Cel";
            celDataGridViewTextBoxColumn.Name = "celDataGridViewTextBoxColumn";
            // 
            // IsComplete
            // 
            IsComplete.HeaderText = "Wykonany";
            IsComplete.Name = "IsComplete";
            // 
            // dataZaPlanowanaDataGridViewTextBoxColumn
            // 
            dataZaPlanowanaDataGridViewTextBoxColumn.DataPropertyName = "DataZaPlanowana";
            dataZaPlanowanaDataGridViewTextBoxColumn.HeaderText = "DataZaPlanowana";
            dataZaPlanowanaDataGridViewTextBoxColumn.Name = "dataZaPlanowanaDataGridViewTextBoxColumn";
            dataZaPlanowanaDataGridViewTextBoxColumn.Width = 150;
            // 
            // przegladModelBindingSource
            // 
            przegladModelBindingSource.DataSource = typeof(Model.PrzegladModel);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 282);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 126);
            textBox1.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(22, 65);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(153, 23);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nowy Przegląd";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // PasiekaOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 564);
            Controls.Add(btnNew);
            Controls.Add(textBox1);
            Controls.Add(dgvPrzeglad);
            Name = "PasiekaOverview";
            Text = "PasiekaOverview";
            Load += PasiekaOverview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrzeglad).EndInit();
            ((System.ComponentModel.ISupportInitialize)przegladModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrzeglad;
        private BindingSource przegladModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IsComplete;
        private DataGridViewTextBoxColumn dataZaPlanowanaDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private Button btnNew;
    }
}