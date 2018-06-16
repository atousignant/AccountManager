using SQLite;

namespace WebApplication_Test1.Models
{
    public class Department
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}