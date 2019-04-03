namespace Task2
{
    class Car
    {
        public string name { get; set; }
        public CarParts[] parts { get; set; }

        public Car(string name, CarParts[] parts)
        {
            this.name = name;
            this.parts = parts;
        }
    }
}
