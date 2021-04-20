namespace ClassFoundation.Resources.Constructors
{
    class ConstructorClassThis
    {

        public ConstructorClassThis() {
            S = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
        }

        public ConstructorClassThis(int x, int y) : this ()
        {
            X = x;
            Y = y;
        }

        public ConstructorClassThis(int x, int y, string s) : this (x, y)
        {
            S = s;
        }

        // overload
        public ConstructorClassThis(int X = 0)
        {
            this.X = X;
            Y = 0;
            S = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
        }

        public int X, Y;
        public string S;
    }
}
