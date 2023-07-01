namespace Task2.Classes;

public class Student : Person
{
    int numCourses = 0;
    List<string> courses;
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
