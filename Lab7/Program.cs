using System.Reflection;
namespace Lab7{
    internal class Program {
        static void Main(string[] args){
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (Type t in assembly.GetTypes())
            {
                Console.WriteLine($"Class={t.Name}");
                Console.WriteLine("Methods:");
                foreach(var method in t.GetMethods()) {
                    Console.Write(method.Name + "\t");
                }
                Console.WriteLine("");
                Console.WriteLine("Fields:");
                foreach(var field in t.GetFields()) {
                    Console.Write(field.Name + "\t");
                }
                Console.WriteLine("");
                Console.WriteLine("Property:");
                foreach(var prop in t.GetProperties()) {
                    Console.Write(prop.Name + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}

