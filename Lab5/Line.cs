namespace Lab5{
    internal class Line {
        public int x1;
        public int x2;
        public int y1;
        public int y2;

        public Line(int x1, int y1, int x2, int y2){
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Draw(){
            Console.WriteLine($"x1={x1}, x2={x2}, y1={y1}, y2={y2}");
        }

        public void MoveBy(int x1, int y1, int x2 = 0, int y2=0){
            this.x1 += x1;
            this.y1 += y1;
            this.x2 += x2;
            this.y2 += y2;
        }
    }
}