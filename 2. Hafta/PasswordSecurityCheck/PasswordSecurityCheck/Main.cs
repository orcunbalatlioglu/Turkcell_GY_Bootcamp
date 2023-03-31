using PasswordSecurityCheck;

Console.WriteLine("Enter your password:");
try { 
    string UserPassword = Console.ReadLine();
    PasswordCheck pswCheck = new PasswordCheck();
    var output = pswCheck.CheckPasswordSecurity(UserPassword);
    if (output != SecurityLevel.INVALID)
        Console.WriteLine($"Your password has {output} security level!");
    else
        Console.WriteLine($"Your password is {output}. It must be least 6 character!");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}