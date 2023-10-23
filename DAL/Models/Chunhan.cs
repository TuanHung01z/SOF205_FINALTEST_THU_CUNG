using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Chunhan
    {
        public Chunhan()
        {
            Thucungs = new HashSet<Thucung>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Thucung> Thucungs { get; set; }
    }
}
