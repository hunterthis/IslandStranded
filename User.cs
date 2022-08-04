using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandStranded
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        //[Index(IsUnique = true)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required] // need to make default value 0
        public int CurrentStoryEventValue { get; set; }

    }
}
