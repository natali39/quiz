namespace Genius_Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.сurrentQuestionNumberLabel = new System.Windows.Forms.Label();
            this.сurrentQuestionLabel = new System.Windows.Forms.Label();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.answerLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // сurrentQuestionNumberLabel
            // 
            this.сurrentQuestionNumberLabel.AutoSize = true;
            this.сurrentQuestionNumberLabel.Location = new System.Drawing.Point(12, 117);
            this.сurrentQuestionNumberLabel.Name = "сurrentQuestionNumberLabel";
            this.сurrentQuestionNumberLabel.Size = new System.Drawing.Size(61, 13);
            this.сurrentQuestionNumberLabel.TabIndex = 0;
            this.сurrentQuestionNumberLabel.Text = "Вопрос № ";
            // 
            // сurrentQuestionLabel
            // 
            this.сurrentQuestionLabel.Location = new System.Drawing.Point(12, 141);
            this.сurrentQuestionLabel.Name = "сurrentQuestionLabel";
            this.сurrentQuestionLabel.Size = new System.Drawing.Size(454, 31);
            this.сurrentQuestionLabel.TabIndex = 1;
            this.сurrentQuestionLabel.Text = "Текст вопроса";
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(15, 225);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(58, 20);
            this.userInputTextBox.TabIndex = 3;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(361, 223);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.nextQuestionButton.TabIndex = 4;
            this.nextQuestionButton.Text = "Далее";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeMessageLabel.Location = new System.Drawing.Point(12, 42);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(454, 60);
            this.welcomeMessageLabel.TabIndex = 5;
            this.welcomeMessageLabel.Text = "Приветствие пользователя";
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.историяToolStripMenuItem,
            this.добавитьВопросыToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.restartToolStripMenuItem.Text = "Новая игра";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // добавитьВопросыToolStripMenuItem
            // 
            this.добавитьВопросыToolStripMenuItem.Name = "добавитьВопросыToolStripMenuItem";
            this.добавитьВопросыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.добавитьВопросыToolStripMenuItem.Text = "Добавить вопросы";
            this.добавитьВопросыToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросыToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 198);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(40, 13);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.Text = "Ответ:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.nextQuestionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 277);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.сurrentQuestionLabel);
            this.Controls.Add(this.сurrentQuestionNumberLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений - Идиот";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label сurrentQuestionNumberLabel;
        private System.Windows.Forms.Label сurrentQuestionLabel;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросыToolStripMenuItem;
        private System.Windows.Forms.Label answerLabel;
    }
}

