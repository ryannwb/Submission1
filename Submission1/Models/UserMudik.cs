using System;
namespace Submission1.Models
{
    public class UserMudik
    {
        public string Nama { get; set; }
        public string JobPosition { get; set; }
        public bool IsMudik { get; set; }
        public string Wilayah { get; set; }
        public DateTime TanggalBerangkat { get; set; }
        public UserMudik()
        {

        }

        public UserMudik(string nama, string jobPosition, bool isMudik, string wilayah, DateTime tanggalBerangkat)
        {
            Nama = nama;
            JobPosition = jobPosition;
            IsMudik = isMudik;
            Wilayah = wilayah;
            TanggalBerangkat = tanggalBerangkat;
        }
    }
}
