using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelOtomasyonu.DAL;

namespace PersonelOtomasyonu.BLL
{
    public class Kullanici
 
    {
        PersonelBilgisiEntities db = new PersonelBilgisiEntities();

        public bool kullanicigirisi(string username,string pass)
        {
            bool degisken;
            if (db.KullanıcıAdı.Any(u => u.KullaniciAdi == username))
            {
                degisken = true;
            }
            else
            {
                degisken = false;
            }
            return degisken;

        }
    }
}
