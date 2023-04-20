namespace lab13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Books Interreme = new Books { namebook = "Межвремье", autors = "Медина Мирай", datepublication = new DateTime(2022), pages = 890 };
            Books Harry_Potter = new Books { namebook = "Гарри Поттер", autors = "Джоан Роулинг", datepublication = DateTime.Parse("2000"), pages = 600};
            
            Interreme.Name_book();
            Interreme.Autor();
            Interreme.date_publication();
            Interreme.page();

            Harry_Potter.Name_book();
            Harry_Potter.Autor();
            Harry_Potter.date_publication();
            Harry_Potter.page();

            User_class Liza = new User_class { logins = new DateTime(2004), passwords = "лиза2004" };

            Liza.login();
            Liza.password();

            User_class Lena = new User_class { logins = DateTime.Parse("1980"), passwords = "лена1980"};

            Lena.login();
            Lena.password();

            Reader reader = new Reader { login2 = "Вилена" , Name_book2 = "Осколки нашей реальности"};

            reader.message();
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
        public DateTime logins;
        public string passwords;
        public void login()
        {
            Console.WriteLine("Существует пользователь под ником: " + logins);
        }

        public void password()
        {
            Console.WriteLine("Пароль: " + passwords);
        }
    }

    public class Reader : User, Book
    {
        public string login2;
        public string Name_book2;
        public void login(){}
        public void password(){}
        public void date_publication(){}
        public void page(){}
        public void Autor(){}
        public void Name_book(){}

        public void message()
        {
            Console.WriteLine("Пользователь под именем " + login2 + " купил книгу " + Name_book2);
        }
    }
}
