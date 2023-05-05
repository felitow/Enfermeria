using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enfer.Shared.Entities
{
    public class Category
    {

        public int Id { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public ICollection<MedicineCategory>? MedicineCategories { get; set; }

        [Display(Name = "Productos")]
        public int MedicineCategoriesNumber => MedicineCategories == null ? 0 : MedicineCategories.Count;


    }
}
