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
            this.buttonCopy = new System.Windows.Forms.Button();
            this.tcPanelRight = new miniTC.TCPanel();
            this.tcPanelLeft = new miniTC.TCPanel();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(519, 150);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 35);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Copy->";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // tcPanelRight
            // 
            this.tcPanelRight.AutoScroll = true;
            this.tcPanelRight.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tcPanelRight.CurrentPath = " ";
            this.tcPanelRight.Location = new System.Drawing.Point(602, 1);
            this.tcPanelRight.Margin = new System.Windows.Forms.Padding(5);
            this.tcPanelRight.Name = "tcPanelRight";
            this.tcPanelRight.Size = new System.Drawing.Size(507, 559);
            this.tcPanelRight.TabIndex = 1;
            // 
            // tcPanelLeft
            // 
            this.tcPanelLeft.AutoScroll = true;
            this.tcPanelLeft.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tcPanelLeft.CurrentPath = " ";
            this.tcPanelLeft.Location = new System.Drawing.Point(14, 1);
            this.tcPanelLeft.Margin = new System.Windows.Forms.Padding(5);
            this.tcPanelLeft.Name = "tcPanelLeft";
            this.tcPanelLeft.Size = new System.Drawing.Size(507, 559);
            this.tcPanelLeft.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 565);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tcPanelRight);
            this.Controls.Add(this.tcPanelLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TCPanel tcPanelLeft;
        private TCPanel tcPanelRight;
        private System.Windows.Forms.Button buttonCopy;
    }
}

