namespace StudentTeacherConsole
{
    internal interface IStaffOrganizer<T> : IPersonOrganizer<T>
    {
        public bool Add(string name, string speciality);
        public List<string> GetSpecialities();
        public List<T> FilterBySpeciality(string speciality);
        public List<T> FilterBySpeciality(List<T> entity, string speciality);
        public List<T> OrderBySpeciality();
        public List<T> OrderBySpeciality(List<T> entity);
        public List<T> OrderByNameAndSpeciality();
        public List<T> OrderByNameAndSpeciality(List<T> entity);
        public List<T> OrderBySpecialityAndName();
        public List<T> OrderBySpecialityAndName(List<T> entity);
    }
}
