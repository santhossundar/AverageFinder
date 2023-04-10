using System;

namespace AverageFinder
{
    public class AverageFinderPresenter
    {
        private float _TotalMarks;
        private float _NoOfSubjects;

        private readonly IAverageFinderForm form;
        public AverageFinderPresenter(IAverageFinderForm form) 
        {
            this.form = form;
        }

        public void PerformAverage()
        {
            float.TryParse(form.TotalMarks, out _TotalMarks);
            float.TryParse(form.NoOfSubjects, out _NoOfSubjects);
            float average = _TotalMarks / _NoOfSubjects;
            form.AverageValue = average.ToString();
        }
    }
}
