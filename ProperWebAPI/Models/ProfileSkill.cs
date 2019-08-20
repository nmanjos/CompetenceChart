using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProperWebAPI.Models
{
    public class ProfileSkill
    {
        [Key]
        public long  Id { get; set; }
        public Profile Profile { get; set;  }
        public Skill Skill { get; set;  }
        public SkillLevel SkillLevel { get; set;}
    }
}
