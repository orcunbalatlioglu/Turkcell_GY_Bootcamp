using StudentTeacherConsole;

ConsoleActions _interface = new ConsoleActions();
_interface.InitializeMainMenu();
while (true)
{
    var input = Console.ReadKey();
    _interface.MainMenuInputCheck(input.KeyChar);

}