namespace Task2
{
    class CarParts
    {
        private int partCost;

        public int PartCost(string partName)
        {
            switch (partName)
            {
                case "wheel":
                    {
                        partCost = 4000;
                        return partCost;
                    }
                case "2wheel":
                    {
                        partCost = 8000;
                        return partCost;
                    }
                case "headlight":
                    {
                        partCost = 3000;
                        return partCost;
                    }
                case "bumper":
                    {
                        partCost = 2000;
                        return partCost;
                    }
                case "engine":
                    {
                        partCost = 50000;
                        return partCost;
                    }
                case "dashboard":
                    {
                        partCost = 6000;
                        return partCost;
                    }
                case "bearing":
                    {
                        partCost = 300;
                        return partCost;
                    }
            }

            return partCost;
        }
    }
}
