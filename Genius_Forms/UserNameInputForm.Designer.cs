namespace Genius_Forms
{
    partial class UserNameInputForm
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
            this.userNameTitleLabel = new System.Windows.Forms.Label();
            this.userNameAcceptButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userNameTitleLabel
            // 
            this.userNameTitleLabel.AutoSize = true;
            this.userNameTitleLabel.Location = new System.Drawing.Point(23, 21);
            this.userNameTitleLabel.Name = "userNameTitleLabel";
            this.userNameTitleLabel.Size = new System.Drawing.Size(89, 13);
            this.userNameTitleLabel.TabIndex = 0;
            this.userNameTitleLabel.Text = "Как тебя зовут?";
            // 
            // userNameAcceptButton
            // 
            this.userNameAcceptButton.Enabled = false;
            this.userNameAcceptButton.Location = new System.Drawing.Point(112, 89);
            this.userNameAcceptButton.Name = "userNameAcceptButton";
            this.userNameAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.userNameAcceptButton.TabIndex = 1;
            this.userNameAcceptButton.Text = "Ok";
            this.userNameAcceptButton.UseVisualStyleBackColor = true;
            this.userNameAcceptButton.Click += new System.EventHandler(this.userNameAcceptButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(26, 51);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // UserNameInputForm
            // 
            this.AcceptButton = this.userNameAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 143);
            this.ControlBox = false;
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameAcceptButton);
            this.Controls.Add(this.userNameTitleLabel);
            this.Name = "UserNameInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserNameInput";
            this.Shown += new System.EventHandler(this.UserNameInputForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameTitleLabel;
        private System.Windows.Forms.Button userNameAcceptButton;
        private System.Windows.Forms.TextBox userNameTextBox;
    }
}