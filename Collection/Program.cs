using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string answer;
            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1.telebe elave et\n2.telebeye imtahan elave et \n3.telebenin 1 imtahan balina bax \n4.telebenin butun imtahan ballarini goster \n5.telebenin imtahan ortalamasini goster \n6.telebeden imtahan sil \n0.Proqrami bitir");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("telebenin adini daxil edin: ");
                        string fullname = Console.ReadLine();
                        Student student = new Student();
                        student.Fullname = fullname;
                        students.Add(student);
                        break;
                    case "2":
                        int no2 = GetStudentNo(students);
                        string examName = GetExamName();
                        int point = GetStudentPoint();
                        students[no2].AddExam(examName, point);
                        break;

                    case "3":
                        int no3 = GetStudentNo(students);
                        string examName3 = GetExamName();
                        Console.WriteLine(students[no3].GetExamResult(examName3));
                        break;
                    case "4":
                        int no4 = GetStudentNo(students);
                        students[no4].GetInfo();
                        break;
                    case "5":
                        int no5 = GetStudentNo(students);
                        Console.WriteLine(students[no5].GetExamAvg()); 
                        break;
                    case "6":
                        int no6 = GetStudentNo(students);
                        string examName6 = GetExamName();
                        students[no6].Exams.Remove(examName6);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("menuda bel secim yoxdur!");
                        break;
                }
            } while (answer != "0");
        }
        static int GetStudentNo(List<Student> students)
        {
            Console.WriteLine("telebenin nomresini daxil edin: ");
            string nostr = Console.ReadLine();
            int no = 0;
            bool check = false;
            while (!check)
            {
                while (!int.TryParse(nostr, out no))
                {
                    Console.WriteLine("eded daxil edin! ");
                    nostr = Console.ReadLine();
                }
                foreach (var item in students)
                {
                    if (item.No == no)
                        check = true;
                }
                if (!check)
                {
                    Console.WriteLine("duzgun deyer daxil edin!");
                    nostr = Console.ReadLine();
                }
            }
            return no;
        }
        static string GetExamName()
        {
            Console.WriteLine("imtahan adi qeyd edin: ");
            string examName = Console.ReadLine();
            return examName;
        }
        static int GetStudentPoint()
        {
            Console.WriteLine("imtahan balini daxil edin: ");
            string pointStr = Console.ReadLine();
            int point = 0;
            bool check = false;
            while (!check)
            {
                while (!int.TryParse(pointStr, out point))
                {
                    Console.WriteLine("eded daxil edin!");
                    pointStr = Console.ReadLine();
                }
                while (int.TryParse(pointStr, out point))
                {
                    if (point >= 0 && point <= 100)
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0 ve 100 arasi eded daxil edin!");
                        pointStr = Console.ReadLine();
                    }
                }
            }
            return point;
        }
    }
}
