using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hw_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            #region if-else
            //string password = "123";
            //Console.WriteLine("Enter your login ");
            //string login = Console.ReadLine();
            //if (login == "USER")
            //{
            //    Console.WriteLine("Enter your password ");
            //    {
            //        string passwordUser = Console.ReadLine();
            //        if (passwordUser == password)
            //        {
            //            Console.WriteLine("Hello User");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Password is incorrect!");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Login is incorrect!");
            //}
            #endregion
            #region ternary
            //string password = "123";
            //string login = "USER";

            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();

            //string result = (loginUser == login) ? "Enter your password" : "Login is incorrect";
            //if(result == "Enter your password")
            //{
            //    Console.WriteLine(result);
            //    string passwordUser = Console.ReadLine();
            //    result = ((password == passwordUser) ? "Hello USER" : "Password is incorrect");
            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("Login is incorrect");

            #endregion
            #region switch-case
            //const string password = "123";
            //const string login = "USER";
            //Console.WriteLine("Enter your login");
            //string loginUser = Console.ReadLine();
            //switch (loginUser)
            //{
            //    case login:
            //        Console.WriteLine("Enter your password");
            //        string passwordUser = Console.ReadLine();
            //        switch (passwordUser)
            //        {
            //            case password:
            //                Console.WriteLine("Hello User");
            //                break;
            //            default:
            //                Console.WriteLine("Password is incorrect");
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Login is correcter");
            //        break;
            //}

            #endregion
            //Task 2
            #region if - else
            //string password = "123";
            //Console.WriteLine("Enter your login ");
            //string login = Console.ReadLine();
            //if(login != string.Empty)
            //{
            //    if (login == "ADMIN")
            //    {
            //        Console.WriteLine("Enter your password ");
            //        {
            //            string passwordUser = Console.ReadLine();
            //            if (passwordUser == password)
            //            {
            //                Console.WriteLine("Hello Administrator");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Password is incorrect!");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Login is not equal to ADMIN!");
            //    }
            //}
            //else
            //    Console.WriteLine("Login not entered");
            #endregion

            #region ternary
            //string password = "123";
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //string result = (loginUser == "ADMIN" ? "Enter your password" : "Login is not equal to ADMIN");
            //if (result == "Enter your password")
            //{
            //    Console.WriteLine("Enter your password ");
            //    string passUser = Console.ReadLine();
            //    result = password == passUser ? "Hello Administrator" : "Passwor is incorrect";
            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine(result);
            #endregion
            #region
            //const string password = "123";
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //switch (loginUser)
            //{
            //    case "ADMIN":
            //        Console.WriteLine("Enter your password");
            //        string passUser = Console.ReadLine();
            //        switch (passUser)
            //        {
            //            case password:
            //                Console.WriteLine("Hello Administrator");
            //                break;
            //            default:
            //                Console.WriteLine("Passwor is incorrect");
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Login is not equal to ADMIN");
            //        break;
            //}
            #endregion
            // Task 3
            #region if-else
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //if (loginUser == string.Empty)
            //{
            //    Console.WriteLine("Hello Anonimous");
            //}
            #endregion
            #region ternary
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //string result = (loginUser == string.Empty) ? "Hello Anonimous" : "";
            //Console.WriteLine(result);
            #endregion
            #region switch - case
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //switch (loginUser)
            //{
            //    case "":
            //        Console.WriteLine("Hello Anonimous");
            //        break;
            //}
            #endregion

            // Task 4
            #region if - else
            //string password = "123";
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //if(loginUser == "USER" || loginUser == "ADMIN")
            //{
            //    Console.WriteLine("Enter your password ");
            //    string passwordUser = Console.ReadLine();
            //    if (passwordUser != password)
            //    {
            //        Console.WriteLine("Password is not correct");
            //    }
            //    else
            //        Console.WriteLine("Password correct");
            //}
            //else
            //    Console.WriteLine("Login is incorrect");
            #endregion
            #region ternary
            //string password = "123";
            //Console.WriteLine("Enter your login ");
            //string loginUser = Console.ReadLine();
            //string result = (loginUser == "USER" || loginUser == "ADMIN") ? "Enter your password" : "";
            //if(result != string.Empty)
            //{
            //    Console.WriteLine(result);
            //    string passwordUser = Console.ReadLine();
            //    string message = passwordUser != password ? "Password is not correct" : "";
            //    Console.WriteLine(message);
            //}
            #endregion
            #region
            const string password = "123";
            Console.WriteLine("Enter your login ");
            string loginUser = Console.ReadLine();
            switch (loginUser)
            {
                case "ADMIN":
                case "USER":
                    Console.WriteLine("Enter your password");
                    string passwordUser = Console.ReadLine();
                    switch (passwordUser)
                    {
                        case password:// Не хочу тут явно указывать "123", укажу переменную, но она должна быть константой,
                            //а пароль константой делать наверное не самый правильный вариант
                            break;
                        default:
                            Console.WriteLine("Password is not correct");
                            break;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
