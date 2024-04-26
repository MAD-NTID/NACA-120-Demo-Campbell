bool exit = false;
IAttendanceSystem attendanceSystem = new AttendanceSystem();

//load by default for testing - remember to remove when done
attendanceSystem.LoadAttendanceFromFile("student_records.csv");

while (!exit)
{
    Console.WriteLine("\nAttendance System Menu:");
    Console.WriteLine("1. Load attendance data from file");
    Console.WriteLine("2. Save attendance data to file");
    Console.WriteLine("3. Add Student attendance");
    Console.WriteLine("4. Sort students by last name");
    Console.WriteLine("5. Select students by date range");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice (1-5): ");

    string choice = Console.ReadLine();

    switch (choice)
    { 
        case "1":
            Console.Write("Enter the csv file:");
            string filename = Console.ReadLine();
            attendanceSystem.LoadAttendanceFromFile(filename);
            Console.WriteLine("Attendance data loaded");
            //Console.Write(attendanceSystem.ToString()); //test
            break;
        case "2":
            Console.Write("Enter Json file to save to:");
            filename = Console.ReadLine();
            attendanceSystem.SaveAttendanceToFile(filename);
            Console.WriteLine("Attendance records saved");
            break;
        case "3":
            Console.Write("Enter student name(first,last):");
            string[] fullName = Console.ReadLine().Split(",");
            Console.Write("Enter attending date YYYY-MM-dd:");
            //we will use space to handle multiple dates
            string[] dates = Console.ReadLine().Split(" ");
            if(dates.Length == 1) {
                attendanceSystem.AddStudent(fullName[0], fullName[1], DateTime.Parse(dates[0]));
            } else {
                List<DateTime> datesDateTimes = new List<DateTime>();
                foreach(string dateString in dates)
                {
                    datesDateTimes.Add(DateTime.Parse(dateString));
                }
                attendanceSystem.AddStudent(fullName[0], fullName[1], datesDateTimes);
            }
            Console.WriteLine("Student attendance added");
            break;
        case "4":
            Console.WriteLine("students sorted by last name");
            List<IStudent> students = attendanceSystem.SortStudentsByLastName();
            foreach(IStudent student in students)
            {
                Console.WriteLine($"{student.LastName},{student.FirstName}");
            }
            break;
        case "5":
            Console.Write("Start date:");
            DateTime from = DateTime.Parse(Console.ReadLine());
            Console.Write("End date:");
            DateTime to = DateTime.Parse(Console.ReadLine());
            students = attendanceSystem.SelectStudentsByDateRange(from, to);
            foreach(IStudent student in students)
            {
                Console.WriteLine($"{student.LastName},{student.FirstName}");
            }
            break;
        case "6":
            Console.WriteLine("Thank you for using this system!");
            exit = true;
            break;


            
    }
}