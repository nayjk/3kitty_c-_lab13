namespace lab13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Books Interreme = new Books { namebook = "Межвремье", autors = "Медина Мирай", datepublication = new DateTime(2022), pages = 890 };
            Books Harry_Potter = new Books { namebook = "Гарри Поттер", autors = "Джоан Роулинг", datepublication = DateTime.Parse("2000 год"), pages = 600};
        }
    }

    interface Forlag //издательство
    {
        public void Name_book();
        public void Autor();
    }

    interface Book : Forlag //интерфейс "Книга" наследует интерфейс "Издательство"
    {
        public void date_publication();
        public void page();
    }

    public class Books : Book
    {
        public DateTime datepublication;
        public int pages;
        public string autors;
        public string namebook;
        public void date_publication()
        {
            Console.WriteLine("Дата публикации книги: " + datepublication);
        }

        public void page()
        {
            Console.WriteLine("Количество страниц книги: " + pages);
        }

        public void Autor()
        {
            Console.WriteLine("Автор книги " + autors);
        }

        public void Name_book()
        {
            Console.WriteLine("Название книги: " + namebook);
        }
        public Books(string namebook, string autors, DateTime datepublication, int pages)
        {
            this.datepublication = datepublication;
            this.pages = pages;
            this.autors = autors;
            this.namebook = namebook;
        }
    }


    public class One //класс, где дата является числом
    {
        public string name_book;
        public string autor;
        public int page;
        public int date_publication_int;
    }

    public class Two //класс, где дата является строкой
    {
        public string name_book2;
        public string autor2;
        public int page2;
        public string date_publication_string2;
    }

    interface User //пользователь
    {
        public void login();
        public void password();
    }

    public class User_class : User //класс пользователя, реализующий интерфейс "Пользователь"
    {
        public void login()
        {

        }

        public void password()
        {

        }
    }

    public class Reader : User, Book
    {
        public void login(){}
        public void password(){}
        public void date_publication(){}
        public void page(){}
        public void Autor(){}
        public void Name_book(){}

        public void message()
        {
            Console.WriteLine("Пользователь под логином " + login + " купил книгу " + Name_book);
        }
    }
}