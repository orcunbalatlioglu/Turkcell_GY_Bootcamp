using System.Xml.Linq;

namespace StudentTeacherConsole
{
    internal class ClassOrganizer
    {
        List<Class> _classes { get; set; }

        public ClassOrganizer() 
        { 
            _classes = new List<Class>();
        }
        public ClassOrganizer(List<Class> classes)
        {
            this._classes = classes;
        }

        public string AddClass(Class _class)
        {
            try
            {
                _classes.Add(_class);
                return "The class added to the list succesfuly.";
            }
            catch (Exception ex) { 
                return ex.Message;
            }

        }
        public string AddClass(string name, Supervisor supervisor)
        {
            try
            {
                Class _class = new Class(name, supervisor);
                _classes.Add(_class);
                return "The class created and added to the list succesfuly.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AddClass(string name, Supervisor supervisor, List<IStudent> students)
        {
            try
            {   
                Class _class = new Class(name, supervisor, students);
                _classes.Add(_class);
                return "The class created and added to the list succesfuly.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RemoveClass(Class _class)
        {
            try {
                if (_classes.Remove(_class))
                {
                    return "The class succesfuly removed from class list.";
                }
                else
                    return "The class could not be found in class list.";
            }
            catch(Exception e) { 
                return e.Message;
            }
        }
        public string RemoveClass(int id)
        {
            try {
                int index = _classes.FindIndex(x => x.Id == id);
                if (index == -1)
                    return "The class could not be found in class list.";

                _classes.RemoveAt(index);
                return "The class succesfuly removed from class list.";
            }
            catch(Exception e) 
            {
                return e.Message;
            }
        }

        public List<Class> GetAllClassInfo() => _classes;

        public List<string> GetClassNames() => _classes.Select(x => x.Name).ToList();

    }
}
