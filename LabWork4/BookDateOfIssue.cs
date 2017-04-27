using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public class BookDateOfIssue:BookCost
    {
        DateTime dateOfIssue;

        public DateTime DateOfIssue
        {
            get { return dateOfIssue; }
            set { dateOfIssue = value; }
        }

       public  BookDateOfIssue():base()
        {
            dateOfIssue = DateTime.Now;
        }


       public BookDateOfIssue(String bookName, String author, String newName1, String newName2, double cost, DateTime dateOfIssue)
           : base(bookName, author, newName1, newName2, cost)
        {
            this.dateOfIssue = dateOfIssue;
        }

       public BookDateOfIssue(String bookName, String author, String newName1, String newName2, double cost,  int year, int mounth, int day)
           : base(bookName, author, newName1, newName2, cost)
       {
            // взять текущий год если неккоректное значение 
           if (year < 0 || year > DateTime.Now.Year)
               year = DateTime.Now.Year;

           // взять текущий месяц если некорректное значение 
           if (mounth < 0 || mounth > 12)
               mounth = DateTime.Now.Month;

           DateTime dateTime = new DateTime(year, mounth, day);
           this.dateOfIssue = dateTime;
       }
      

       private bool IsDisposed = false;

       protected override void Dispose(bool disposing)
       {
           if (!IsDisposed)
           {
               if (disposing)
               {
                   // Освобождение управляемых ресурсов
               }
               IsDisposed = true;
           }
           // Обращение к методу Dispose базового класса
           base.Dispose(disposing);
       }

       public override string ToString()
       {
           String result = String.Format("BookName: {0};\nAuthor: {1};\nalternative 1  : {2};\nalternative 2  : {3};\ncost : {4:C};\ndate {5 :ddd, MMM d, yyyy}\n", BookName, Author, Name1,Name2,Cost,dateOfIssue);
           return result;
       }

    }
}
