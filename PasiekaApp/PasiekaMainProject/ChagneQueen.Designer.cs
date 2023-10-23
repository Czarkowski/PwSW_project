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
            btnOk = new Button();
            btnCancle = new Button();
            nudAge = new NumericUpDown();
            cbRace = new ComboBox();
            rasaModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rasaModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(221, 356);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Zatwierdź";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(483, 340);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 23);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "Anuluj";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(502, 207);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 23);
            nudAge.TabIndex = 2;
            // 
            // cbRace
            // 
            cbRace.DataSource = rasaModelBindingSource;
            cbRace.DisplayMember = "Nazwa";
            cbRace.FormattingEnabled = true;
            cbRace.Location = new Point(175, 206);
            cbRace.Name = "cbRace";
            cbRace.Size = new Size(121, 23);
            cbRace.TabIndex = 4;
            cbRace.ValueMember = "Id";
            // 
            // rasaModelBindingSource
            // 
            rasaModelBindingSource.DataSource = typeof(Model.RasaModel);
            // 
            // ChagneQueen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbRace);
            Controls.Add(nudAge);
            Controls.Add(btnCancle);
            Controls.Add(btnOk);
            Name = "ChagneQueen";
            Text = "Wymiana";
            Load += ChagneQueen_Load;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)rasaModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOk;
        private Button btnCancle;
        private NumericUpDown nudAge;
        private ComboBox cbRace;
        private BindingSource rasaModelBindingSource;
    }
}