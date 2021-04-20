namespace ClassFoundation.Resources.Constructors
{
    public class ConstructorClass
    {
        public ConstructorClass() { }

        public ConstructorClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        // overload
        public ConstructorClass(int x)
        {
            X = x;
            Y = 10;
            S = "welcome";
        }

        public int X, Y;
        public string S;
    }
}
