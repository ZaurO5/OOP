public class Group
{
    public string GroupNo { get; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    public int Limit { get; }

    private List<Student> Students { get; } = new List<Student>();
    private List<Teacher> Teachers { get; } = new List<Teacher>();
    private List<Topic> Topics { get; } = new List<Topic>();

    public Group(string groupNo, DateTime startDate, DateTime endDate, int limit)
    {
        GroupNo = groupNo;
        StartDate = startDate;
        EndDate = endDate;
        Limit = limit;
    }

    public void AddStudent(Student student)
    {
        if (Students.Count < Limit)
        {
            Students.Add(student);
            Console.WriteLine($"Student {student.Name} {student.Surname} added to group {GroupNo}.");
        }
        else
        {
            Console.WriteLine("The group is full.");
        }
    }

    public void RemoveStudent(Student student)
    {
        if (Students.Remove(student))
        {
            Console.WriteLine($"Student {student.Name} {student.Surname} removed from group {GroupNo}.");
        }
        else
        {
            Console.WriteLine("This student is not in the group.");
        }
    }

    public List<Student> GetStudents()
    {
        return new List<Student>(Students);
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
        Console.WriteLine($"Teacher {teacher.Name} {teacher.Surname} added to group {GroupNo}.");
    }

    public void RemoveTeacher(Teacher teacher)
    {
        if (Teachers.Remove(teacher))
        {
            Console.WriteLine($"Teacher {teacher.Name} {teacher.Surname} removed from group {GroupNo}.");
        }
        else
        {
            Console.WriteLine("This teacher is not in the group.");
        }
    }

    public List<Teacher> GetTeachers()
    {
        return new List<Teacher>(Teachers);
    }

    public void AddTopic(Topic topic)
    {
        Topics.Add(topic);
        Console.WriteLine($"Topic {topic.Title} added to group {GroupNo}.");
    }

    public void RemoveTopic(Topic topic)
    {
        if (Topics.Remove(topic))
        {
            Console.WriteLine($"Topic {topic.Title} removed from group {GroupNo}.");
        }
        else
        {
            Console.WriteLine("This topic is not in the group.");
        }
    }

    public List<Topic> GetTopics()
    {
        return new List<Topic>(Topics);
    }

    public void GetDetails()
    {
        Console.WriteLine($"Group No: {GroupNo}");
        Console.WriteLine($"Start Date: {StartDate:dd-MM-yyyy}");
        Console.WriteLine($"End Date: {EndDate:dd-MM-yyyy}");
        Console.WriteLine($"Limit: {Limit}");
    }
}