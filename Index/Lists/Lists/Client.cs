namespace Lists
{
    public class Client
    {
        public string Name { get; set; }
        public bool Flag { get; set; }

        public Client(string name, bool flag)
        {
            Name = name;
            Flag = flag;
        }
    }
}