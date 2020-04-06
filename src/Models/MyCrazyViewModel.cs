using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.StateManager.Models
{
    public class MyCrazyViewModel
    {
        [Required]
       
        [StringLength(25, ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }
        public string Description { get; set; }
        public string PetName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
