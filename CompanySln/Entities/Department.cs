namespace CompanySln.Entities
{
    public class Department
    {
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
