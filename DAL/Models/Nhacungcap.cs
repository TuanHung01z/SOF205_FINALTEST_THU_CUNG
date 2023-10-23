using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string? Diachi { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
