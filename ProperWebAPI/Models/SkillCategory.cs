using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProperWebAPI.Models
{
    public class SkillCategory // Categories are a list of Industry Sub Tasks ex: Industry: Information Tecnology, Category: Aplication Development.
    {   [Key]
        public long Id { get; set;  }
        public string Name { get; set;  }
        public Industry Industry { get; set;  }
        public Icollection<Skill> Skills { get; set;  }
    }
}
