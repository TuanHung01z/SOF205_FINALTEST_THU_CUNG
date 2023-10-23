using BUS.IServices;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThuCungService : IThuCungService
    {
        ThuCungRepo _repos;
        public ThuCungService()
        {
            _repos = new ThuCungRepo();
        }
        public string Add(Thucung tc)
        {
            if (_repos.AddTC(tc)==true)
            {
                return "Thêm thú cưng thành công";
            }
            else
            {
                return "Thêm thú cưng thất bại";
            }
        }

        public List<Thucung> GetAll(string search)
        {
            if (search == null)
            {
                return _repos.GetAllTC();
            }
            else
            {
                return _repos.GetAllTC().Where(x=>x.Ten.Contains(search)||x.Loai.Contains(search)).ToList();
            }
        }

        public string Remove(Thucung tc)
        {
            var clone = _repos.GetAllTC().FirstOrDefault(x => x.Id == tc.Id);
            if (_repos.RemoveTC(clone) == true)
            {
                return "Xoá thú cưng thành công";
            }
            else
            {
                return "Xoá thú cưng thất bại";
            }
        }

        public string Update(Thucung tc)
        {
            var clone = _repos.GetAllTC().FirstOrDefault(x => x.Id == tc.Id);
            clone.Ten=tc.Ten;
            clone.Loai=tc.Loai;
            clone.Maulong=tc.Maulong;
            clone.Tuoi=tc.Tuoi;
            if (_repos.UpdateTC(clone) == true)
            {
                return "Sửa thú cưng thành công";
            }
            else
            {
                return "Sửa thú cưng thất bại";
            }
        }
    }
}
