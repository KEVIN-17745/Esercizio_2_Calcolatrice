using System;

namespace Esercizio_2_Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            int num1 = 0, num2 = 0;
            String name,pass;
            int conta_tentativi = 0;
            bool password_cor=false;
            Console.WriteLine("Buongiorno");
            Console.WriteLine("Enter your name to continue:---");
            name = Console.ReadLine();
            var hiddenpass = string.Empty;
            ConsoleKey key;

         
         
            do
            {
                Console.WriteLine("Hello {0}! , Please enter the password to login:---", name);
             
                
                // CODE TO HIDDEN THE INSERING PASSWORD :-)
                do
                {
                    var keyinfo = Console.ReadKey(intercept: true);
                    key = keyinfo.Key;
                    if (!char.IsControl(keyinfo.KeyChar))
                    {
                        Console.Write("#");
                        hiddenpass += keyinfo.KeyChar;

                    }
                } while (key != ConsoleKey.Enter);
                pass = hiddenpass;

                //-------------------------------------------------------------------------------
                Console.WriteLine();
                if (hiddenpass == "ciao")
                {
                    Console.WriteLine("Password is correct");
                    password_cor = true;
                }
                else
                {
                    Console.WriteLine("Password is wrong");
                }
                conta_tentativi++;
            } while (pass != "ciao" && conta_tentativi<3);

            if (password_cor == true)
            {
                Console.WriteLine("Vai avanti");
            }
            else
            {
                Console.WriteLine("Exceed the maximum password limit...error!!!!!!");
                Console.ReadKey();
            }

            Console.WriteLine("Please Select the oparation");
            Console.WriteLine("1 - Addition ");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine();

            
            scelta = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (scelta == '5')
            {
                Environment.Exit(-1);
            }
            else if (scelta == '1' || scelta == '2' || scelta == '3' || scelta == '4')
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Insert the first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insert the second Number");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            int resu=0;

            Console.WriteLine();
            Console.WriteLine();
            switch (scelta)
            {
                case '1':


                    {
                        resu=num1+num2;
                        Console.WriteLine("The answer is "+resu);
                        
                    }
                    break;
                case '2':
                    {
                        resu = num1-num2;
                        Console.WriteLine("The answer is :{0}", resu);
                        
                    }
                    break;
                case '3':
                    {
                        resu = num1*num2;
                        Console.WriteLine("The answer is :{0}", resu);
                        
                    }
                    break;

                case '4':
                    {
                        resu = num1/num2;
                        Console.WriteLine("The answer is :{0}",resu);
                        
                    }
                    break;
                case '5':
                    {
                        Console.WriteLine("Thank You for Using my Calculator System");
                        
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid oparation");
                        

                    }
                    break;

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
