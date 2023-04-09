namespace StudentTeacherConsole
{
    internal class DeafStudent : IDisabledStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DeafStudent(string name)
        {
            Id = IdGenerator.NextId();
            Name = name;
        }

        public bool CheckGrades() => true;

        public bool RequestHelp() => true;

        public bool SubmitHomework() => true;
    }
}
