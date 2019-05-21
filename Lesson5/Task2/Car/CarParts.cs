namespace Task2
{
    class CarParts
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public CarParts(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
