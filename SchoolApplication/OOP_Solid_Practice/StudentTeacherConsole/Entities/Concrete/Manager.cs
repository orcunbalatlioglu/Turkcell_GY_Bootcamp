namespace StudentTeacherConsole
{
    internal class Manager : ISupervise, IManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public Manager(string name, string speciality)
        {
            Id = IdGenerator.NextId();
            Name = name;
            Speciality = speciality;
        }

        public bool CallParentOfStudent() => true;

        public bool WarnStudent() => true;

        public bool WarnTeacher() => true;

        public bool CongratulateTeacher() => true;

    }
}
