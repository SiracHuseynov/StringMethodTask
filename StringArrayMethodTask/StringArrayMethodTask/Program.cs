using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayMethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            string name = "";
            int groupNo = 0;
            double avgPoint = 0;

            string searchName = "";
            
            Console.Write("No daxil edin: ");
            string no = Console.ReadLine();

            Console.Write("Student limit daxil edin: ");
            byte studentLimit = Convert.ToByte(Console.ReadLine());          

            Group group = new Group(no, studentLimit);

            do
            {
            
                Console.WriteLine("1 - Telebe elave et");
                Console.WriteLine("2 - Butun telebelere bax");
                Console.WriteLine("3 - Telebeler uzre axtaris et");
                Console.WriteLine("0 - Programi bitir");

                Console.Write("Secim edin: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Telebe adini daxil edin: ");
                    name = Console.ReadLine();

                    Console.Write("Telebe balini daxil edin: ");
                    avgPoint = Convert.ToDouble(Console.ReadLine());
                    groupNo++;
                    Student student = new Student(name, groupNo, avgPoint);

                    group.AddStudent(student);

                }
                else if (choice == "2")
                {
                    group.ShowAllStudent();
                }
                else if (choice == "3")
                {
                    Console.Write("Axtarmaq istediyiniz telebenin adini daxil edin: ");
                    searchName = Console.ReadLine();
                    foreach (var item in group.SearchStudent(searchName))
                    {
                        item.ShowInfo();
                    }
                }
            }
            while (choice != "0");


        }
    }
}
