namespace Application.Commands.Index
{
    public class ToggleModel
    {
        public ToggleModel(int id, string name, bool valid)
        {
            Id = id;
            Name = name;
            Valid = valid;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Valid { get; set; }
    }
}
