namespace Application.Commands
{
    public class BaseModel
    {
        public BaseModel(int id)
        {
            Id = id;
            this.CreationDate = DateTime.Now;
        }

        public int Id { get; set; }
        private DateTime CreationDate { get; set; }
    }
}
