using Application.Domain;

namespace Application.Dto
{
    public class HouseModelDto
    {
        public double Value { get; set; }
        public double Area { get; set; }
        public TypeHouse Type { get; set; }
        public int Rooms { get; set; }
        public bool Garage { get; set; }
        public bool Energy { get; set; }
        public bool Water { get; set; }
        public string Description { get; set; }
        public AddressModelDto Address { get; set; }
    }
}
