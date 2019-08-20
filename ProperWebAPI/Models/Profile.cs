using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProperWebAPI.Models
{
    public class Profile : Identity
    {
        public ICollection<ProfileSkill> ProfileSkills { get; set;  }
        
    }
}
