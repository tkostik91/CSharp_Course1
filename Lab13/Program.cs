namespace Lab13{
    public delegate void Action(object sender, EventArgs args);
    internal class Program {
        static void Main(){
            Circle c = new Circle("Black", 1, 1, 5);
            Circle c2 = new Circle("White", 1, 1, 5);

            c.ActionOn += c.OnRadiusChanged;
            c2.ActionOn += c2.OnRadiusChanged;

            c.ActionOn += delegate (object sender, EventArgs args)
            {
                c.Draw(); 
                Console.WriteLine("Анонимный делегат");
            };

            c.ActionOn += (sender, args) => Console.WriteLine("Лямбда делегат");

            c.Radius = 1;
            c2.Radius = 3;
        }
    
    }
}