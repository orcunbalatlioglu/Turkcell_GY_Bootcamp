namespace StudentTeacherConsole
{
    internal class SupervisorOrganizer : IStaffOrganizer<Supervisor>
    {
        List<Supervisor> supervisors;

        public SupervisorOrganizer()
        {
            supervisors = new List<Supervisor>();
        }
        public SupervisorOrganizer(List<Supervisor> supervisors)
        {
            this.supervisors = supervisors;
        }

        public bool Add(Supervisor supervisor)
        {
            try
            {
                supervisors.Add(supervisor);
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
                Supervisor supervisor = new Supervisor(name, speciality);
                supervisors.Add(supervisor);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Remove(Supervisor supervisor)
        {
            try
            {
                return supervisors.Remove(supervisor);
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
                int index = supervisors.FindIndex(x => x.Id == id);
                if (index == -1)
                    return false;

                supervisors.RemoveAt(index);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Supervisor> GetAll() => supervisors;

        public List<string> GetNames() => supervisors.Select(x => x.Name).ToList();

        public List<string> GetSpecialities() => supervisors.Select(x => x.Speciality).ToList();

        public List<Supervisor> FilterBySpeciality(string speciality) => supervisors.Where(x => x.Speciality == speciality).ToList();

        public List<Supervisor> FilterBySpeciality(List<Supervisor> _supervisors, string speciality) => _supervisors.Where(x => x.Speciality == speciality).ToList();

        public List<Supervisor> FilterByName(string name) => supervisors.Where(x => x.Name == name).ToList();

        public List<Supervisor> FilterByName(List<Supervisor> _supervisors, string name) => _supervisors.Where(x => x.Name == name).ToList();

        public List<Supervisor> OrderBySpeciality() => supervisors.OrderBy(x => x.Speciality).ToList();

        public List<Supervisor> OrderBySpeciality(List<Supervisor> _supervisors) => _supervisors.OrderBy(x => x.Speciality).ToList();

        public List<Supervisor> OrderByName() => supervisors.OrderBy(x => x.Name).ToList();

        public List<Supervisor> OrderByName(List<Supervisor> _supervisors) => _supervisors.OrderBy(x => x.Name).ToList();

        public List<Supervisor> OrderByNameAndSpeciality() => supervisors.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Supervisor> OrderByNameAndSpeciality(List<Supervisor> _supervisors) => _supervisors.OrderBy(x => x.Name).ThenBy(x => x.Speciality).ToList();

        public List<Supervisor> OrderBySpecialityAndName() => supervisors.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public List<Supervisor> OrderBySpecialityAndName(List<Supervisor> _supervisors) => _supervisors.OrderBy(x => x.Speciality).ThenBy(x => x.Name).ToList();

        public Supervisor GetById(int id) => supervisors.Find(x => x.Id == id);
    }
}
