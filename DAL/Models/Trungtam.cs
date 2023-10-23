using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Trungtam
    {
        public Trungtam()
        {
            Cuahangs = new HashSet<Cuahang>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Cuahang> Cuahangs { get; set; }
    }
}
