using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9{
    public class Scene : IEnumerable, IScaleable {

        Shape[] shapes;
        int Radius;

        public Scene(Shape[]shapes){
            this.shapes = shapes;
        }

        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor);
        }

        public void DrawScene(Shape[]scene)
        {
            foreach(Shape s in scene){
                s.Draw();
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Shape s in shapes){
                yield return s;
            }
        }

    }
}