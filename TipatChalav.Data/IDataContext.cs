using TipatChalav.Controllers;

namespace TipatChalav
{
    public interface IDataContext
    {
        List<Baby> Babies { get; set; }  
        List<Nurse> Nurses { get; set; }
    }
}
