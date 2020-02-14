using System;
namespace Vavous.API.Database.Entities {
    public class CompanyOwnerJoin {
        public User User { get; set; }
        public Company Company { get; set; }
    }
}
