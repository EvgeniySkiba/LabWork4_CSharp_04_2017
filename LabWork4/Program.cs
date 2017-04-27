using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDateOfIssue[] baooksArray = {
             new BookDateOfIssue("Java ", "Herbert Schildt", "Java: A Beginner's Guide", "C++ base course", 48.23, 2014, 10, 12),
             new BookDateOfIssue("C++ base course", "Herbert Schildt", "C ++: Schildt's Programming Techniques", "C", 6231.27, 2017, 1, 12),
             new BookDateOfIssue("C ++: Schildt's Programming Techniques", "Herbert Schildt", "C", "C # 4.0: The Complete Guide", 931.23, 2015, 10, 12),
             new BookDateOfIssue("C", "Herbert Schildt", "C ++: Schildt's Programming Techniques", "C ++: Schildt's Programming Techniques", 531.23, 2014, 9, 10),
             new BookDateOfIssue("Java: A Beginner's Guide", "Herbert Schildt", "C # 4.0: The Complete Guide", "C", 1531.13, 2017, 2, 12),
             new BookDateOfIssue("C # 4.0: The Complete Guide", "Herbert Schildt", "C ++: Schildt's Programming Techniques", "", 3531.23, 2017, 4, 12)};

            //месяц назад
            DateTime dateTimeMountAgo = DateTime.Now.AddMonths(-1);

            Console.WriteLine("Were taken more than a month ago : ");
            for (int i = 0; i < baooksArray.Length; i++)
            {
                int result = DateTime.Compare(baooksArray[i].DateOfIssue, dateTimeMountAgo);
                if (result < 0)
                    Console.WriteLine(baooksArray[i]);
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}
