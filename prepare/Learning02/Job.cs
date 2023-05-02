public class Job
{
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses.
    public Job()
    {
    }

    // A method that displays the job information.
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Reference: https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html