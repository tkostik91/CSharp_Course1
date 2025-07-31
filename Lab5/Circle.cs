namespace Lab5{
    internal class Circle {
        public int x;
        public int y;
        private int radius;

        public int Radius
        {
            get => radius;
            set 
            {
                if(value > 0)
                    this.radius = value;
                else
                    throw new ArgumentException($"Введено значение <= 0");
            }
        }

        public Circle(int x, int y, int Radius){
            this.x = x;
            this.y = y;
            this.Radius = Radius;
        }

        public void Draw(){
            Console.WriteLine($"x={x}, y={y}, Radius={Radius}");
        }

        public void MoveBy(int x, int y){
            this.x += x;
            this.y += y;
        }

        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor);
        }
    }
}