namespace Task2.Classes;

public class Student : Person
{
    int numCourses = 0;
    List<string> courses = new List<string>();
    List<double> grades = new List<double>();
    public Student(string name, string address) : base(name, address)
    {
        
    }
    public void AddCourseGrade(string course, double grade)
    {
        int cnt = 0;
        foreach (var cours in courses)
        {
            if (course == cours)
            {
                cnt++;
            }
        }
        if (cnt == 0)
        {
            courses.Add(course);
            grades.Add(grade);
            System.Console.WriteLine("Course added successfully");
        }
        else
        {
            System.Console.WriteLine("Such a course already exists");
        }
    }
    public void PrintGrades()
    {
        foreach (var grade in grades)
        {
            System.Console.WriteLine(grade);
        }
    }
    public double GetAvarageGrade()
    {
        return grades.Average();
    }
    public override string ToString()
    {
        return $"Student: {base.ToString()}";
    }
}
