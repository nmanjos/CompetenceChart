using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProperWebAPI.Models
{
    public class Skill
    {
        [Key]
        public long  Id { get; set; }
        public string Name { get; set;  }
        public string Description { get; set;  }
        public ICollection<ProfileSKill> ProfileSKills { get; set;}
    }
}
