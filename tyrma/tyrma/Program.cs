using System;
using System.Collections.Generic;

public class Person
{
    private static int counter = 0;
    private static List<Person> people = new List<Person>();

    private string fullName;
    private DateTime dateOfBirth;
    private int personalNumber;

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }

    public int PersonalNumber
    {
        get { return personalNumber; }
        private set { personalNumber = value; }
    }

    public Person(string fullName, DateTime dateOfBirth)
    {
        this.FullName = fullName;
        this.DateOfBirth = dateOfBirth;
        this.PersonalNumber = counter++;
        people.Add(this);
    }

    public static Person GetPersonByPersonalNumber(int personalNumber)
    {
        foreach (Person person in people)
        {
            if (person.PersonalNumber == personalNumber)
            {
                return person;
            }
        }
        return null;
    }
}

public class Student : Person
{
    private string studentId;

    public string StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public Student(string fullName, DateTime dateOfBirth, string studentId)
        : base(fullName, dateOfBirth)
    {
        this.StudentId = studentId;
    }
}

public class University
{
    private List<Student> students = new List<Student>();
    private static int studentCounter = 0;

    public void AddStudent(Student student)
    {
        student.StudentId = GenerateStudentId();
        students.Add(student);
    }

    private string GenerateStudentId()
    {
        return (++studentCounter).ToString();
    }

    public Student GetStudentByStudentId(string studentId)
    {
        foreach (Student student in students)
        {
            if (student.StudentId == studentId)
            {
                return student;
            }
        }
        return null;
    }
}

public static class StudentsRepository
{
    private static List<Student> students = new List<Student>();

    public static void AddStudent(Student student)
    {
        students.Add(student);
    }

    public static Student GetStudentByPersonalNumber(int personalNumber)
    {
        foreach (Student student in students)
        {
            if (student.PersonalNumber == personalNumber)
            {
                return student;
            }
        }
        return null;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person john = new Person("John Doe", new DateTime(1990, 1, 1));
        Person jane = new Person("Jane Smith", new DateTime(1992, 2, 2));

        Console.WriteLine(john.PersonalNumber); // Output: 0
        Console.WriteLine(jane.PersonalNumber); // Output: 1

        Student alice = new Student("Alice Johnson", new DateTime(1995, 5, 5), "");
        Student bob = new Student("Bob Anderson", new DateTime(1997, 7, 7), "");

        University university = new University();
        university.AddStudent(alice);
        university.AddStudent(bob);

        Console.WriteLine(alice.StudentId); // Output: 1
        Console.WriteLine(bob.StudentId); // Output: 2

        Student retrievedStudent = university.GetStudentByStudentId("2");
        Console.WriteLine(retrievedStudent.FullName); // Output: Bob Anderson

        StudentsRepository.AddStudent(alice);
        StudentsRepository.AddStudent(bob);

        Student retrievedStudentByPersonalNumber = StudentsRepository.GetStudentByPersonalNumber(1);
        Console.WriteLine(retrievedStudentByPersonalNumber.FullName); // Output: Alice Johnson
    }
}