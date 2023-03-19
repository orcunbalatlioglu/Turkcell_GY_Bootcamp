namespace OOPRealLifeExamples
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public virtual string Position()
        {
            return "Employee";
        }
    }

    public class Manager : Employee
    {
        public override string Position()
        {
            return "Manager";
        }
    }

    public class Intern : Employee
    {
        public override string Position()
        {
            return "Intern";
        }
    } 
}
