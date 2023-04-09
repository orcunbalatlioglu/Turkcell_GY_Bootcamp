namespace StudentTeacherConsole
{
    internal class BlindStudent : IDisabledStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BlindStudent(string name)
        {
            Id = IdGenerator.NextId();
            Name = name;
        }

        public bool CheckGrades() => true;

        public bool RequestHelp() => true;

        public bool SubmitHomework() => true;
    }
}
