using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IThuCungRepo
    {
        public bool AddTC(Thucung tc);
        public bool UpdateTC(Thucung tc);
        public bool RemoveTC(Thucung tc);
        public List<Thucung> GetAllTC();
    }
}
