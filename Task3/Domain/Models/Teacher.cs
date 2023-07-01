namespace Domain.Models;

public class Teacher : Person
{
    int numCourses;
    int courses;
    public Teacher(string name, string address) : base(name, address)
    {
        
    }
}
