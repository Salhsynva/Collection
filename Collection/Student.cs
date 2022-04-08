using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        static int _totalCount;
        public int No { get;  }
        public string Fullname { get; set; }
        public Dictionary<string, int> Exams = new Dictionary<string, int>();
        public void AddExam(string examName, int point)
        {
            foreach (var exam in Exams)
            {
                if (exam.Key == examName)
                    return;
            }
            Exams.Add(examName, point);
        }
        public int GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examName)
                    return item.Value;
            }
            return -1;
        }
        public double GetExamAvg()
        {
            int sum = 0;
            int count = 0;
            foreach (var item in Exams)
            {
                sum += item.Value;
                count++;
            }
            if (count > 0)
                return sum / count;
            return 0;
        }
        public void GetInfo()
        {
            foreach (var item in Exams)
            {
                Console.WriteLine(item.Key+ " : " + item.Value);
            }
        }


    }
}
