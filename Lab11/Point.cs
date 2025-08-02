namespace Lab11{
    public class Point : Shape 
    {
        public int x;
        public int y;

        public Point(string Color, int x=0, int y=0) :
            base (Color)
        {
            this.x = x;
            this.y = y;
        }

         public override void Draw(){
            Console.WriteLine($"x={x}, y1={y}, color={Color}");
        }

        public void MoveBy(int x, int y){
            this.x += x;
            this.y += y;
        }
    }
}