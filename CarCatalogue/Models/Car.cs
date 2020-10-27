using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarCatalogue.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        [DisplayName("Car name")]
        public string Name { get; set; }

        public string Descritption { get; set; }

        [Display(Name = "Car producer")]
        public Producer Producer { get; set; }

        [Required]
        public int Year { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }

    public enum Producer
    {
        VW = 10, Audi = 20, AlfaRomeo = 30
    }
}
