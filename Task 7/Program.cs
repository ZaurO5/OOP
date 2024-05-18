public class Program
{
    public static void Main()
    {
        Group group = new Group("G101", new DateTime(2024, 3, 30), new DateTime(2025, 2, 12), 3);
        group.GetDetails();

        Student student1 = new Student("Zaur", "Huseynov");
        Student student2 = new Student("Ali", "Mirzoyev");
        group.AddStudent(student1);
        group.AddStudent(student2);

        var students = group.GetStudents();
        Console.WriteLine("Students in group:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} {student.Surname}");
        }
        Teacher teacher1 = new Teacher("Kanan", "Tapdigli");
        group.AddTeacher(teacher1);

        var teachers = group.GetTeachers();
        Console.WriteLine("Teachers in group:");
        foreach (var teacher in teachers)
        {
            Console.WriteLine($"{teacher.Name} {teacher.Surname}");
        }
        Topic topic1 = new Topic("C#");
        group.AddTopic(topic1);

        var topics = group.GetTopics();
        Console.WriteLine("Topics in group:");
        foreach (var topic in topics)
        {
            Console.WriteLine(topic.Title);
        }
    }
}