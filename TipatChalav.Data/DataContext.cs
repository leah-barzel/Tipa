using Tipa.Data.Repository;
namespace TipatChalav
{
    public class DataContext : IDataContext
    {
        public List<Baby> Babies { get; set; }

        public DataContext()
        {
           Babies = new List<Baby> { new Baby { Id = 1, Name = "default", DateBorn = DateTime.Now.Date} };
        }
        
        
    }
}
