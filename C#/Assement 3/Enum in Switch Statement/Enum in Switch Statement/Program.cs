using System;

namespace Enum_in_Switch_Statement
{

    enum Role
    {
        Admin,
        moderator,
        user
    }
    internal class Program
    {
        static string WelcomeMasseage(Role role) 
        {
            switch (role) 
            {
            case Role.Admin:
                    return "Welcom , Administrator";
                case Role.moderator:
                    return "Welcom , Administrator";
                case Role.user:
                    return "Welcom , Administrator";

                default:
                    return "unkown role";

            }
        }
        static void Main(string[] args)
        {

            Role userRole=Role.Admin;
            string massage = WelcomeMasseage(userRole);
            Console.WriteLine(massage);
        }
    }
}
