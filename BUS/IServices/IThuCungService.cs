using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IThuCungService
    {
        public string Add(Thucung tc);
        public string Update(Thucung tc);
        public string Remove(Thucung tc);
        List<Thucung> GetAll(string search);
    }
}
