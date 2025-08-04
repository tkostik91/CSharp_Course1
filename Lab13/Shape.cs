using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13{
    public abstract class Shape {
        public string Color {get; set;}

        public string ShapeType { get; init; }

        public Shape(string Color){
            this.Color = Color;
            ShapeType = this.GetType().Name;
        }

        public virtual void Draw(){
            Console.WriteLine($"Color={Color}");
        }

    }
}