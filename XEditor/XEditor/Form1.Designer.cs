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
            this.butRemove = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.editpanel_line = new System.Windows.Forms.Panel();
            this.labellineName = new System.Windows.Forms.Label();
            this.button_saveline = new System.Windows.Forms.Button();
            this.textedit_line = new System.Windows.Forms.TextBox();
            this.editlabel_line = new System.Windows.Forms.Label();
            this.editpanel_start = new System.Windows.Forms.Panel();
            this.button_saveStart = new System.Windows.Forms.Button();
            this.editstartTimepick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.editstartActive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editpanel_track = new System.Windows.Forms.Panel();
            this.button_saveTrack = new System.Windows.Forms.Button();
            this.numericUpDown_TID = new System.Windows.Forms.NumericUpDown();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.labelTrack = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.editpanel_line.SuspendLayout();
            this.editpanel_start.SuspendLayout();
            this.editpanel_track.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TID)).BeginInit();
            this.SuspendLayout();
            // 
            // stationsTree
            // 
            this.stationsTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.stationsTree.Location = new System.Drawing.Point(0, 0);
            this.stationsTree.Name = "stationsTree";
            this.stationsTree.Size = new System.Drawing.Size(200, 547);
            this.stationsTree.TabIndex = 0;
            this.stationsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.stationsTree_AfterSelect);
            // 
            // scheduleTree
            // 
            this.scheduleTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleTree.Location = new System.Drawing.Point(200, 0);
            this.scheduleTree.Name = "scheduleTree";
            this.scheduleTree.Size = new System.Drawing.Size(289, 547);
            this.scheduleTree.TabIndex = 1;
            this.scheduleTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.scheduleTree_AfterSelect);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(3, 3);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(75, 23);
            this.butNew.TabIndex = 2;
            this.butNew.Text = "Add";
            this.butNew.UseVisualStyleBackColor = true;
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(84, 3);
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
            this.panelButtons.Location = new System.Drawing.Point(495, 12);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(164, 32);
            this.panelButtons.TabIndex = 5;
            // 
            // editpanel_line
            // 
            this.editpanel_line.Controls.Add(this.labellineName);
            this.editpanel_line.Controls.Add(this.button_saveline);
            this.editpanel_line.Controls.Add(this.textedit_line);
            this.editpanel_line.Controls.Add(this.editlabel_line);
            this.editpanel_line.Location = new System.Drawing.Point(498, 49);
            this.editpanel_line.Margin = new System.Windows.Forms.Padding(2);
            this.editpanel_line.Name = "editpanel_line";
            this.editpanel_line.Size = new System.Drawing.Size(150, 78);
            this.editpanel_line.TabIndex = 6;
            this.editpanel_line.Visible = false;
            // 
            // labellineName
            // 
            this.labellineName.AutoSize = true;
            this.labellineName.Location = new System.Drawing.Point(5, 29);
            this.labellineName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellineName.Name = "labellineName";
            this.labellineName.Size = new System.Drawing.Size(35, 13);
            this.labellineName.TabIndex = 3;
            this.labellineName.Text = "Name";
            // 
            // button_saveline
            // 
            this.button_saveline.Location = new System.Drawing.Point(88, 52);
            this.button_saveline.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveline.Name = "button_saveline";
            this.button_saveline.Size = new System.Drawing.Size(56, 19);
            this.button_saveline.TabIndex = 2;
            this.button_saveline.Text = "Save";
            this.button_saveline.UseVisualStyleBackColor = true;
            this.button_saveline.Click += new System.EventHandler(this.button_saveline_Click);
            // 
            // textedit_line
            // 
            this.textedit_line.Location = new System.Drawing.Point(44, 29);
            this.textedit_line.Margin = new System.Windows.Forms.Padding(2);
            this.textedit_line.Name = "textedit_line";
            this.textedit_line.Size = new System.Drawing.Size(102, 20);
            this.textedit_line.TabIndex = 1;
            // 
            // editlabel_line
            // 
            this.editlabel_line.AutoSize = true;
            this.editlabel_line.Location = new System.Drawing.Point(61, 5);
            this.editlabel_line.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editlabel_line.Name = "editlabel_line";
            this.editlabel_line.Size = new System.Drawing.Size(27, 13);
            this.editlabel_line.TabIndex = 0;
            this.editlabel_line.Text = "Line";
            // 
            // editpanel_start
            // 
            this.editpanel_start.Controls.Add(this.button_saveStart);
            this.editpanel_start.Controls.Add(this.editstartTimepick);
            this.editpanel_start.Controls.Add(this.label3);
            this.editpanel_start.Controls.Add(this.editstartActive);
            this.editpanel_start.Controls.Add(this.label2);
            this.editpanel_start.Controls.Add(this.label1);
            this.editpanel_start.Location = new System.Drawing.Point(498, 49);
            this.editpanel_start.Margin = new System.Windows.Forms.Padding(2);
            this.editpanel_start.Name = "editpanel_start";
            this.editpanel_start.Size = new System.Drawing.Size(146, 126);
            this.editpanel_start.TabIndex = 7;
            this.editpanel_start.Visible = false;
            // 
            // button_saveStart
            // 
            this.button_saveStart.Location = new System.Drawing.Point(75, 93);
            this.button_saveStart.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveStart.Name = "button_saveStart";
            this.button_saveStart.Size = new System.Drawing.Size(56, 19);
            this.button_saveStart.TabIndex = 5;
            this.button_saveStart.Text = "Save";
            this.button_saveStart.UseVisualStyleBackColor = true;
            this.button_saveStart.Click += new System.EventHandler(this.button_saveStart_Click);
            // 
            // editstartTimepick
            // 
            this.editstartTimepick.Checked = false;
            this.editstartTimepick.CustomFormat = "HH:mm";
            this.editstartTimepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.editstartTimepick.Location = new System.Drawing.Point(41, 70);
            this.editstartTimepick.Margin = new System.Windows.Forms.Padding(2);
            this.editstartTimepick.Name = "editstartTimepick";
            this.editstartTimepick.ShowUpDown = true;
            this.editstartTimepick.Size = new System.Drawing.Size(52, 20);
            this.editstartTimepick.TabIndex = 4;
            this.editstartTimepick.Value = new System.DateTime(2016, 1, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            // 
            // editstartActive
            // 
            this.editstartActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editstartActive.FormattingEnabled = true;
            this.editstartActive.Items.AddRange(new object[] {
            "work",
            "weekend",
            "sat",
            "sun",
            "school"});
            this.editstartActive.Location = new System.Drawing.Point(41, 37);
            this.editstartActive.Margin = new System.Windows.Forms.Padding(2);
            this.editstartActive.Name = "editstartActive";
            this.editstartActive.Size = new System.Drawing.Size(92, 21);
            this.editstartActive.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // editpanel_track
            // 
            this.editpanel_track.Controls.Add(this.button_saveTrack);
            this.editpanel_track.Controls.Add(this.numericUpDown_TID);
            this.editpanel_track.Controls.Add(this.labelTrackId);
            this.editpanel_track.Controls.Add(this.labelTrack);
            this.editpanel_track.Location = new System.Drawing.Point(498, 49);
            this.editpanel_track.Margin = new System.Windows.Forms.Padding(2);
            this.editpanel_track.Name = "editpanel_track";
            this.editpanel_track.Size = new System.Drawing.Size(159, 103);
            this.editpanel_track.TabIndex = 8;
            this.editpanel_track.Visible = false;
            // 
            // button_saveTrack
            // 
            this.button_saveTrack.Location = new System.Drawing.Point(59, 64);
            this.button_saveTrack.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveTrack.Name = "button_saveTrack";
            this.button_saveTrack.Size = new System.Drawing.Size(56, 19);
            this.button_saveTrack.TabIndex = 6;
            this.button_saveTrack.Text = "Save";
            this.button_saveTrack.UseVisualStyleBackColor = true;
            this.button_saveTrack.Click += new System.EventHandler(this.button_saveTrack_Click);
            // 
            // numericUpDown_TID
            // 
            this.numericUpDown_TID.Location = new System.Drawing.Point(28, 39);
            this.numericUpDown_TID.Name = "numericUpDown_TID";
            this.numericUpDown_TID.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown_TID.TabIndex = 2;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(4, 41);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(18, 13);
            this.labelTrackId.TabIndex = 1;
            this.labelTrackId.Text = "ID";
            // 
            // labelTrack
            // 
            this.labelTrack.AutoSize = true;
            this.labelTrack.Location = new System.Drawing.Point(37, 14);
            this.labelTrack.Name = "labelTrack";
            this.labelTrack.Size = new System.Drawing.Size(35, 13);
            this.labelTrack.TabIndex = 0;
            this.labelTrack.Text = "Track";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 547);
            this.Controls.Add(this.editpanel_start);
            this.Controls.Add(this.editpanel_line);
            this.Controls.Add(this.editpanel_track);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.scheduleTree);
            this.Controls.Add(this.stationsTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelButtons.ResumeLayout(false);
            this.editpanel_line.ResumeLayout(false);
            this.editpanel_line.PerformLayout();
            this.editpanel_start.ResumeLayout(false);
            this.editpanel_start.PerformLayout();
            this.editpanel_track.ResumeLayout(false);
            this.editpanel_track.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView stationsTree;
        private System.Windows.Forms.TreeView scheduleTree;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel editpanel_line;
        private System.Windows.Forms.Button button_saveline;
        private System.Windows.Forms.TextBox textedit_line;
        private System.Windows.Forms.Label editlabel_line;
        private System.Windows.Forms.Panel editpanel_start;
        private System.Windows.Forms.Label labellineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox editstartActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker editstartTimepick;
        private System.Windows.Forms.Button button_saveStart;
        private System.Windows.Forms.Panel editpanel_track;
        private System.Windows.Forms.Label labelTrackId;
        private System.Windows.Forms.Label labelTrack;
        private System.Windows.Forms.Button button_saveTrack;
        private System.Windows.Forms.NumericUpDown numericUpDown_TID;
    }
}

