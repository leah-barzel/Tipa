namespace Baby.Data.Repository
{
    public class BabyRepositoryBase
    {
        public List<Baby> List => _context.Babies;
    }
}