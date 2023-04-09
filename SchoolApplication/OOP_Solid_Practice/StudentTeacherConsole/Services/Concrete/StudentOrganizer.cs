using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherConsole
{
    internal class StudentOrganizer : IPersonOrganizer<IStudent>
    {
        List<IStudent> students;

        public StudentOrganizer()
        {
            students = new List<IStudent>();
        }
        public StudentOrganizer(List<IStudent> students)
        {
            this.students = students;
        }   

        public bool Add(IStudent student)
        {
            try
            {
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Add(string name)
        {
            try
            {
                Student student = new Student(name);
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AddBlind(string name)
        {
            try
            {
                BlindStudent student = new BlindStudent(name);
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool AddDeaf(string name)
        {
            try
            {
                BlindStudent student = new BlindStudent(name);
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Remove(IStudent student)
        {
            try
            {
                return students.Remove(student);
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
                int index = students.FindIndex(x => x.Id == id);
                if (index == -1)
                    return false;

                students.RemoveAt(index);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public IStudent GetById(int id) => students.Find(x => x.Id == id);

        public List<IStudent> FilterByName(string name) => students.Where(x => x.Name == name).ToList();

        public List<IStudent> FilterByName(List<IStudent> _students, string name) => _students.Where(x => x.Name == name).ToList();

        public List<IStudent> GetAll() => students;

        public List<string> GetNames() => students.Select(x => x.Name).ToList();

        public List<IStudent> OrderByName() => students.OrderBy(x => x.Name).ToList();

        public List<IStudent> OrderByName(List<IStudent> _students) => _students.OrderBy(x => x.Name).ToList();
    }
}
