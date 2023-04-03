using System;
using System.Windows.Forms;

namespace AverageFinder
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void FindAverageBtn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(TotalMarksTextBox.Text, out int totalMarks);
            Int32.TryParse(NoOfSubjectsTextBox.Text, out int totalSubjects);
            float average = (float)totalMarks / totalSubjects;
            AverageValue.Text = average.ToString();
        }
    }
}
