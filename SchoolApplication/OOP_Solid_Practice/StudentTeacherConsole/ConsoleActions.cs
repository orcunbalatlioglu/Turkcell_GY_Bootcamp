using ConsoleTables;
using StringExtensionMethods;
using System.Xml.Linq;

/*#################################################################################
 *####### Bu sınıf arayüz önemli olmadığı için dikkatsizce yazılmıştır!############
  #################################################################################
*/
namespace StudentTeacherConsole
{
    public class ConsoleActions
    {
        StudentOrganizer StudentOrganizer { get; set; }
        ClassOrganizer ClassOrganizer { get; set; }
        TeacherOrganizer TeacherOrganizer { get; set; }
        SupervisorOrganizer SupervisorOrganizer { get; set; }
        ManagerOrganizer ManagerOrganizer { get; set; }
        DataCreator DataCreator { get; set; }   
        public ConsoleActions()
        {
            StudentOrganizer = new StudentOrganizer();
            ClassOrganizer = new ClassOrganizer();
            TeacherOrganizer = new TeacherOrganizer();
            SupervisorOrganizer = new SupervisorOrganizer();
            ManagerOrganizer = new ManagerOrganizer();
            DataCreator = new DataCreator();    
        }
        void LoadDefaults()
        {
            StudentOrganizer = new StudentOrganizer(DataCreator.students);
            ClassOrganizer = new ClassOrganizer(DataCreator.classes);
            TeacherOrganizer = new TeacherOrganizer(DataCreator.teachers);
            SupervisorOrganizer = new SupervisorOrganizer(DataCreator.supervisors);
            ManagerOrganizer = new ManagerOrganizer(DataCreator.managers);

            Console.Clear();
            Console.WriteLine("The default data loaded succesfuly.\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            InitializeMainMenu();
        }

        public void InitializeMainMenu()
        {

            Dictionary<string, int> menu = new Dictionary<string, int>();
            menu.Add("Student Operations", 1);
            menu.Add("Teacher Operations", 2);
            menu.Add("Supervisor Operations", 3);
            menu.Add("Manager Operations", 4);
            menu.Add("Load Default Data", 5);
            menu.Add("QUIT", 0);
            ConsoleTable table = new ConsoleTable("Operation", "Key");
            table.Options.EnableCount = false;
            foreach (var item in menu)
            {
                table.AddRow(item.Key, item.Value);
            }

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
        }

        public void MainMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    StudentOperationMenu();
                    break;
                case '2':
                    TeacherOperationMenu();
                    break;
                case '3':
                    SupervisorOperationMenu();
                    break;
                case '4':
                    ManagerOperationMenu();
                    break;
                case '5':
                    LoadDefaults();
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please try again...");
                    break;
            }
        }

        void StudentOperationMenu()
        {
            Dictionary<string, int> operations = new Dictionary<string, int>();
            operations.Add("Add", 1);
            operations.Add("Remove", 2);
            operations.Add("List", 3);
            operations.Add("Search", 4);
            operations.Add("Check Grades", 5);
            operations.Add("Submit Homework", 6);
            Console.WriteLine("----- Student Operations -----");
            ConsoleTable table = new ConsoleTable("Operation", "Key");
            table.Options.EnableCount = false;
            foreach (var item in operations)
            {
                table.AddRow(item.Key, item.Value);
            }
            table.AddRow("Go Back", "0");

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
            StudentOperationMenuInputCheck(Console.ReadKey().KeyChar);
        }
        void StudentOperationMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    StudentTypeMenu();
                    StudentOperationMenu();
                    break;
                case '2':
                    ListStudent(false);
                    RemoveStudent();
                    StudentOperationMenu();
                    break;
                case '3':
                    ListStudent(true);
                    StudentOperationMenu();
                    break;
                case '4':
                    SearchStudent();
                    StudentOperationMenu();
                    break;
                case '5':
                    ListStudent(false);
                    CheckGrades();
                    StudentOperationMenu();
                    break;
                case '6':
                    ListStudent(false);
                    SubmitHomework();
                    StudentOperationMenu();
                    break;
                case '0':
                    InitializeMainMenu();
                    break;
                default:
                    Console.WriteLine("\n\nInvalid Input! Please try again. Press any key to continue.");
                    Console.ReadKey();
                    StudentOperationMenu();
                    break;
            }
        }
        void StudentTypeMenu()
        {
            Dictionary<string, int> types = new Dictionary<string, int>();
            types.Add("Normal", 1);
            types.Add("Blind", 2);
            types.Add("Deaf", 3);

            ConsoleTable table = new ConsoleTable("Type", "Key");
            table.Options.EnableCount = false;
            foreach (var item in types)
            {
                table.AddRow(item.Key, item.Value);
            }
            table.AddRow("Go Back", "0");

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
            StudentTypeMenuInputCheck(Console.ReadKey().KeyChar);
        }
        void StudentTypeMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    AddStudent();
                    StudentOperationMenu();
                    break;
                case '2':
                    AddBlindStudent();
                    StudentOperationMenu();
                    break;
                case '3':
                    AddDeafStudent();
                    StudentOperationMenu();
                    break;
                case '0':
                    StudentOperationMenu();
                    break;
                default:
                    Console.WriteLine("\n\nInvalid Input! Please try again. Press any key to continue.");
                    Console.ReadKey();
                    StudentTypeMenu();
                    break;
            }
        }

        void TeacherOperationMenu()
        {
            Dictionary<string, int> operations = new Dictionary<string, int>();
            operations.Add("Add", 1);
            operations.Add("Remove", 2);
            operations.Add("List", 3);
            operations.Add("Search", 4);
            operations.Add("Check Homework", 5);
            operations.Add("Enter Exam Grade", 6);

            ConsoleTable table = new ConsoleTable("Operation", "Key");
            table.Options.EnableCount = false;
            foreach (var item in operations)
            {
                table.AddRow(item.Key, item.Value);
            }
            table.AddRow("Go Back", "0");

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
            TeacherOperationMenuInputCheck(Console.ReadKey().KeyChar);
        }
        void TeacherOperationMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    AddTeacher();
                    TeacherOperationMenu();
                    break;
                case '2':
                    ListTeacher(false);
                    RemoveTeacher();
                    TeacherOperationMenu();
                    break;
                case '3':
                    ListTeacher(true);
                    TeacherOperationMenu();
                    break;
                case '4':
                    SearchTeacher();
                    TeacherOperationMenu();
                    break;
                case '5':
                    ListTeacher(false);
                    CheckHomeworkTeacher();
                    TeacherOperationMenu();
                    break;
                case '6':
                    ListTeacher(false);
                    EnterExamGradeTeacher();
                    TeacherOperationMenu();
                    break;
                case '0':
                    InitializeMainMenu();
                    break;
                default:
                    Console.WriteLine("\n\nInvalid Input! Please try again. Press any key to continue.");
                    Console.ReadKey();
                    TeacherOperationMenu();
                    break;
            }
        }

        void SupervisorOperationMenu()
        {
            Dictionary<string, int> operations = new Dictionary<string, int>();
            operations.Add("Add", 1);
            operations.Add("Remove", 2);
            operations.Add("List", 3);
            operations.Add("Search", 4);
            operations.Add("Check Homework", 5);
            operations.Add("Enter Exam Grade", 6);
            operations.Add("Call Parent Of Student", 7);
            operations.Add("Warn Student", 8);

            ConsoleTable table = new ConsoleTable("Operation", "Key");
            table.Options.EnableCount = false;
            foreach (var item in operations)
            {
                table.AddRow(item.Key, item.Value);
            }
            table.AddRow("Go Back", 0);

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
            SupervisorOperationMenuInputCheck(Console.ReadKey().KeyChar);
        }
        void SupervisorOperationMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    AddSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '2':
                    ListSupervisor(false);
                    RemoveSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '3':
                    ListSupervisor(true);
                    SupervisorOperationMenu();
                    break;
                case '4':
                    SearchSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '5':
                    ListSupervisor(false);
                    CheckHomeworkSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '6':
                    ListSupervisor(false);
                    EnterExamGradeSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '7':
                    ListSupervisor(false);
                    CallParentOfStudentSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '8':
                    ListSupervisor(false);
                    WarnStudentSupervisor();
                    SupervisorOperationMenu();
                    break;
                case '0':
                    InitializeMainMenu();
                    break;
                default:
                    Console.WriteLine("\n\nInvalid Input! Please try again. Press any key to continue.");
                    Console.ReadKey();
                    SupervisorOperationMenu();
                    break;
            }
        }

        void ManagerOperationMenu()
        {
            Dictionary<string, int> operations = new Dictionary<string, int>();
            operations.Add("Add", 1);
            operations.Add("Remove", 2);
            operations.Add("List", 3);
            operations.Add("Search", 4);
            operations.Add("Call Parent Of Student", 5);
            operations.Add("Warn Student", 6);
            operations.Add("Congratulate Teacher", 7);
            operations.Add("Warn Teacher", 8);

            ConsoleTable table = new ConsoleTable("Operation", "Key");
            table.Options.EnableCount = false;
            foreach (var item in operations)
            {
                table.AddRow(item.Key, item.Value);
            }
            table.AddRow("Go Back", 0);

            Console.Clear();
            table.Write();
            Console.WriteLine("Please select your operation from menu...");
            Console.Write("Operation:");
            ManagerOperationMenuInputCheck(Console.ReadKey().KeyChar);
        }
        void ManagerOperationMenuInputCheck(char input)
        {
            switch (input)
            {
                case '1':
                    AddManager();
                    ManagerOperationMenu();
                    break;
                case '2':
                    ListManager(false);
                    RemoveManager();
                    ManagerOperationMenu();
                    break;
                case '3':
                    ListManager(true);
                    ManagerOperationMenu();
                    break;
                case '4':
                    SearchManager();
                    ManagerOperationMenu();
                    break;
                case '5':
                    ListManager(false);
                    CallParentOfStudentManager();
                    ManagerOperationMenu();
                    break;
                case '6':
                    ListManager(false);
                    WarnStudentManager();
                    ManagerOperationMenu();
                    break;
                case '7':
                    ListManager(false);
                    CongratulateTeacher();
                    ManagerOperationMenu();
                    break;
                case '8':
                    ListManager(false);
                    WarnTeacher();
                    ManagerOperationMenu();
                    break;
                case '0':
                    InitializeMainMenu();
                    break;
                default:
                    Console.WriteLine("\n\nInvalid Input! Please try again. Press any key to continue.");
                    Console.ReadKey();
                    ManagerOperationMenu();
                    break;
            }
        }

        void AddStudent()
        {
            Console.Clear();
            Console.Write("Enter name of student:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();

            if (StudentOrganizer.Add(name))
            {
                Console.WriteLine($"The student named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The student named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
        }
        void AddBlindStudent()
        {
            Console.Clear();
            Console.Write("Enter name of student:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();

            if (StudentOrganizer.AddBlind(name))
            {
                Console.WriteLine($"The blind student named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The blind student named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
        }
        void AddDeafStudent()
        {
            Console.Clear();
            Console.Write("Enter name of student:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();

            if (StudentOrganizer.AddDeaf(name))
            {
                Console.WriteLine($"The deaf student named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The deaf student named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
        }

        void AddTeacher()
        {
            Console.Clear();
            Console.Write("Enter name of teacher:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();

            Console.Write("Enter speciality of teacher:");
            string speciality = Console.ReadLine();

            if (TeacherOrganizer.Add(name,speciality))
            {
                Console.WriteLine($"The teacher named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The teacher named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }

        }
        void AddSupervisor()
        {
            Console.Clear();
            Console.Write("Enter name of supervisor:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();
            Console.Write("Enter speciality of supervisor:");
            string speciality = Console.ReadLine();

            if (SupervisorOrganizer.Add(name, speciality))
            {
                Console.WriteLine($"The supervisor named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The supervisor named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
        }
        void AddManager()
        {
            Console.Clear();
            Console.Write("Enter name of manager:");
            string name = Console.ReadLine();
            name = name.FirstLetterToCapitalAndOthersToLower();
            Console.Write("Enter speciality of manager:");
            string speciality = Console.ReadLine();

            if (ManagerOrganizer.Add(name, speciality))
            {
                Console.WriteLine($"The manager named {name} added succesfuly!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"The manager named {name} could not be added!\n\n");
                Console.Write("Press any key to go back.");
                Console.ReadKey();
            }
        }

        void RemoveStudent()
        {
            Console.Write("Enter id of student who will be removed: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                if (StudentOrganizer.Remove(id))
                {
                    Console.WriteLine("The student removed succesfuly!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The student could not be removed!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
            }
        }
        void RemoveTeacher()
        {
            Console.Write("Enter id of teacher who will be removed: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                if (TeacherOrganizer.Remove(id))
                {
                    Console.WriteLine("The teacher removed succesfuly!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The teacher could not be removed!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
            }
        }
        void RemoveSupervisor()
        {
            Console.Write("Enter id of supervisor who will be removed: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                if (SupervisorOrganizer.Remove(id))
                {
                    Console.WriteLine("The supervisor removed succesfuly!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The supervisor could not be removed!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
            }
            
        }
        void RemoveManager()
        {
            Console.Write("Enter id of manager who will be removed: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                if (ManagerOrganizer.Remove(id))
                {
                    Console.WriteLine("The manager removed succesfuly!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The manager could not be removed!\n\n");
                    Console.Write("Press any key to go back.");
                    Console.ReadKey();
                }
            }
        }

        void SearchStudent()
        {
            Console.Clear();
            Console.WriteLine("Enter name of student who you will search: ");
            string studentName = Console.ReadLine();
            studentName = studentName.FirstLetterToCapitalAndOthersToLower();

            var results = StudentOrganizer.FilterByName(studentName);
            if (ObjectNullHandling(results,"student"))
            {
                ConsoleTable table = new ConsoleTable("Id", "Name");
                table.Options.EnableCount = false;
                foreach (var result in results)
                {
                    table.AddRow(result.Id, result.Name);
                }
                table.Write();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void SearchTeacher()
        {
            Console.Clear();
            Console.WriteLine("Enter name of teacher who you will search: ");
            string teacherName = Console.ReadLine();
            teacherName = teacherName.FirstLetterToCapitalAndOthersToLower();

            var results = TeacherOrganizer.FilterByName(teacherName);
            if (ObjectNullHandling(results, "teacher"))
            {
                ConsoleTable table = new ConsoleTable("Id", "Name", "Speciality");
                table.Options.EnableCount = false;
                foreach (var result in results)
                {
                    table.AddRow(result.Id, result.Name, result.Speciality);
                }
                table.Write();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void SearchSupervisor()
        {
            Console.Clear();
            Console.WriteLine("Enter name of supervisor who you will search: ");
            string supervisorName = Console.ReadLine();
            supervisorName = supervisorName.FirstLetterToCapitalAndOthersToLower();

            var results = SupervisorOrganizer.FilterByName(supervisorName);
            if (ObjectNullHandling(results, "manager"))
            {
                ConsoleTable table = new ConsoleTable("Id", "Name", "Speciality");
                table.Options.EnableCount = false;
                foreach (var result in results)
                {
                    table.AddRow(result.Id, result.Name, result.Speciality);
                }
                table.Write();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void SearchManager()
        {
            Console.Clear();
            Console.WriteLine("Enter name of manager who you will search: ");
            string managerName = Console.ReadLine();
            managerName = managerName.FirstLetterToCapitalAndOthersToLower();

            var results = ManagerOrganizer.FilterByName(managerName);
            if (ObjectNullHandling(results, "manager"))
            {
                ConsoleTable table = new ConsoleTable("Id", "Name","Speciality");
                table.Options.EnableCount = false;
                foreach (var result in results)
                {
                    table.AddRow(result.Id, result.Name, result.Speciality);
                }
                table.Write();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        void Sort()
        {

        }

        void ListStudent(bool getInput)
        {
            var students = StudentOrganizer.GetAll();
            ConsoleTable table = new ConsoleTable("Id", "Name");
            table.Options.EnableCount = false;
            foreach (var student in students)
            {
                table.AddRow(student.Id, student.Name);
            }
            Console.Clear();
            Console.WriteLine("----- Student List -----");
            table.Write();
            if (getInput) {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void ListTeacher(bool getInput)
        {
            var teachers = TeacherOrganizer.GetAll();
            ConsoleTable table = new ConsoleTable("Id", "Name", "Speciality");
            table.Options.EnableCount = false;
            foreach (var teacher in teachers)
            {
                table.AddRow(teacher.Id, teacher.Name, teacher.Speciality);
            }
            Console.Clear();
            Console.WriteLine("----- Teacher List -----");
            table.Write();
            if (getInput)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void ListSupervisor(bool getInput)
        {
            var supervisors = SupervisorOrganizer.GetAll();
            ConsoleTable table = new ConsoleTable("Id", "Name", "Speciality");
            table.Options.EnableCount = false;
            foreach (var supervisor in supervisors)
            {
                table.AddRow(supervisor.Id, supervisor.Name, supervisor.Speciality);
            }
            Console.Clear();
            Console.WriteLine("----- Supervisor List -----");
            table.Write();
            if (getInput)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        void ListManager(bool getInput)
        {
            var managers = ManagerOrganizer.GetAll();
            ConsoleTable table = new ConsoleTable("Id", "Name", "Speciality");
            table.Options.EnableCount = false;
            foreach (var manager in managers)
            {
                table.AddRow(manager.Id, manager.Name, manager.Speciality);
            }
            Console.Clear();
            Console.WriteLine("----- Manager List -----");
            table.Write();
            if (getInput)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        void CheckGrades()
        {
            Console.Write("Enter id of student who will check grades: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                IStudent student = StudentOrganizer.GetById(id);
                if (ObjectNullHandling(student, "student"))
                {
                    if (student.CheckGrades())
                    {
                        Console.WriteLine($"The student checked grades who name is {student.Name} and id is {student.Id}.");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                        StudentOperationMenu();
                    }
                    else
                    {
                        Console.WriteLine("The student could not check grades!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }
        void SubmitHomework()
        {
            Console.Write("Enter id of student who will submit homework: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                IStudent student = StudentOrganizer.GetById(id);

                if (ObjectNullHandling(student, "student"))
                {
                    if (student.GetType() == typeof(Student))
                    {
                        if (student.SubmitHomework())
                        {
                            Console.WriteLine($"The student submitted homework who name is {student.Name} and id is {student.Id}.");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The student could not submit homework!\n\n");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }
                    }
                    
                    else if (student.GetType() == typeof(BlindStudent))
                    {
                        if (student.SubmitHomework())
                        {
                            Console.WriteLine($"The blind student submitted homework as audio file who name is {student.Name} and id is {student.Id}.");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The blind student could not submit homework!\n\n");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }
                    }

                    else if (student.GetType() == typeof(DeafStudent))
                    {

                        if (student.SubmitHomework())
                        {
                            Console.WriteLine($"The deaf student submitted homework as video file who name is {student.Name} and id is {student.Id}.");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The deaf student could not submit homework!\n\n");
                            Console.Write("Press any key to go back.");
                            Console.ReadKey();
                        }

                    }
                }
            }
        }
        
        void CheckHomeworkTeacher()
        {
            Console.WriteLine("Enter id of teacher who will check homework:");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Teacher teacher = TeacherOrganizer.GetById(id);
                if (ObjectNullHandling(teacher, "teacher"))
                {
                    if (teacher.CheckHomework())
                    {
                        Console.WriteLine($"The teacher checked homework who name is {teacher.Name} id is {teacher.Id}.");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The teacher could not check homework!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
            
        }
        void CheckHomeworkSupervisor()
        {
            Console.Write("Enter id of supervisor who will check homework: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Supervisor supervisor = SupervisorOrganizer.GetById(id);
                if(ObjectNullHandling(supervisor, "supervisor"))
                { 
                    if (supervisor.CheckHomework())
                    {
                        Console.WriteLine($"The supervisor checked homework who name is {supervisor.Name} id is {supervisor.Id}.");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The supervisor could not check homework!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }

        void EnterExamGradeTeacher()
        {
            Console.Write("Enter id of teacher who will enter exam grades: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Teacher teacher = TeacherOrganizer.GetById(id);
                if (ObjectNullHandling(teacher, "teacher")) 
                { 
                    if (teacher.EnterExamGrade())
                    {
                        Console.WriteLine($"The teacher entered exam grades who name is {teacher.Name} id is {teacher.Id}.");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The teacher could not enter exam grades!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }
        void EnterExamGradeSupervisor()
        {
            Console.Write("Enter id of supervisor who will enter exam grades: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if(id != -1) { 
                Supervisor supervisor = SupervisorOrganizer.GetById(id);
                if(ObjectNullHandling(supervisor, "supervisor")){ 
                    if (supervisor.EnterExamGrade())
                    {
                        Console.WriteLine($"The supervisor entered exam grades who name is {supervisor.Name} id is {supervisor.Id}.");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The supervisor could not enter exam grades!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }

        void CallParentOfStudentSupervisor()
        {
            Console.Write("Enter id of supervisor who will call parent of student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Supervisor supervisor = SupervisorOrganizer.GetById(id);

                if (ObjectNullHandling(supervisor, "supervisor")) { 
                    if (supervisor.CallParentOfStudent())
                    {
                        Console.WriteLine($"The parent of student called by supervisor who named {supervisor.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The supervisor could not call parent of student!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }
        void CallParentOfStudentManager()
        {
            Console.Write("Enter id of manager who will call parent of student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Manager manager = ManagerOrganizer.GetById(id);

                if (ObjectNullHandling(manager, "manager"))
                {
                    if (manager.CallParentOfStudent())
                    {
                        Console.WriteLine($"The parent of student called by manager who named {manager.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The manager could not call parent of student!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }

        void WarnStudentSupervisor()
        {
            Console.Write("Enter id of supervisor who will warn student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Supervisor supervisor = SupervisorOrganizer.GetById(id);

                if (ObjectNullHandling(supervisor, "supervisor"))
                {
                    if (supervisor.WarnStudent())
                    {
                        Console.WriteLine($"The student warned by supervisor who named {supervisor.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The supervisor could not warn the student!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }
        void WarnStudentManager()
        {
            Console.Write("Enter id of manager who will call parent of student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Manager manager = ManagerOrganizer.GetById(id);

                if (ObjectNullHandling(manager, "manager"))
                {
                    if (manager.WarnStudent())
                    {
                        Console.WriteLine($"The student warned by manager who named {manager.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The manager could not warn the student!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }

        void WarnTeacher()
        {
            Console.Write("Enter id of manager who will call parent of student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Manager manager = ManagerOrganizer.GetById(id);

                if (ObjectNullHandling(manager, "manager"))
                {
                    if (manager.WarnTeacher())
                    {
                        Console.WriteLine($"The teacher warned by manager who named {manager.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The manager could not warn the teacher!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }
        void CongratulateTeacher()
        {
            Console.Write("Enter id of manager who will call parent of student: ");
            int id;
            string input = Console.ReadLine();
            id = IntegerInputHandling(input);

            if (id != -1)
            {
                Manager manager = ManagerOrganizer.GetById(id);

                if (ObjectNullHandling(manager, "manager"))
                {
                    if (manager.CongratulateTeacher())
                    {
                        Console.WriteLine($"The teacher congratulated by manager who named {manager.Name}!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The manager could not congratulate the teacher!\n\n");
                        Console.Write("Press any key to go back.");
                        Console.ReadKey();
                    }
                }
            }
        }

        int IntegerInputHandling(string input)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ID must be integer!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            return id;
        }
        bool ObjectNullHandling(object input,string type)
        {
            if(input == null)
            {
                Console.WriteLine($"The {type} could not be found in list!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return false;
            }
            return true;
        }
        bool ObjectNullHandling(List<object> input, string type)
        {
            if (input.Count == 0 || input[0] == null)
            {
                Console.WriteLine($"The {type} could not be found in list!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return false;
            }
            return true;
        }
    }
}
