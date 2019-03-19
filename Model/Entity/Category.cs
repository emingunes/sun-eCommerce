using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Category : EntityBase
    {
        public int ParentID { get; set; } = 0; // default değeri = 0 girdim i mean ana kategori
        public string Name { get; set; }

        public bool IsActive { get; set; }

    }
}
