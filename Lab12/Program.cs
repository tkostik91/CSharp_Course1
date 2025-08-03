namespace Lab12{
    internal class Program {
        static void Main(){
            Circle c1 = new Circle("White");
            Circle c2 = new Circle("White");

            Console.WriteLine(c1.Equals(c2));

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);

             
            c1 = new Circle("White");
            c2 = new Circle("White2");

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);
            
        }
    
    }
}