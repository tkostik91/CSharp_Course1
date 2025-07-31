namespace Lab9{
    public abstract class Shape {
        public string Color;

        public Shape(string Color){
            this.Color = Color;
        }

        public virtual void Draw(){
            Console.WriteLine($"Color={Color}");
        }

    }
}