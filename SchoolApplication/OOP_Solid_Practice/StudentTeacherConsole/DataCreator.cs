using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherConsole
{
    internal class DataCreator
    {
        public List<Class> classes;
        public List<IStudent> students;
        public List<Teacher> teachers;
        public List<Supervisor> supervisors;
        public List<Manager> managers;

        public DataCreator()
        {
            students = new()
            {
                new Student ("Ahmet"),
                new DeafStudent ("Ardahan"),
                new BlindStudent ("Gaye"),
                new Student ("Orçun"),
                new Student ("Zehra"),
                new Student ("Name"),
                new Student ("Ayşe"),
                new Student ("Gani"),
                new BlindStudent ("Recep"),
                new DeafStudent ("Uğur"),
                new Student ("Ceren"),
                new Student ("Batu"),
                new Student ("Berk"),
                new Student ("Cem"),
                new Student ("Yaşar"),
                new Student ("Mert"),
                new Student ("Utku"),
                new Student ("Simge"),
                new Student ("İlker"),
                new Student ("Metin"),
                new Student ("Çetin"),
                new Student ("Fatma"),
                new Student ("Ömer"),
                new Student ("Eyşan"),
                new Student ("Cenk"),
                new Student ("Ali"),
                new Student ("Cengiz"),
                new Student ("Lale"),
                new Student ("Ferit"),
                new Student ("Veli"),
                new Student ("Fatma"),
                new Student ("Ayşe"),
                new DeafStudent ("Jale"),
                new BlindStudent ("Bora")
            };

            teachers = new()
            {
                new Teacher ("Türkay",".NET"),
                new Teacher ("Ufuk", "Java"),
                new Teacher ("Salih", "Frontend"),
                new Teacher ("Koray", "Frontend"),
                new Teacher ("İlkkan", "Kotlin"),
                new Teacher ("Orhan", "Swift")
            };

            supervisors = new()
            {
                new Supervisor ("Miray","HR"),
                new Supervisor ("Kerem","HR")
            };

            managers = new()
            {
                new Manager ("Numan", "CEO"),
                new Manager ("Şirin", "COO")
            };

            classes = new ()
            {
                new (".NET",supervisors[0],students.GetRange(0,students.Count/5)),
                new ("Frontend",supervisors[0],students.GetRange(students.Count/5,students.Count/5)),
                new ("Swift",supervisors[1],students.GetRange(2*(students.Count/5),students.Count/5)),
                new ("Kotlin",supervisors[1],students.GetRange(3*(students.Count/5),students.Count/5)),
                new ("Java",supervisors[0],students.GetRange(4*(students.Count/5),students.Count/5))
            };
        }
    }
}
