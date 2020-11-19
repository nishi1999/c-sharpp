using System;

namespace Lab_task
{
    class Program
   
        {
            static void Main(string[] args)
            {
                Student s = new Student("Jannatul", "19-40374-1", "CSE", 3.72f);

                s.ShowInfo();
                

                Book b = new Book("sashar kobita", "Rrobindronath", "10", "upponnash", 200);
                b.ShowInfo();
                

                

                b.AddBookCopy(10);
                b.ShowInfo();
               

                Account sa = new Account("jannatul", "19403741", 10000);
                sa.ShowInfo();
                

                Library l = new Library("New library, "danmondi"," dhaka", 30000);
                l.ShowLibInfo();
               




                l.AddNewBook(b);
                
           
                l.ShowAllBooks();

                l.AddNewBookCopy(b, 70);


                l.ShowAllBooks();

            }
        }
    }
