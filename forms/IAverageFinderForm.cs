using System;

namespace AverageFinder
{
    public interface IAverageFinderForm
    {
        string totalMarks { get; set; }
        string noOfSubjects { get; set; }
        event EventHandler averageBtnClicked;
    }
}
