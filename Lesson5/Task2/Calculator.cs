namespace Task2
{
    class Calculator
    {
        private int summary;
        public int Summary(string[] parts)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                CarParts sumPart = new CarParts();
                summary = summary + sumPart.PartCost(parts[i]);
            }
            return summary;
        }
    }
}
