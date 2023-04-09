namespace StudentTeacherConsole
{
    internal interface IPersonOrganizer<T>
    {
        public bool Add(T entity);
        public bool Remove(T entity);
        public bool Remove(int id);
        public List<T> GetAll();
        public List<string> GetNames();
        public T GetById(int id);
        public List<T> FilterByName(string name);
        public List<T> FilterByName(List<T> entity, string name);
        public List<T> OrderByName();
        public List<T> OrderByName(List<T> entity);
    }
}
