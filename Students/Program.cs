string inputData = string.Empty;

List<Student> students = new List<Student>();

while ((inputData = Console.ReadLine()) != "end")
{
    string[] studentInfo = inputData.Split();

    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    int age = int.Parse(studentInfo[2]);
    string homeTown = studentInfo[3];

    Student student = new Student();

    student.firstName = firstName;
    student.lastName = lastName;
    student.age = age;
    student.homeTown = homeTown;

    students.Add(student);
}

string cityName = Console.ReadLine();

foreach (Student student in students)
{
    if (student.homeTown == cityName)
    {
        Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
    }
}


public class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string homeTown { get; set; }
}