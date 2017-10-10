namespace Plex_Filename_Manager
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
            this.formatButton = new System.Windows.Forms.Button();
            this.seasonFormatCheckBox = new System.Windows.Forms.CheckBox();
            this.showNameTextBox = new System.Windows.Forms.TextBox();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formatButton
            // 
            this.formatButton.Location = new System.Drawing.Point(197, 183);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(75, 23);
            this.formatButton.TabIndex = 0;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // seasonFormatCheckBox
            // 
            this.seasonFormatCheckBox.AutoSize = true;
            this.seasonFormatCheckBox.Location = new System.Drawing.Point(197, 151);
            this.seasonFormatCheckBox.Name = "seasonFormatCheckBox";
            this.seasonFormatCheckBox.Size = new System.Drawing.Size(80, 17);
            this.seasonFormatCheckBox.TabIndex = 1;
            this.seasonFormatCheckBox.Text = "checkBox1";
            this.seasonFormatCheckBox.UseVisualStyleBackColor = true;
            // 
            // showNameTextBox
            // 
            this.showNameTextBox.Location = new System.Drawing.Point(93, 51);
            this.showNameTextBox.Name = "showNameTextBox";
            this.showNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.showNameTextBox.TabIndex = 2;
            this.showNameTextBox.TextChanged += new System.EventHandler(this.showNameTextBox_TextChanged);
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Location = new System.Drawing.Point(13, 57);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(65, 13);
            this.showNameLabel.TabIndex = 3;
            this.showNameLabel.Text = "Show Name";
            this.showNameLabel.Click += new System.EventHandler(this.showNameLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showNameLabel);
            this.Controls.Add(this.showNameTextBox);
            this.Controls.Add(this.seasonFormatCheckBox);
            this.Controls.Add(this.formatButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.CheckBox seasonFormatCheckBox;
        private System.Windows.Forms.TextBox showNameTextBox;
        private System.Windows.Forms.Label showNameLabel;
    }
}

