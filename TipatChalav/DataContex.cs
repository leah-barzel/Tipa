namespace TipatChalav
{
    public class DataContex : IDataContext
    {
        public List<Baby> Babies { get; set; }

        public DataContex()
        {
           Babies = new List<Baby> { new Baby { Id = 1, Name = "default", DateBorn = DateTime.Now.Date} };
        }
        
        
    }
}
