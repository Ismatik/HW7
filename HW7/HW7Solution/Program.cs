using System;

namespace HW7Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(4 , 5);

            a.getArea();
            a.getPerimeter();

            Book book = new Book();
            book.title = new Title("Life");
            book.author = new Author("Undefined creature");
            book.content = new Content("Chance to be alive in world as a human.");
            book.Show();
        }
    }

    class Rectangle
    {
        private double side1{ get; set; }
        private double side2{ get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double side1 , double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public void getArea()
        {
            double area = AreaCalculator();
            Console.WriteLine($"The area of your rectangle is {area}");
        }

        public void getPerimeter()
        {
            double perimeter = PerimeterCalculator();
            Console.WriteLine($"The perimeter of your rectangle is {perimeter}");
        }

    }

    class Book
    {
        public Title title;
        public Author author;
        public Content content;

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }

        public Book()
        {
        }

        public Book(Title title , Author author, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }
    }

    class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"The title of the book is {title}");
            Console.ResetColor();
        }
        
        public Title(string title)
        {
            this.title = title;
        }

    }

    class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The author of the book is {author}");
            Console.ResetColor();
        }

        public Author(string author)
        {
            this.author = author;
        }
        
    }

    class Content
    {
        public string content;
        public void Show()
        {   
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"The content of the book is {content}");
            Console.ResetColor();
        }

        public Content(string content)
        {
            this.content = content;
        }
    }
}
