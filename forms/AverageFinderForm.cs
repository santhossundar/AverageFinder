using System;
using System.Windows.Forms;

namespace AverageFinder
{
    public partial class AverageFinderForm : Form, IAverageFinderForm
    {
        private readonly AverageFinderPresenter presenter;
        public AverageFinderForm()
        {
            InitializeComponent();
            presenter = new AverageFinderPresenter(this); 
        }

        string IAverageFinderForm.TotalMarks { 
            get => TotalMarksTextBox.Text; 
            set => TotalMarks.Text = value; 
        }

        string IAverageFinderForm.NoOfSubjects { 
            get => NoOfSubjectsTextBox.Text; 
            set => NoOfSubjects.Text = value; 
        }

        string IAverageFinderForm.AverageValue { 
            get => AverageValue.Text; 
            set => AverageValue.Text = value; 
        }

        private void FindAverageBtn_Click(object sender, EventArgs e)
        {
            presenter.PerformAverage();
        }
    }
}
