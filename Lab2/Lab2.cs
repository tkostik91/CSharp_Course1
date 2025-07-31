namespace Lab2{

    enum Figures {Circle, Point, Line};

    struct Circle
    {
        public string name = "Circle";

        public Circle() {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Figure names {name}";
        }

    }
    struct Point
    {
        public string name = "Point";

        public Point() {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Figure names {name}";
        }

    }
    record struct Line(string name)
    {
        public string name = name;

    }
    internal class Program {
        static void Main(string[] args){
            {
                Figures figure = Figures.Point;
                Console.WriteLine(figure);

                Circle c = new ();
                Point p = new ();
                Line l = new("Line");
                Console.WriteLine(c);
                Console.WriteLine(p);
                Console.WriteLine(l);
            }
            
        }
    }
}

