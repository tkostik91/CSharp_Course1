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

namespace Lab10{
    public class Scene : IEnumerable, IScaleable {

        private Shape[] shapes;
        int Radius;

        const string fileName = @"../scene.json";

        public Scene()
        {
             shapes = new Shape[] {
                new Point("red"),
                new Circle("green")
            };
        }

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
        public void RestoreFromFile(){
            JObject[] objects = JsonConvert.DeserializeObject<JObject[]>(
                File.ReadAllText(fileName)); // JObject

            shapes = new Shape[objects.Length];

            for (int i = 0; i < objects.Length; i++)
            { 
                JObject o = objects[i];
                string typeName =  o.Property( "ShapeType").Value.ToString();
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type type = assembly.GetType(typeName);
                foreach (Type t in assembly.GetTypes())
                {
                    if(t.Name == typeName){
                        type = t;
                    }
                }
                shapes[i] = (Shape)o.ToObject(type);
            }

        }

    }
}