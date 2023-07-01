using Domain.Models;

namespace Infrastructure.Services;

public class StudentServices
{
    public void AddCourseGrade(string course, int grade, Student student)
    {
        foreach (var cours in student.courses)
        {
            if (course == cours)
            {
                grades.Add(grade);
            }
        }
    }
}
