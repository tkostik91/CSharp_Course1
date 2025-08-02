namespace Lab11{
    internal class Program {
        static void Main(){
            Circle c = new Circle("Circle");

            Scene sc = new Scene();
            sc.DrawScene();
            sc.Clear();
            sc.DrawScene();
            Console.WriteLine("После удаления");
            sc.Add(c);
            sc.DrawScene();
        }
    
    }
}