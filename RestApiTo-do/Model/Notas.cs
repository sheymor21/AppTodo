using System;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Users
    {
        [Key]
        public int usersId { get; set; }
        public DateTime fecha{get;set;}
        public String name { get; set; }
        public string username { get; set; }
        public String email { get; set; }
    }
}

