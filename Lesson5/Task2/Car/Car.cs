namespace Task2
{
    class Car
    {
        public string Name { get; set; }
        public CarParts[] Parts { get; set; }

        public Car(string name, CarParts[] parts)
        {
            this.Name = name;
            this.Parts = parts;
        }
    }
}
