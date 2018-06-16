using System;

namespace WebApplication_Test1.Models
{
    public interface IPerson
    {
        DateTime BirthDate { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
    }
}