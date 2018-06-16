using SQLite;

namespace WebApplication_Test1.Models
{
    public class Position
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PositionName { get; set; }
    }
}