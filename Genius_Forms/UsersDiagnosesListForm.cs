using Genius.Common;
using System;
using System.Windows.Forms;

namespace Genius_Forms
{
    public partial class UsersDiagnosesListForm : Form
    {
        public UsersDiagnosesListForm()
        {
            InitializeComponent();
        }

        private void UsersDiagnosesListForm_Shown(object sender, EventArgs e)
        {
            var value = FileProvider.GetValue(FilesPath.UsersDiagnosesFile);
            var lines = value.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                string[] rows = line.Split(';');
                diagnosesDataGridView.Rows.Add(rows[0], rows[1], rows[2]);
                diagnosesListView.Items.Add(line);
            }
        }
    }
}
