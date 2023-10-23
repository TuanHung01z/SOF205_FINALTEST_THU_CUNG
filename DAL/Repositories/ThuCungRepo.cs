using DAL.IRepositories;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ThuCungRepo : IThuCungRepo
    {
        SOF205_FINAL_TESTContext _dbcontext;
        public ThuCungRepo()
        {
            _dbcontext =new SOF205_FINAL_TESTContext();
        }
        public bool AddTC(Thucung tc)
        {
            _dbcontext.Add(tc);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Thucung> GetAllTC()
        {
            return _dbcontext.Thucungs.ToList();
        }

        public bool RemoveTC(Thucung tc)
        {
            _dbcontext.Remove(tc);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool UpdateTC(Thucung tc)
        {
            _dbcontext.Update(tc);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
