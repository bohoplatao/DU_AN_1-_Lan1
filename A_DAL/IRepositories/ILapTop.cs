using A_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ILapTop
    {
        public List<LapTop> GetAllLapTop(string name);
        List<LapTop> GetPhanLoaiLapTop(string name);

        public bool CreateLapTop(LapTop lt);
        public bool UpdateLapTop(LapTop lt);
        public bool DeleteLapTop(LapTop lt);
    }
}
