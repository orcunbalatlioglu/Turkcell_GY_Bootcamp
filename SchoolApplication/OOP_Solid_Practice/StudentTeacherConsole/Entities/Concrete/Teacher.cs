namespace StudentTeacherConsole
{
    internal class Teacher : ITeach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }

        public Teacher(string name, string speciality)
        {
            Id = IdGenerator.NextId();
            Name = name;
            Speciality = speciality;
        }

        public bool EnterExamGrade() => true;

        public bool CheckHomework() => true;

    }

}
