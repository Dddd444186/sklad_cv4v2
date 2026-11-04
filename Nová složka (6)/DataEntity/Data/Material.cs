using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.Data
{
    [AddINotifyPropertyChangedInterface]
    [Table("MerneJednotky")]
    public class Material
    {
        public int MaterialId { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; } = string.Empty;    

        public int MnozPoj { get; set; } = 0;

        public int MnozdoPal { get; set; } = 0;

        [Column (TypeName ="date")]
        public DateTime Datum { get; set; } = DateTime.Now;
        
        public string Komentar { get; set; } = string.Empty;

        public int MernaJednotkaId { get; set; }

        [ForeignKey(nameof(MernaJednotkaId))]
        public virtual required MernaJednotka MernaJednotka { get; set; } = null!;
    } 
}
