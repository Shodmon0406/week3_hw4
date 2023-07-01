namespace Task2.Classes;

public class Teacher : Person
{
    List<string> courses = new List<string>();
    public Teacher(string name, string address) : base(name, address)
    {

    }
    public bool AddCourse(string course)
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
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool RemoveCourse(string course)
    {
        int cnt = 0;
        foreach (var cours in courses)
        {
            if (course == cours)
            {
                cnt++;
            }
        }
        if (cnt == 1)
        {
            courses.Remove(course);
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()
    {
        return $"Teacher: {base.ToString()}";
    }
    public void PrintCourses()
    {
        foreach (var course in courses)
        {
            System.Console.WriteLine(course);
        }
    }
}
