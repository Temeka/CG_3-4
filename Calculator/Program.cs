using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring 
            int n1;
            int n2;
            int answer;
            string userOption;
        

            // Prompting user to enter their 1st number
            //and system to print number
            Console.WriteLine("Please enter your first number: ");
            n1 = int.Parse(Console.ReadLine());

            //Asking to assign an operator and
            //the compiler to print the selection
            Console.WriteLine("Please select an Operator (*, +, - or /): ");
            userOption = Console.ReadLine();

            //Prompting to enter their 2nd number 
            //and to print the option
            Console.WriteLine("Please enter your 2nd number: ");
            n2 = int.Parse(Console.ReadLine());



            //Instructing the compiler to print the answer of selected operator
            if (userOption == "+")
            {
                answer = n1 + n2;
                Console.Write(answer);
            }
            if (userOption == "*")
            {
                answer = n1 * n2;
                Console.Write(answer);
            }
            if (userOption == "/")
            {
                answer = n1 / n2;
                Console.Write(answer);
            }
            if (userOption == "-")
            {
                answer = n1 - n2;
                Console.Write(answer);
            }

            //Required to execute the program
            Console.ReadLine();
                
               

            
         


         





                
            
            
         

            
            

            


      
        }
    }
}
