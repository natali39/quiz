namespace Genius_Forms
{
    partial class EditQuestionsForm
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
            this.addQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addQuestionTextLabel = new System.Windows.Forms.Label();
            this.addQuestionAnswerLabel = new System.Windows.Forms.Label();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuestionTextBox
            // 
            this.addQuestionTextBox.Location = new System.Drawing.Point(24, 45);
            this.addQuestionTextBox.Multiline = true;
            this.addQuestionTextBox.Name = "addQuestionTextBox";
            this.addQuestionTextBox.Size = new System.Drawing.Size(399, 84);
            this.addQuestionTextBox.TabIndex = 1;
            // 
            // addAnswerTextBox
            // 
            this.addAnswerTextBox.Location = new System.Drawing.Point(24, 182);
            this.addAnswerTextBox.Name = "addAnswerTextBox";
            this.addAnswerTextBox.Size = new System.Drawing.Size(399, 20);
            this.addAnswerTextBox.TabIndex = 2;
            // 
            // addQuestionTextLabel
            // 
            this.addQuestionTextLabel.AutoSize = true;
            this.addQuestionTextLabel.Location = new System.Drawing.Point(21, 19);
            this.addQuestionTextLabel.Name = "addQuestionTextLabel";
            this.addQuestionTextLabel.Size = new System.Drawing.Size(128, 13);
            this.addQuestionTextLabel.TabIndex = 3;
            this.addQuestionTextLabel.Text = "Введите текст вопроса:";
            // 
            // addQuestionAnswerLabel
            // 
            this.addQuestionAnswerLabel.AutoSize = true;
            this.addQuestionAnswerLabel.Location = new System.Drawing.Point(21, 156);
            this.addQuestionAnswerLabel.Name = "addQuestionAnswerLabel";
            this.addQuestionAnswerLabel.Size = new System.Drawing.Size(83, 13);
            this.addQuestionAnswerLabel.TabIndex = 4;
            this.addQuestionAnswerLabel.Text = "Введите ответ:";
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(184, 241);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AddQuestionButton.TabIndex = 5;
            this.AddQuestionButton.Text = "Добавить";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // EditQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 293);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.addQuestionAnswerLabel);
            this.Controls.Add(this.addQuestionTextLabel);
            this.Controls.Add(this.addAnswerTextBox);
            this.Controls.Add(this.addQuestionTextBox);
            this.Name = "EditQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление вопросов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addQuestionTextBox;
        private System.Windows.Forms.TextBox addAnswerTextBox;
        private System.Windows.Forms.Label addQuestionTextLabel;
        private System.Windows.Forms.Label addQuestionAnswerLabel;
        private System.Windows.Forms.Button AddQuestionButton;
    }
}