namespace Domain.Models;

public class Student : Person
{
    int numCourses = 0;
    public List<string> courses;
    List<int> grades;
    public Student(string name, string address) : base(name, address)
    {
        
    }
    public void AddCourseGrade(string course, int grade)
    {
        foreach (var cours in courses)
        {
            if (course == cours)
            {
                grades.Add(grade);
            }
        }
    }
}
