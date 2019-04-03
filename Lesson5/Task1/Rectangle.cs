namespace Lesson5
{
    class Rectangle
    {
        private int Side1 { get; set; }

        private int Side2 { get; set; }

        public Rectangle(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public int AreaCalculator()
        {
            int area = Side1 * Side2;
            return area;
        }

        public int PerimetrCalculator()
        {
            int perimetr = 2 * (Side1 + Side2);
            return perimetr;
        }
    }
}