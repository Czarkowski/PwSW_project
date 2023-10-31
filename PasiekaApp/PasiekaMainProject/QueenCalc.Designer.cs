namespace PasiekaMainProject
{
    partial class QueenCalc
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
            lvMain = new ListView();
            SuspendLayout();
            // 
            // lvMain
            // 
            lvMain.Dock = DockStyle.Fill;
            lvMain.Location = new Point(0, 0);
            lvMain.Name = "lvMain";
            lvMain.Size = new Size(357, 213);
            lvMain.TabIndex = 0;
            lvMain.UseCompatibleStateImageBehavior = false;
            // 
            // QueenCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lvMain);
            Name = "QueenCalc";
            Size = new Size(357, 213);
            Load += QueenCalc_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMain;
    }
}
