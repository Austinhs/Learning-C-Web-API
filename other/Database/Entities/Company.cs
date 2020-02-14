using System;

namespace Vavous.API.Database.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
