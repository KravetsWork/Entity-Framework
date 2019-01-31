namespace EF6_3.Example2_one_to_much_
{
    partial class FormPlayer
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
            this.groupBoxSoccerPlayer = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxSoccerPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSoccerPlayer
            // 
            this.groupBoxSoccerPlayer.Controls.Add(this.buttonCancel);
            this.groupBoxSoccerPlayer.Controls.Add(this.buttonOk);
            this.groupBoxSoccerPlayer.Controls.Add(this.comboBoxTeam);
            this.groupBoxSoccerPlayer.Controls.Add(this.numericUpDownAge);
            this.groupBoxSoccerPlayer.Controls.Add(this.comboBoxPosition);
            this.groupBoxSoccerPlayer.Controls.Add(this.textBoxName);
            this.groupBoxSoccerPlayer.Controls.Add(this.labelTeam);
            this.groupBoxSoccerPlayer.Controls.Add(this.labelAge);
            this.groupBoxSoccerPlayer.Controls.Add(this.labelPosition);
            this.groupBoxSoccerPlayer.Controls.Add(this.labelName);
            this.groupBoxSoccerPlayer.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSoccerPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSoccerPlayer.Name = "groupBoxSoccerPlayer";
            this.groupBoxSoccerPlayer.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSoccerPlayer.Size = new System.Drawing.Size(339, 228);
            this.groupBoxSoccerPlayer.TabIndex = 0;
            this.groupBoxSoccerPlayer.TabStop = false;
            this.groupBoxSoccerPlayer.Text = "SoccerPlayer";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(256, 186);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(172, 186);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(76, 28);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(100, 145);
            this.comboBoxTeam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(231, 28);
            this.comboBoxTeam.TabIndex = 7;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(101, 106);
            this.numericUpDownAge.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(230, 26);
            this.numericUpDownAge.TabIndex = 6;
            this.numericUpDownAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Forward",
            "Midfielder",
            "Defender",
            "Goalkeeper"});
            this.comboBoxPosition.Location = new System.Drawing.Point(101, 70);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(230, 25);
            this.comboBoxPosition.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(17, 148);
            this.labelTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(51, 20);
            this.labelTeam.TabIndex = 3;
            this.labelTeam.Text = "Team";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(17, 108);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(17, 71);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 20);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Position";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.groupBoxSoccerPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPlayer";
            this.Text = "FormPlayer";
            this.groupBoxSoccerPlayer.ResumeLayout(false);
            this.groupBoxSoccerPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.GroupBox groupBoxSoccerPlayer;
        protected internal System.Windows.Forms.ComboBox comboBoxTeam;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownAge;
        protected internal System.Windows.Forms.ComboBox comboBoxPosition;
        protected internal System.Windows.Forms.TextBox textBoxName;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}