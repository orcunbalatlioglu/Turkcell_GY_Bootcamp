namespace StudentTeacherConsole
{
    internal class ManagerOrganizer : IStaffOrganizer<Manager>
    {
        List<Manager> _managers;

        public ManagerOrganizer()
        {
            _managers = new List<Manager>();
        }
        public ManagerOrganizer(List<Manager> managers)
        {
            _managers = managers;
        }

        public bool Add(Manager manager)
        {
            try
            {
                _managers.Add(manager);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Add(string name, string speciality)
        {
            try
            {
                Manager manager = new Manager(name, speciality);
                _managers.Add(manager);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Remove(Manager manager)
        {
            try
            {
                return _managers.Remove(manager);
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
                int index = _managers.FindIndex(x => x.Id == id);
                if (index == -1)
                    return false;

                _managers.RemoveAt(index);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Manager> GetAll() => _managers;

        public List<string> GetNames() => _managers.Select(x => x.Name).ToList();

        public List<string> GetSpecialities() => _managers.Select(x => x.Speciality).ToList();

        public List<Manager> FilterByName(string name) => _managers.Where(x => x.Name == name).ToList();

        public List<Manager> FilterByName(List<Manager> managers, string name) => managers.Where(x => x.Name == name).ToList();

        public List<Manager> FilterBySpeciality(string speciality) => _managers.Where(x => x.Speciality == speciality).ToList();

        public List<Manager> FilterBySpeciality(List<Manager> managers, string speciality) => managers.Where(x => x.Speciality == speciality).ToList();

        public List<Manager> OrderByName() => _managers.OrderBy(x => x.Name).ToList();

        public List<Manager> OrderByName(List<Manager> managers) => managers.OrderBy(x => x.Name).ToList();

        public List<Manager> OrderByNameAndSpeciality() => _managers.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Manager> OrderByNameAndSpeciality(List<Manager> managers) => managers.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Manager> OrderBySpeciality() => _managers.OrderBy(x => x.Speciality).ToList();

        public List<Manager> OrderBySpeciality(List<Manager> managers) => managers.OrderBy(x => x.Speciality).ToList();

        public List<Manager> OrderBySpecialityAndName() => _managers.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public List<Manager> OrderBySpecialityAndName(List<Manager> managers) => managers.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public Manager GetById(int id) => _managers.Find(x => x.Id == id);
    }
}
