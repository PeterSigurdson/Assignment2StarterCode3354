using System;
using System.Collections;
using System.Collections.Generic;

class Program
    
    // Assignment 2 Starter Code
    // CSD3354 2019W

    static void Main() {
        new ClassSchedule().Run();
    }
}

class ClassSchedule
{
    List<Student> _students = new List<Student>();
    Stack<Section> _sections = new Stack<Section>();
    Queue<Class> _classes = new Queue<Class>();

    public void Run()
    {
        this.CreateClassList();
        this.CreateSections();
        Console.WriteLine(this.CalculateClassAverageGPA());
    }

    public float CalculateClassAverageGPA()
    {
        float totalGPA = 0;
        foreach (var student in _students){
            totalGPA += student.gpa;
        }
        return totalGPA/_students.Count;
    }

    public void CreateClassList ()
    {
        _students.Add(new Student("Joe", 3.8f));
    }

    public void CreateSections()
    {
        _sections.Push(new Section { programgroup = "CPCT", term = "2", sectionnumber = "5" });
    }

    public void CreateClasses()
    {
        _classes.Enqueue(new Class { classname = "Java", datetime = "MON_AM", roomnumber = "B230" });
    }
}

class Student
{
    public string name { get; set; }
    public string studentnumber { get; set; }
    public float gpa { get; set; }
    public string programname { get; set; }
    public string term { get; set; }
    public string section_id { get; set; } 
}

class Section
{
    public string section_id;
    public string class_id; 
}

class Class
{
    public string classname { get; set; }
    public string datetime { get; set; }
    public string roomnumber { get; set; }
    public string section_id { get; set; }
}


