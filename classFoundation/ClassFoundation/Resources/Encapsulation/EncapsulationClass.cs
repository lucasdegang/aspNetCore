namespace ClassFoundation.Resources.Encapsulation
{
    public class EncapsulationClass
    {
        public EncapsulationClass() { }
        
        public EncapsulationClass(int x, int y, string s)
        {
            _x = x;
            _y = y;
            _s = s;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public string GetS()
        {
            return _s;
        }

        public void SetX(string x)
        {
            _x = x;
        }
        
        public void SetY(string y)
        {
            _y = y;
        }

        public void SetS(string s)
        {
            _s = s;
        }

        // Encapsulation is make some protection of atributes in class
        // private - only accessible for the this class/ object
        private int _x, _y;
        private string _s;
    }
}
