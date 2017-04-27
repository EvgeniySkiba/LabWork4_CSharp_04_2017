using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public class BookCost:Book
    {
        private String name1;

        // просмотр и переустановк значений 
        public String Name1
        {
            get { return name1; }
            set { name1 = value; }
        }
        private String name2;
       
        // просмотр и переустановк значений 
        public String Name2
        {
            get { return name2; }
            set { name2 = value; }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public BookCost():base()
        {

        }

        public BookCost(String bookName, String author, String newName1, String newName2, double cost):base(bookName,author)
        {
            this.name1 = newName1;
            this.name2 = newName2;
            this.cost = cost;
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

    }
}
