namespace StudentTeacherConsole
{
    internal class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Supervisor? Supervisor { get; set; }
        public List<IStudent> Students { get; set; }

        public Class(string name)
        {
            Id = IdGenerator.NextId();
            Name = name;
            Students = new List<IStudent>();
        }
        public Class(string name, Supervisor supervisor)
        {
            Name = name;
            Supervisor = supervisor;
            Students = new List<IStudent>();
        }

        public Class(string name, Supervisor supervisor, List<IStudent> students)
        {
            Name = name;
            Supervisor = supervisor;
            Students = students;
        }

        public void LoadStudent(List<IStudent> studentList)
        {
            Students = studentList;
            Console.WriteLine($"The student is loaded to class which its id is {Id}.");
        }

        public void AddStudent(IStudent student)
        {
            Students.Add(student);
            Console.WriteLine($"The student named {student.Name} has been added to class which id is {Id}.");
        }

        public void RemoveStudent(IStudent student)
        {
            Students.Remove(student);
            Console.WriteLine($"The student named {student.Name} has been removed from class which id is {Id}.");
        }

        public void UpdateSupervisor(Supervisor supervisor)
        {
            Supervisor = supervisor;
            Console.WriteLine($"The class' supervisor updated.");
        }
    }
}
