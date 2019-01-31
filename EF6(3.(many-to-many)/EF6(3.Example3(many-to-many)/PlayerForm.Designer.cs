namespace EF6_3.Example3_many_to_many_
{
    partial class PlayerForm
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
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPast = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.listBoxPastTeams = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(21, 52);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // labelPast
            // 
            this.labelPast.AutoSize = true;
            this.labelPast.Location = new System.Drawing.Point(21, 89);
            this.labelPast.Name = "labelPast";
            this.labelPast.Size = new System.Drawing.Size(129, 60);
            this.labelPast.TabIndex = 2;
            this.labelPast.Text = "In there teams \r\nplayer a soccer \r\nplayer:\r\n";
            this.labelPast.Click += new System.EventHandler(this.labelPast_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(148, 52);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(165, 26);
            this.numericUpDownAge.TabIndex = 4;
            // 
            // listBoxPastTeams
            // 
            this.listBoxPastTeams.FormattingEnabled = true;
            this.listBoxPastTeams.ItemHeight = 20;
            this.listBoxPastTeams.Items.AddRange(new object[] {
            "Real",
            "Bayern",
            "Barcelona",
            "Chelsea"});
            this.listBoxPastTeams.Location = new System.Drawing.Point(148, 89);
            this.listBoxPastTeams.Name = "listBoxPastTeams";
            this.listBoxPastTeams.Size = new System.Drawing.Size(165, 84);
            this.listBoxPastTeams.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(148, 190);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(72, 35);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(240, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(73, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 231);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxPastTeams);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPast);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPast;
        protected internal System.Windows.Forms.TextBox textBoxName;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownAge;
        protected internal System.Windows.Forms.ListBox listBoxPastTeams;
        protected internal System.Windows.Forms.Button buttonOK;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}