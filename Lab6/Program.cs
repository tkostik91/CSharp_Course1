namespace Lab6{
    internal class Program {
        static void Main(string[] args){
            {
                Point p = new Point("Black");
                Line l = new Line("Red");
                Circle c = new Circle("Green");

                // Shape s = new Shape("Green");

                Shape[] scene = {p,l,c};
                DrawScene(scene);
            }
        static void DrawScene(Shape[]scene)
        {
            foreach(Shape s in scene){
                s.Draw();
            }
        }
            
        }
    }
}

