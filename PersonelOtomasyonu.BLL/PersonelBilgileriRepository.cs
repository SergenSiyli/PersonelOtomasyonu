using PersonelOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOtomasyonu.BLL
{
   public class PersonelBilgileriRepository : IRepository<Personeller>
    {
        PersonelBilgisiEntities db = new PersonelBilgisiEntities();

        public void Ekle(Personeller item)
        {

            db.Personellers.Add(item);
            db.SaveChanges();

        }

        public void Guncelle(Personeller item)
        {
            Personeller guncelleme = db.Personellers.Find(item.PersonelID);
            db.Entry(guncelleme).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public Personeller IdIleSec(int itemID)
        {
            return db.Personellers.Find(itemID);
        }

        
        public void Sil(int itemId)
        {
            db.Personellers.Remove(db.Personellers.Find(itemId));
            db.SaveChanges();
        }

        public List<Personeller> TumunuSec()
        {
            return db.Personellers.ToList();
        }
        public List<Personeller> AramaYap(string arama)
        {
            return db.Personellers.Where(u => u.PersonelAdi == arama).ToList();

        }
    }
}
