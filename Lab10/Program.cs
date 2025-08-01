using Newtonsoft.Json;
using System.Reflection;

namespace Lab10{
    internal class Program {

        const string fileName = @"../scene.json";
        static void Main(string[] args){

            Scene sc = new Scene();
            sc.DrawScene();
            sc.SaveSceneToFile();

            sc = new Scene();
            sc.RestoreFromFile();
            sc.DrawScene();

        }
    }
}

