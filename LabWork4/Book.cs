using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4
{
    public class Book:IDisposable
    {
        private bool disposed = false;

        String author;

        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        String bookName;

        public String BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public Book()
        {

        }

        public Book(String author, String bookName)
        {
            this.author= author;
            this.bookName = bookName;
        }

        //Декструктор 
        // реализация интерфейса IDisposable.
        void IDisposable.Dispose()
        {
            Dispose(true);
            Console.WriteLine("Destructor");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождаем управляемые ресурсы
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }
 
    }
}
