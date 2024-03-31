using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayMethodTask
{
    internal class Group
    {
        private string _no;
        private byte _studentLimit;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (value.Length == 5)
                {
                    bool f = false;
                    bool k = true;
                    for (int i = 0; i < value.Length - 3; i++)
                    {

                        if (char.IsLetter(value[i]))
                        {
                            if (value[i].ToString() == value[i].ToString().ToUpper())
                            {
                                f = true;
                            }
                            else
                            {
                                f = false;
                                break;

                            }
                        }
                        else
                        {
                            f = false;
                            break;
                        }
                    }
                    for (int i = value.Length - 3; i < value.Length; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            k = true;
                        }
                        else
                        {
                            k = false;
                            break;
                        }
                    }

                    if (f && k)
                    {
                        _no = value;
                    }
                    else
                    {
                        Console.WriteLine("No deyerinin ilk 2 deyeri boyuk herfle baslamalidir ve son 3 deyeri reqem olmalidir!");
                    }
                }
                else
                {
                    Console.WriteLine("No deyerinin uzunlugu 5 olmalidir!");
                }


            }
        }

        public byte StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value > 0 && value <= 20)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Student limit 0-dan kicik ve 20-den boyuk ola bilmez");
                }
            }
        }

        Student[] Students = new Student[] { };

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit && !String.IsNullOrEmpty(No)) 
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Limitden kenara cixildi ve ya No deyeri duzgun daxil edilmedi!");
            }
        }


        public Student[] SearchStudent(string fullName)
        {
            bool f = true;
            Student[] newStudent = new Student[] { };
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (fullName == Students[i].FullName)
                    {
                        f = false;
                        Array.Resize(ref newStudent, newStudent.Length + 1);
                        newStudent[newStudent.Length - 1] = Students[i];
                    }
                }
                if (f)
                {
                    Console.WriteLine($"{fullName} deye telebe yoxdur!");
                }

            }
            else
            {
                Console.WriteLine("Telebe yoxdur!");
            }

            return newStudent;

        }

        public void ShowAllStudent()
        {
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Console.WriteLine($"FullName: {Students[i].FullName}, AvgPoint: {Students[i].AvgPoint}, GroupNo: {Students[i].GroupNo}");
                }
            }
            else
            {
                Console.WriteLine("Telebe yoxdur!");
            }
        }

        public Group(string no, byte studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;
        }


    }
}
