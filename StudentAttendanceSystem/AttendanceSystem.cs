
using System.Collections.Concurrent;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

public class AttendanceSystem : IAttendanceSystem
{
    private Dictionary<string, IStudent> students;
    private const string CSV_FILENAME = "student_records.csv";

    public AttendanceSystem()
    {
        this.students = new Dictionary<string, IStudent>();
    }

    public Dictionary<string, IStudent> Students => throw new NotImplementedException();

    public void AddStudent(string firstName, string lastName, DateTime date)
    {

        string fullName = $"{firstName}{lastName}";

        //check if key exist
        if(!students.ContainsKey(fullName)){
            students[fullName] = new Student(firstName, lastName, new List<DateTime>());
        } 
        IStudent student = students[fullName];
        student.AddAttendance(date);
    }

    public void AddStudent(string firstName, string lastName, List<DateTime> dates)
    {
         string fullName = $"{firstName}{lastName}";

        //check if key exist
        if(!students.ContainsKey(fullName)){
            students[fullName] = new Student(firstName, lastName, new List<DateTime>());
        } 
        IStudent student = students[fullName];
        foreach(DateTime date in dates)
            student.AddAttendance(date);
    }

    public void LoadAttendanceFromFile(string filePath)
    {
        StreamReader reader = new StreamReader(filePath);
        //reader.ReadLine();//skip header - option one
        bool skipHeader = true;
        while(!reader.EndOfStream) {
            string content = reader.ReadLine();
            //option 2 to skip header
            if(skipHeader)
            {
                skipHeader = false;
                continue;
            }

            string[] tokens = content.Split(",");
            string firstName = tokens[0];
            string lastName = tokens[1];

            //create a date object and read in all dates from 2 - end
            List<DateTime> dates = new List<DateTime>();
            for(int i = 2; i < tokens.Length; i++)
            {
                dates.Add(DateTime.Parse(tokens[i]));
            }

            Student student = new Student(firstName, lastName, dates);
            string fullName = firstName + lastName;
            //Console.WriteLine(fullName);
            students.Add(fullName, student);

        }

        reader.Close();

    }

    public void SaveAttendanceToFile(string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);
        string jsonObject  = JsonConvert.SerializeObject(students);
        writer.WriteLine(jsonObject);
        writer.Close();
    }

    public List<IStudent> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate)
    {
        List<IStudent> studentsList = students.Values.ToList();
        
        List<IStudent> attendSpecificDate = studentsList.Where(student=> student.AttendanceDates.Any(date=> date>=fromDate && date<=toDate)).ToList();
        return attendSpecificDate;
    }

    public List<IStudent> SortStudentsByLastName()
    {
        List<IStudent> studentsList = students.Values.ToList();
        for(int i = 1; i < studentsList.Count; i++)
        {
             IStudent current = studentsList[i];
            int j = i-1;
           
            while(j >=0 && string.Compare(studentsList[j].LastName, current.LastName) > 0)
            {
                studentsList[j+1] = studentsList[j];
                j--;
            }

            studentsList[j+1] = current;
        }
        return studentsList;
    }

    public override string ToString()
    {
        string fullname = "JohnDoe";
        IStudent student = students[fullname];
        return $"{student.FirstName}--> {student.AttendanceDates[0]}";
    }
}