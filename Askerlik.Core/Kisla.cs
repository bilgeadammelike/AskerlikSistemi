using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askerlik.Core
{
    [Table("Kisla")]
    public class Kisla
    {
        [Key]
        public int KislaId { get; set; }
        [StringLength(60)]
        public string Adi { get; set; }

        [Required]
        public int Kapasite { get; set; }

        [Required]
        [Display(Name = "Öncelikli Asker Gönderimi Yapılma Durumu")]
        public int Oncelik { get; set; }
        
        public int? UstKategoriId { get; set; }

        public bool AktifMi { get; set; }
        
        /*
         * Ilişkiler
         */

        [ForeignKey("UstKategoriId")]
        public virtual ICollection<Kisla> FK_KislaId { get; set; }
    }
}
