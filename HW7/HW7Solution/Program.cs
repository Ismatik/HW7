using System;

namespace HW7Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle a = new Rectangle(4 , 5);

            // a.getArea();
            // a.getPerimeter();



        }
    }

    // class Rectangle
    // {
    //     private double side1{ get; set; }
    //     private double side2{ get; set; }

    //     public Rectangle()
    //     {

    //     }

    //     public Rectangle(double side1 , double side2)
    //     {
    //         this.side1 = side1;
    //         this.side2 = side2;
    //     }

    //     public double AreaCalculator()
    //     {
    //         return side1 * side2;
    //     }

    //     public double PerimeterCalculator()
    //     {
    //         return 2 * (side1 + side2);
    //     }

    //     public void getArea()
    //     {
    //         double area = AreaCalculator();
    //         Console.WriteLine($"The area of your rectangle is {area}");
    //     }

    //     public void getPerimeter()
    //     {
    //         double perimeter = PerimeterCalculator();
    //         Console.WriteLine($"The perimeter of your rectangle is {perimeter}");
    //     }

    // }

    class Book
    {
        public string Title;
        public string Author;
        public string Content;

        public Title title;
        public Author author;
        public Content content;


        public void AddTitle(string title)
        {
            Title = title.getTitle();
        }

        public void AddAuthor(string author)
        {
            Author = author.getAuthor();
        }

        public void AddContent(string content)
        {
            Content = content.getContent();
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

        public string getTitle()
        {
            return this.title;
        }
    }

    class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"The title of the book is {author}");
            Console.ResetColor();
        }

        public string getAuthor()
        {
            return this.author;
        }
    }

    class Content
    {
        public string content;
        public void Show()
        {   
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"The title of the book is {content}");
            Console.ResetColor();
        }

        public string getContent()
        {
            return this.content;
        }
    }
}
