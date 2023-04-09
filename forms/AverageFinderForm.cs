using System;
using System.Windows.Forms;

namespace AverageFinder
{
    public partial class AverageFinderForm : Form
    {
        public AverageFinderForm()
        {
            InitializeComponent();
        }

        public string totalMarks {
            get => TotalMarksTextBox.Text;
            set => TotalMarks.Text = value; 
        }

        public string noOfSubjects {
            get => NoOfSubjectsTextBox.Text; 
            set => NoOfSubjects.Text = value;
        }

        public event EventHandler averageBtnClicked;

        private void FindAverageBtn_Click(object sender, EventArgs e)
        {
            Int32.TryParse(totalMarks, out int _totalMarks);
            Int32.TryParse(noOfSubjects, out int _noOfSubjects);
            float average = (float)_totalMarks / _noOfSubjects;
            AverageValue.Text = average.ToString();
        }
    }
}
