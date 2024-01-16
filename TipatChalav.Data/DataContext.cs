using System.Diagnostics;
using Tipa.Data.Repository;
using TipatChalav.Controllers;

namespace TipatChalav
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class DataContext : DataContextBase, IDataContext
    {
        public DataContext()
        {
            if(Babies == null)
                Babies = new List<Baby> { new Baby { Id = 1, Name = "default", DateBorn = DateTime.Now.Date} };
            else 
            if(Nurses == null)
                Nurses = new List<Nurse> { new Nurse { Id = 1, Name = "default" } };
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
