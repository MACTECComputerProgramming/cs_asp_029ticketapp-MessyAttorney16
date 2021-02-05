using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int speed;
            int tSpeed;
            int grade;
            int fine;

            //determine student number, speed, and ticketed speed
            Console.WriteLine("Enter Student Number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed Limit: ");
            speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticketed Speed: ");
            tSpeed = int.Parse(Console.ReadLine());

            //determine grade
            Console.WriteLine("Type Number for Student's Grade: \nFreshman (1)\nSophmore (2)\nJunior (3)\nSenior (4)");
            grade = int.Parse(Console.ReadLine());

            Cost(grade, speed, tSpeed, fine);

            Console.WriteLine("    Student Ticket   \nStudent Number: " + number + "Student Grade: " + grade + "\nSpeed Limit: " + speed + 
                "\nTicketed Speed: " + tSpeed + "Ticket Fine: " + fine);
        }

        public void Cost(int grade, int speed, int tSpeed, int fine)
        {
            if (grade == 1)
            {

                if (tSpeed >= (speed+20))
                {
                    
                }
                else
                {

                }
            }
            else if (grade == 2)
            {



            }
            else if (grade == 3)
            {



            }
            else if (grade == 4)
            {



            }
        }
        

    }   


    
    
}

