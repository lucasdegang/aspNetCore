namespace ClassFoundation.Resources.Properties
{
    public class AutoProperties
    {
        public AutoProperties()
        {
            X = 0;
        }

        public void UpdateX(int x)
        {
            X = x;
        }

        // Using Get propertie: obj.Y;
        // Using Set propertie: obj.Y = 10;
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }

        // Using Get propertie: obj.X;
        // Using Set propertie: obj.UpdateX(10);
        public int X { get; private set; }
        
        private int _y;
    }
}
