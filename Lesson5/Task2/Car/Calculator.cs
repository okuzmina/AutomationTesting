namespace Task2
{
    class Calculator
    {
        public static int Calculate(Car car)
        {
            int summary = 0;
            for (int i = 0; i < car.parts.Length; i++)
            {
                summary += car.parts[i].price;
            }
            return summary;
        }
    }
}
