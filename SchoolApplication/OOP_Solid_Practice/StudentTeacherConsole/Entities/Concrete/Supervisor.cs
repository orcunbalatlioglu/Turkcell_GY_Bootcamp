namespace StudentTeacherConsole
{
    internal class Supervisor : ISupervise, ITeach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public Supervisor(string name, string speciality)
        { 
            Id = IdGenerator.NextId();
            Name = name;   
            Speciality = speciality;
        }
        public bool CallParentOfStudent() => true;

        public bool WarnStudent() => true;

        public bool EnterExamGrade() => true;

        public bool CheckHomework() => true;
    }
}
