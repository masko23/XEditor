namespace XEditor
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
            this.stationsTree = new System.Windows.Forms.TreeView();
            this.scheduleTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // stationsTree
            // 
            this.stationsTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.stationsTree.Location = new System.Drawing.Point(0, 0);
            this.stationsTree.Name = "stationsTree";
            this.stationsTree.Size = new System.Drawing.Size(355, 511);
            this.stationsTree.TabIndex = 0;
            this.stationsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.stationsTree_AfterSelect);
            // 
            // scheduleTree
            // 
            this.scheduleTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleTree.Location = new System.Drawing.Point(355, 0);
            this.scheduleTree.Name = "scheduleTree";
            this.scheduleTree.Size = new System.Drawing.Size(355, 511);
            this.scheduleTree.TabIndex = 1;
            this.scheduleTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.scheduleTree_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 511);
            this.Controls.Add(this.scheduleTree);
            this.Controls.Add(this.stationsTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView stationsTree;
        private System.Windows.Forms.TreeView scheduleTree;
    }
}

