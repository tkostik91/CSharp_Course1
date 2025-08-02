using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11{
    internal class Circle:Shape, IScaleable {
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

        public Circle(string Color, int x=0, int y=0, int Radius=1) :
        base (Color){
            this.x = x;
            this.y = y;
            this.Radius = Radius;
        }

        public override void Draw(){
            Console.WriteLine($"x={x}, y={y}, Radius={Radius}, Color={Color}");
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