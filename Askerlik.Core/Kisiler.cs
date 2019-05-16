using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Askerlik.Core
{
    [Table("Kisiler")]
    public class Kisiler
    {
        [Key]
        public int KisiId { get; set; }
        [Required]
        [Display(Name = "Tc Kimlik Numarası")]
        public long TcKimlikNo { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Ad soyad")]
        public string Adi { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DogumTarihi { get; set; }

        [Display(Name = "Askerlik Yapmışsa True değilse false")]
        public bool AskerlikYaptiMi { get; set; }

        [Display(Name = "Kişi Hayatta ise True")]
        public bool HayattaMi { get; set; }
    }
}
