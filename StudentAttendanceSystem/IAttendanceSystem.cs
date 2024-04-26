public interface IAttendanceSystem
{
    void LoadAttendanceFromFile(string filePath);
    void SaveAttendanceToFile(string filePath);    
    void AddStudent(string firstName, string lastName, DateTime date);
    void AddStudent(string firstName, string lastName, List<DateTime> dates);
    List<IStudent> SortStudentsByLastName();
    List<IStudent> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate);
    Dictionary<string, IStudent> Students{get;}
}