namespace XEditor
{
    partial class xLogger
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
            xLogger.logBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logBox
            // 
            xLogger.logBox.Location = new System.Drawing.Point(13, 13);
            xLogger.logBox.Multiline = true;
            xLogger.logBox.Name = "logBox";
            xLogger.logBox.Size = new System.Drawing.Size(523, 453);
            xLogger.logBox.TabIndex = 0;
            xLogger.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            xLogger.logBox.ReadOnly = true;
            xLogger.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            // 
            // xLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 478);
            this.Controls.Add(xLogger.logBox);
            this.Name = "xLogger";
            this.Text = "xLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.TextBox logBox;
    }
}