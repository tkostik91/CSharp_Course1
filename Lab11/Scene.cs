using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

using System.Text.Json;
using System.Threading.Tasks;

namespace Lab11{
    public class Scene : IEnumerable, IScaleable {

        private IList<Shape> shapes;
        int Radius;

        const string fileName = @"../scene.json";

        public Scene()
        {
             shapes = new List<Shape> {
                new Point("red"),
                new Circle("green")
            };
        }

        public void Clear() => shapes.Clear();

        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor);
        }

        public void DrawScene()
        {
            foreach(var shape in shapes){
                shape.Draw();
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Shape s in shapes){
                yield return s;
            }
        }

        public void SaveSceneToFile()
        {
            string json=JsonConvert.SerializeObject(shapes);
            File.WriteAllText(fileName, json);
        }

        public void Add(Shape obj){
            shapes.Add(obj);
        }
        // public void RestoreFromFile(){
        //     JObject[] objects = JsonConvert.DeserializeObject<JObject[]>(
        //         File.ReadAllText(fileName)); // JObject

        //     shapes = new Shape[objects.Length];

        //     for (int i = 0; i < objects.Length; i++)
        //     { 
        //         JObject o = objects[i];
        //         string typeName =  o.Property( "ShapeType").Value.ToString();
        //         Assembly assembly = Assembly.GetExecutingAssembly();
        //         Type type = assembly.GetType(typeName);
        //         foreach (Type t in assembly.GetTypes())
        //         {
        //             if(t.Name == typeName){
        //                 type = t;
        //             }
        //         }
        //         shapes[i] = (Shape)o.ToObject(type);
        //     }

        // }

    }
}