using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLbackup2.Model
{
    public class Lisans
    {
        public int Id { get; set; }
        public string LisansAnahtari { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        public int Durumu { get; set; }
        public int MusteriId { get; set; }
        public int ProgramId { get; set; }
        public DateTime SunucuTarihi { get; set; }
    }
}
