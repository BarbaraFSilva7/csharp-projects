namespace CredentialValidator;

public class Program
{
    public static void Main()
    {
        //LOGICAL OPERATOR
        Console.WriteLine("============== CREDENTIAL VALIDATOR  ===============");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.WriteLine("\nUser Information: ");
        Console.WriteLine("Logged-in user: " + isLogged);
        Console.WriteLine("Admin panel access: " + hasAdminAccess);

        Console.WriteLine("\n--------------------------------------------------");
        Console.WriteLine("\nPermissions: ");
        Console.WriteLine("\n--------------------------------------------------");

        // OR - Operator (||)
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("* System access granted *");
            
        }
        else
        {
            Console.WriteLine("* System access denied *");
        }

        // AND - Operator  (&&)
        if (isLogged && hasAdminAccess  )
        {
            Console.WriteLine("* Access to the Admin panel granted *");
        }
        else
        {
            Console.WriteLine("* Access to the Admin panel denied *");
        }

        //NOT - Operator (!)
        if (!isLogged)
        {
            Console.WriteLine("* User is not logged in *");
        }
        else
        {
            Console.WriteLine("* User is logged in  *");
        }
    }
}
