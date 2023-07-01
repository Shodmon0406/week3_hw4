using Task2.Classes;

var student = new Student("X", "d");
student.AddCourseGrade("c#", 100);
student.AddCourseGrade("c++", 100);
student.AddCourseGrade("c", 90);
student.AddCourseGrade("js", 80);
student.AddCourseGrade("html", 90);
student.PrintGrades();
System.Console.WriteLine(student.GetAvarageGrade());
System.Console.WriteLine(student.ToString());

var teacher = new Teacher("jon", "hamija");
System.Console.WriteLine($"Course added {teacher.AddCourse("c#")}");
System.Console.WriteLine($"Course added {teacher.AddCourse("c++")}");
System.Console.WriteLine($"Course added {teacher.AddCourse("c++")}");
System.Console.WriteLine($"Course removed {teacher.RemoveCourse("c++")}");
System.Console.WriteLine(teacher.ToString());
teacher.PrintCourses();