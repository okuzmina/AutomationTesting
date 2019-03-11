namespace Lesson5
{
    class Rectangle
    {
        private int side1, side2;

        public int Side1 { get; set; }

        public int Side2 { get; set; }

        public int AreaCalculator(int side1, int side2)
        {
            int area = side1 * side2;
            return area;
        }

        public int PerimetrCalculator(int side1, int side2)
        {
            int perimetr = 2 * (side1 + side2);
            return perimetr;
        }
    }
}