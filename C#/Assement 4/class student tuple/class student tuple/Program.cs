using System;

enum Gender
{
    Male,
    Female,
    Other
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }

    public Student(string name, int age, string address, Gender gender)
    {
        Name = name;
        Age = age;
        Address = address;
        Gender = gender;
    }
}

class StudentRepository
{
    private Student[] students;

    public StudentRepository()
    {
        students = new Student[]
        {
            new Student("Ali", 20, "Riyadh", Gender.Male),
            new Student("Sara", 22, "Jeddah", Gender.Female),
            new Student("John", 23, "Dammam", Gender.Male)
        };
    }

    public (string Name, int Age, string Address, Gender Gender) GetStudentInfoByIndex(int index)
    {
        var student = students[index];
        return (student.Name, student.Age, student.Address, student.Gender);
    }

    public Student GetStudentByIndex(int index)
    {
        return students[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentRepository repo = new StudentRepository();

        var studentInfo = repo.GetStudentInfoByIndex(0);
        Console.WriteLine($"Name: {studentInfo.Name}, Age: {studentInfo.Age}, Address: {studentInfo.Address}, Gender: {studentInfo.Gender}");

        Student student = repo.GetStudentByIndex(1);
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Address: {student.Address}, Gender: {student.Gender}");
    }
}
