namespace Lab3{
    internal class Program {

        static (double x1, double x2, bool HasRoots, bool isSingleRoot ) resultQuadraticEquation (int a, int b, int c) {
            Console.WriteLine($"{a}*x^2+{b}*x+{c}");
            double x1 = 0,  x2 = 0;
            bool HasRoots = false, isSingleRoot =false;
            double d = b*b-4*a*c;
            Console.WriteLine($"d={d}");
            if(d<0) {
                HasRoots=false;
                isSingleRoot=false;
            } else if(d==0){
                x1 = -b / (2*a);
                HasRoots=false;
                isSingleRoot=true;
            } else {
                x1 = (-b + Math.Sqrt(d))/(2*a);
                x2 = (-b - Math.Sqrt(d))/(2*a);
                HasRoots=true;
                isSingleRoot=false;
            }
            return (x1,x2,HasRoots,isSingleRoot);
        }
        static void Main(string[] args){
            {
                Console.WriteLine($"Введите количество ворон:");
                string input = Console.ReadLine();
                int i;

                int.TryParse(input, out i) ;

                int lastDigit = i % 100;
                int lastOne = i % 10;

                string r;

                if(lastDigit >= 11 && lastDigit <= 14) {
                    r = "ворон";
                } else {
                    r = lastOne switch
                    {
                        1 => "ворона",
                        int when lastOne >= 2 && lastOne <=4 => "вороны",
                        _ => "ворон"
                    };
                }
                Console.WriteLine($"На ветке {i} {r}");

                Console.WriteLine("Числа фибоначчи:");

                int a = 0;
                int b = 1;
                while(b < 1000)
                {
                    Console.Write("{0,-5}", b );
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                Console.WriteLine($"Квадратное уровнение:");
                var res = resultQuadraticEquation(-4,5,12);
                Console.WriteLine($"x1={res.x1}, x2={res.x2},имеет 2 решения={res.HasRoots}, имеет 1 решение:{res.isSingleRoot}");
            }
            
        }
    }
}

