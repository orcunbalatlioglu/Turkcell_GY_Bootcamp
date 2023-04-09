using System.Reflection.Metadata.Ecma335;

namespace StudentTeacherConsole
{
    internal class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(string name)
        {
            Id = IdGenerator.NextId();
            Name = name;
        }

        public bool CheckGrades() => true;

        public bool SubmitHomework() => true;
    }
}
