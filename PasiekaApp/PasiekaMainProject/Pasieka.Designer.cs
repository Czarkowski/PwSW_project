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
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(484, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(596, 50);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(33, 50);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(152, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Pokaż Stan Pasieki";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnPrzeglady
            // 
            btnPrzeglady.Location = new Point(222, 51);
            btnPrzeglady.Name = "btnPrzeglady";
            btnPrzeglady.Size = new Size(173, 23);
            btnPrzeglady.TabIndex = 3;
            btnPrzeglady.Text = "Zarządzaj Przeglądami";
            btnPrzeglady.UseVisualStyleBackColor = true;
            btnPrzeglady.Click += btnPrzeglady_Click;
            // 
            // Pasieka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrzeglady);
            Controls.Add(btnShow);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "Pasieka";
            Text = "Pasieka";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Button btnShow;
        private Button btnPrzeglady;
    }
}