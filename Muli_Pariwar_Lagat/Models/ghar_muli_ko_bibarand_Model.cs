using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Muli_Pariwar_Lagat.Models
{
    public class Muli
    {
        public int Id { get; set; }
        public int GharNum { get; set; }
        public int Woda { get; set; }
        public string sabik_G_B_S { get; set; }
        public int sabik_woda { get; set; }
        public string tol { get; set; }
        public string Naam { get; set; }
        public string Sikshhya { get; set; }
        public DateTime AddedDate { get; set; }
       
        public string Kaam { get; set; }
        public string ContactNum { get; set; }
        public DateTime JanmaMiti { get; set; }
        public string JanmaSthan { get; set; }
        public int NagarikId { get; set; }
        public DateTime NagarikJariDate { get; set; }
        public string NagarikJariJilla { get; set; }
    }
    public class MuliViewModel {
       

        public int Id { get; set; }
        [Required]
        [Display(Name = "घर नं.:")]
        public int GharNum { get; set; }
        [Required]
        [Display(Name = "वडाः")]
        public int Woda { get; set; }
        [Required]
        [Display(Name = "साविक गा.वि.स.:")]
        public string sabik_G_B_S { get; set; }
        [Required]
        [Display(Name = "साविक वडाः")]
        public int sabik_woda { get; set; }
        [Required]
        [Display(Name = "तोल:")]
        public string tol { get; set; }
        [Required]
        [Display(Name = "नाम:")]
        public string Naam { get; set; }
        [Required]
        [Display(Name = "शिक्षा:")]
        public string Sikshhya { get; set; }
        public DateTime AddedDate { get; set; }
        [Required]
        [Display(Name = "पेशा:")]
        public string Kaam { get; set; }
        [Required]
        [Display(Name = "सम्पर्क नं.:")]
        public string ContactNum { get; set; }
        [Required]
        [Display(Name = "जन्म मिति:")]
        public DateTime JanmaMiti { get; set; }
        [Required]
        [Display(Name = "जन्म स्थल:")]
        public string JanmaSthan { get; set; }
        [Required]
        [Display(Name = "नागरिता नं.:")]
        public int NagarikId { get; set; }
        [Required]
        [Display(Name = "जारी मितिः")]
        public DateTime NagarikJariDate { get; set; }
        [Required]
        [Display(Name = "जारी जिल्लाः")]
        public string NagarikJariJilla { get; set; }

    }
}