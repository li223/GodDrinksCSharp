namespace GodDrinksCSharp.Objects
{
    public class ThingAttribute
    {
        public string Nutrients;
        public int X = 1;
        public int Y = 1;
        public int Z = 1;

        public ThingAttribute(int x = 1, int y = 1, int z = 1)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Nutrients = "A lot";
        }
    }
}
