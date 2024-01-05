namespace TipatChalav
{
    public class Baby
    {
        public int Id {  get; set; }
        public string Name { get; set; }  
        public DateTime DateBorn { get; set; }

       public Baby() { }

        public Baby(int id  , string name , DateTime dateBorn)
        {
            this.Id = id;
            this.Name = name;
            this.DateBorn = dateBorn;
            
        }
    }
}
