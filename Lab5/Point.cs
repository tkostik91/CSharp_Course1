namespace Lab5{
    internal class Point {
        public int x;
        public int y;

        public Point(int x, int y){
            this.x = x;
            this.y = y;
        }

         public void Draw(){
            Console.WriteLine($"x={x}, y1={y}");
        }

        public void MoveBy(int x, int y){
            this.x += x;
            this.y += y;
        }
    }
}