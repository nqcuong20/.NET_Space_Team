using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using NET_Tedu.Data.Interfaces;
using NET_Tedu.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET_Tedu.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
