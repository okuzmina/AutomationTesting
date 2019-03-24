using System;

namespace Task2
{
    class Car
    {
        private string name;
        private string[] parts;
        Calculator cost = null;

        public string Name { set; get; }

        public string[] Parts(string name)
        {
            switch (name)
            {
                case "kia":
                    {
                        string[] parts = { "wheel", "headlight", "bumper", "engine" };
                        return parts;
                    }
                case "vw":
                    {
                        string[] parts = { "2wheels", "engine", "gearbox", "bearing" };
                        return parts;
                    }
                case "opel":
                    {
                        string[] parts = { "wheel", "dashboard", "bumper" };
                        return parts;
                    }
                default:
                    {
                        Console.WriteLine("There are no parts for entered car.");
                        break;
                    }
            }

            return parts;
        }

        void InitialzeCost()
        {
            this.cost = new Calculator();
        }

        public int Cost(string[] parts)
        {
            InitialzeCost();
            int sum;

            sum = this.cost.Summary(parts);

            return sum;
        }
    }
}
