namespace Lab5{
    internal class Program {
        static void Main(string[] args){
            {

               Point p = new Point(1,2);
               Line l = new Line(1,2,3,4);
               Circle c = new Circle(1,2,12);
               p.Draw();
               p.MoveBy(-1,-2);
               p.Draw();
               l.Draw();
               l.MoveBy(-1,-2);
               l.Draw();
               c.Draw();
               c.MoveBy(-1,-2);
               c.Draw();
               c.Scale(5);
               c.Draw();
            }
            
        }
    }
}

