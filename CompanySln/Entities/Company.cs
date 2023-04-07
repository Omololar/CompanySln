namespace CompanySln.Entities
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
