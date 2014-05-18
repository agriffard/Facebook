using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facebook.Models
{
    public class UserProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Link { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Timezone { get; set; }
        public string Locale { get; set; }
        public string Updated_Time { get; set; }
    }
}