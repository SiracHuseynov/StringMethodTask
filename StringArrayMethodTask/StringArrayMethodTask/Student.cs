using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayMethodTask
{
    internal class Student
    {
        public string FullName;
        public int GroupNo;
        private double _avgPoint;

        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _avgPoint = value;
                }
                else
                {
                    Console.WriteLine("Bal 0-100 araliginda olmalidir!");
                }
            }
        }

        public Student(string fullName, int groupNo, double avgPoint)
        {
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName}, AvgPoint: {AvgPoint}, GroupNo: {GroupNo}");
        }
    }
}
