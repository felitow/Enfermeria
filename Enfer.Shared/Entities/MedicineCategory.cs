using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enfer.Shared.Entities
{
    public class MedicineCategory
    {

        public int Id { get; set; }

        public Medicine Medicine { get; set; } = null!;

        public int MedicineId { get; set; }

        public Category Category { get; set; } = null!;

        public int CategoryId { get; set; }


    }
}
