namespace EF6_3.Example2_one_to_much_
{
    partial class FormCreateTeam
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
            this.groupBoxCreateTeam = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCoach = new System.Windows.Forms.TextBox();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.labelCoach = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxCreateTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreateTeam
            // 
            this.groupBoxCreateTeam.Controls.Add(this.buttonCancel);
            this.groupBoxCreateTeam.Controls.Add(this.buttonOK);
            this.groupBoxCreateTeam.Controls.Add(this.textBoxCoach);
            this.groupBoxCreateTeam.Controls.Add(this.textBoxTeamName);
            this.groupBoxCreateTeam.Controls.Add(this.labelCoach);
            this.groupBoxCreateTeam.Controls.Add(this.labelName);
            this.groupBoxCreateTeam.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCreateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCreateTeam.Name = "groupBoxCreateTeam";
            this.groupBoxCreateTeam.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCreateTeam.Size = new System.Drawing.Size(278, 144);
            this.groupBoxCreateTeam.TabIndex = 0;
            this.groupBoxCreateTeam.TabStop = false;
            this.groupBoxCreateTeam.Text = "Team";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(134, 102);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(65, 31);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(205, 102);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(65, 31);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxCoach
            // 
            this.textBoxCoach.Location = new System.Drawing.Point(64, 69);
            this.textBoxCoach.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoach.Name = "textBoxCoach";
            this.textBoxCoach.Size = new System.Drawing.Size(206, 26);
            this.textBoxCoach.TabIndex = 3;
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(64, 37);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(206, 26);
            this.textBoxTeamName.TabIndex = 2;
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(8, 72);
            this.labelCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(57, 20);
            this.labelCoach.TabIndex = 1;
            this.labelCoach.Text = "Coach";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 40);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // FormCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 170);
            this.Controls.Add(this.groupBoxCreateTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateTeam";
            this.Text = "FormCreateTeam";
            this.groupBoxCreateTeam.ResumeLayout(false);
            this.groupBoxCreateTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.Button buttonOK;
        protected internal System.Windows.Forms.TextBox textBoxCoach;
        protected internal System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.GroupBox groupBoxCreateTeam;
    }
}