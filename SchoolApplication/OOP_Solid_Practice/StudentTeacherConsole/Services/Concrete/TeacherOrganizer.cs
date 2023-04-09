namespace StudentTeacherConsole
{
    internal class TeacherOrganizer : IStaffOrganizer<Teacher>
    {
        List<Teacher> teachers;

        public TeacherOrganizer()
        {
            teachers = new List<Teacher>();
        }
        public TeacherOrganizer(List<Teacher> teachers)
        {
            this.teachers = teachers;
        }

        public bool Add(Teacher teacher)
        {
            try
            {
                teachers.Add(teacher);
                return true;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Add(string name, string speciality)
        {
            try
            {
                Teacher teacher = new Teacher(name, speciality);
                teachers.Add(teacher);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Remove(Teacher teacher)
        {
            try
            {
                return teachers.Remove(teacher);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Remove(int id)
        {
            try
            {
                int index = teachers.FindIndex(x => x.Id == id);
                if(index == -1)
                    return false;

                teachers.RemoveAt(index);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Teacher> GetAll() => teachers;

        public List<string> GetNames() => teachers.Select(x => x.Name).ToList();


        public List<string> GetSpecialities() => teachers.Select(x => x.Speciality).ToList();

        public List<Teacher> FilterBySpeciality(string speciality) => teachers.Where(x => x.Speciality == speciality).ToList();

        public List<Teacher> FilterBySpeciality(List<Teacher> _teachers,string speciality) => _teachers.Where(x => x.Speciality == speciality).ToList();

        public List<Teacher> FilterByName(string name) => teachers.Where(x => x.Name == name).ToList();

        public List<Teacher> FilterByName(List<Teacher> _teachers, string name) => _teachers.Where(x => x.Name == name).ToList();

        public List<Teacher> OrderBySpeciality() => teachers.OrderBy(x => x.Speciality).ToList();

        public List<Teacher> OrderBySpeciality(List<Teacher> _teachers) => _teachers.OrderBy(x => x.Speciality).ToList();

        public List<Teacher> OrderByName() => teachers.OrderBy(x=> x.Name).ToList();

        public List<Teacher> OrderByName(List<Teacher> _teachers) => _teachers.OrderBy(x => x.Name).ToList();

        public List<Teacher> OrderByNameAndSpeciality() => teachers.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Teacher> OrderByNameAndSpeciality(List<Teacher> _teachers) => _teachers.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Teacher> OrderBySpecialityAndName() => teachers.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public List<Teacher> OrderBySpecialityAndName(List<Teacher> _teachers) => _teachers.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public Teacher GetById(int id) => teachers.Find(x => x.Id == id);
    }
}

