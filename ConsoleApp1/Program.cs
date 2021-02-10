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
            string year = "";
            double fine = 0;

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

            if (grade == 1)
            {
                year = "Freshman";
            }
            else if (grade == 2)
            {
                year = "Sophmore";
            }
            else if (grade == 3)
            {
                year = "Junior";
            }
            else if (grade == 4)
            {
                year = "Senior";
            }         

            //call to private static double cost
            fine = Cost(grade, speed, tSpeed, fine);

            Console.Clear();
            Console.WriteLine("    Student Ticket   \nStudent Number: " + number + "\nStudent Grade: " + "{0}" + "\nSpeed Limit: " + speed +
                "\nTicketed Speed: " + tSpeed + "\nTicket Fine: $" + fine, year);

        }
            
        private static double Cost(int grade, int speed, int tSpeed, double fine)
            {
             int dif = tSpeed - speed;
             fine = 75;

             if (grade == 1)
             {

                 if (tSpeed >= (speed + 20))
                 {
                    fine = fine + (((((dif) - (dif % 5)) / 5) * 87.5) + 100);
                 }
                 else
                 {
                    fine = fine + (((((dif)-(dif%5))/5)*87.5)-50);
                 }
                

             }
             else if (grade == 2)
                 {
                 if (tSpeed >= (speed + 20))
                 {
                     fine = fine + (((((dif)-(dif%5))/5)*87.5) + 100);
                 }
                 else
                 {
                     fine = fine + ((((dif)-(dif%5))/5)*87.5);
                 }


             }
                
             else if (grade == 3)
             {
                if (tSpeed >= (speed + 20))
                {
                    fine = fine + (((((dif) - (dif % 5)) / 5) * 87.5) + 100);
                }
                else
                {
                    fine = fine + ((((dif) - (dif % 5)) / 5) * 87.5);
                }

             }
             else if (grade == 4)
             {
                if (tSpeed >= (speed + 20))
                {
                    fine = fine + (((((dif) - (dif % 5)) / 5) * 87.5) + 200);
                }
                else
                {
                    fine = fine + (((((dif) - (dif % 5)) / 5) * 87.5) + 50);
                }

             }
             
            return fine;
        }

        
    }   


    
    
}

