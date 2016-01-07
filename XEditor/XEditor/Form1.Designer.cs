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
            this.butNew = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // stationsTree
            // 
            this.stationsTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.stationsTree.Location = new System.Drawing.Point(0, 0);
            this.stationsTree.Name = "stationsTree";
            this.stationsTree.Size = new System.Drawing.Size(355, 523);
            this.stationsTree.TabIndex = 0;
            this.stationsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.stationsTree_AfterSelect);
            // 
            // scheduleTree
            // 
            this.scheduleTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleTree.Location = new System.Drawing.Point(355, 0);
            this.scheduleTree.Name = "scheduleTree";
            this.scheduleTree.Size = new System.Drawing.Size(355, 523);
            this.scheduleTree.TabIndex = 1;
            this.scheduleTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.scheduleTree_AfterSelect);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(3, 3);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(75, 23);
            this.butNew.TabIndex = 2;
            this.butNew.Text = "New";
            this.butNew.UseVisualStyleBackColor = true;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(3, 32);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 3;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(3, 61);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(75, 23);
            this.butRemove.TabIndex = 4;
            this.butRemove.Text = "Remove";
            this.butRemove.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.butNew);
            this.panelButtons.Controls.Add(this.butRemove);
            this.panelButtons.Controls.Add(this.butEdit);
            this.panelButtons.Location = new System.Drawing.Point(721, 215);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(83, 91);
            this.panelButtons.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 523);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.scheduleTree);
            this.Controls.Add(this.stationsTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView stationsTree;
        private System.Windows.Forms.TreeView scheduleTree;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Panel panelButtons;
    }
}

