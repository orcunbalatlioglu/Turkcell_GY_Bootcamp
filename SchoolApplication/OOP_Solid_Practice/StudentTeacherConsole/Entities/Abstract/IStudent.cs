namespace StudentTeacherConsole
{
    internal interface IStudent 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool SubmitHomework();
        public bool CheckGrades();
    }
}
