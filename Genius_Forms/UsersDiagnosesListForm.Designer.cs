namespace Genius_Forms
{
    partial class UsersDiagnosesListForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.diagnosesListView = new System.Windows.Forms.ListView();
            this.diagnosesDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosesListView
            // 
            this.diagnosesListView.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.diagnosesListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.diagnosesListView.HideSelection = false;
            this.diagnosesListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diagnosesListView.LabelWrap = false;
            this.diagnosesListView.Location = new System.Drawing.Point(12, 20);
            this.diagnosesListView.Name = "diagnosesListView";
            this.diagnosesListView.Size = new System.Drawing.Size(355, 363);
            this.diagnosesListView.TabIndex = 0;
            this.diagnosesListView.UseCompatibleStateImageBehavior = false;
            this.diagnosesListView.View = System.Windows.Forms.View.List;
            // 
            // diagnosesDataGridView
            // 
            this.diagnosesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.countRightAnswers,
            this.diagnose});
            this.diagnosesDataGridView.Location = new System.Drawing.Point(393, 20);
            this.diagnosesDataGridView.Name = "diagnosesDataGridView";
            this.diagnosesDataGridView.Size = new System.Drawing.Size(346, 363);
            this.diagnosesDataGridView.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя";
            this.userName.Name = "userName";
            // 
            // countRightAnswers
            // 
            this.countRightAnswers.HeaderText = "Правильных ответов:";
            this.countRightAnswers.Name = "countRightAnswers";
            // 
            // diagnose
            // 
            this.diagnose.HeaderText = "Диагноз:";
            this.diagnose.Name = "diagnose";
            // 
            // UsersDiagnosesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 408);
            this.Controls.Add(this.diagnosesDataGridView);
            this.Controls.Add(this.diagnosesListView);
            this.Name = "UsersDiagnosesListForm";
            this.Text = "Результаты пользователей";
            this.Shown += new System.EventHandler(this.UsersDiagnosesListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView diagnosesListView;
        private System.Windows.Forms.DataGridView diagnosesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnose;
    }
}