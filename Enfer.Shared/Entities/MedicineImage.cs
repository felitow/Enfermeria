using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enfer.Shared.Entities
{
    public class MedicineImage
    {

        public int Id { get; set; }

        public Medicine Medicine { get; set; } = null!;

        public int MedicineId { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; } = null!;




    }
}
