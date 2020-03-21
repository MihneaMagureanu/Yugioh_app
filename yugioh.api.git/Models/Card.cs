using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardsAPI.Models
{
    public class Card
    {

        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(400)]
        public string Name { get; set; }
        [MaxLength(1500)]
        public string Text { get; set; }
        [Required]
        public string Ot { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public string Setcode { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Atk { get; set; }
        [Required]
        public string Def { get; set; }
        public string Level { get; set; }
        [Required]
        public string Race { get; set; }
        [Required]
        public string Attribute { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
