namespace miniTC
{
    partial class Form1
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
            this.tcPanelRight = new miniTC.TCPanel();
            this.tcPanelLeft = new miniTC.TCPanel();
            this.SuspendLayout();
            // 
            // tcPanelRight
            // 
            this.tcPanelRight.Location = new System.Drawing.Point(355, 2);
            this.tcPanelRight.Name = "tcPanelRight";
            this.tcPanelRight.CurrentPath = " ";
            this.tcPanelRight.Size = new System.Drawing.Size(338, 454);
            this.tcPanelRight.TabIndex = 1;
            // 
            // tcPanelLeft
            // 
            this.tcPanelLeft.Location = new System.Drawing.Point(2, 2);
            this.tcPanelLeft.Name = "tcPanelLeft";
            this.tcPanelLeft.CurrentPath = " ";
            this.tcPanelLeft.Size = new System.Drawing.Size(338, 454);
            this.tcPanelLeft.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 459);
            this.Controls.Add(this.tcPanelRight);
            this.Controls.Add(this.tcPanelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TCPanel tcPanelLeft;
        private TCPanel tcPanelRight;
    }
}

