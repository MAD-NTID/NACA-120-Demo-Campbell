
public class Student : IStudent
{
    private string firstName,lastName;
    private List<DateTime> attendanceDates;


    public string FirstName => firstName;

    public string LastName => lastName;

    public List<DateTime> AttendanceDates => attendanceDates;

    //comment here
    public Student(string firstName, string lastName, List<DateTime> attendanceDates)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.attendanceDates = attendanceDates;
    }

    //comment here
    public void AddAttendance(DateTime date)
    {
        this.attendanceDates.Add(date);
    }
}