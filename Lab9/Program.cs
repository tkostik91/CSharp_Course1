namespace Lab9{
    internal class Program {
        static void Main(string[] args){
            {
                Point p = new Point("Black");
                Line l = new Line("Red");
                Circle c = new Circle("Green");

                // Shape s = new Shape("Green");

                Shape[] scene = {p,c, l};

                Scene sc = new Scene(scene);
                sc.DrawScene(scene);
            }
        
            
        }
    }
}

