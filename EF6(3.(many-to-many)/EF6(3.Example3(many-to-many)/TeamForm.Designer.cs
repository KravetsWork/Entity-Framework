namespace EF6_3.Example3_many_to_many_
{
    partial class TeamForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxCoach = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(1, 68);
            this.labelCoach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(57, 20);
            this.labelCoach.TabIndex = 1;
            this.labelCoach.Text = "Coach";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(66, 24);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(132, 26);
            this.textBoxTeamName.TabIndex = 2;
            // 
            // textBoxCoach
            // 
            this.textBoxCoach.Location = new System.Drawing.Point(66, 65);
            this.textBoxCoach.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCoach.Name = "textBoxCoach";
            this.textBoxCoach.Size = new System.Drawing.Size(132, 26);
            this.textBoxCoach.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(66, 104);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(51, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(125, 104);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(73, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCoach);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelCoach);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCoach;
        protected internal System.Windows.Forms.TextBox textBoxTeamName;
        protected internal System.Windows.Forms.TextBox textBoxCoach;
        protected internal System.Windows.Forms.Button buttonOK;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}