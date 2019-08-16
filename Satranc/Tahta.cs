using SatrancTas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satranc
{
    public class Tahta
    {
        public const int KareBoyutu = 50;
        private Kare[,] karelerim;

        public Tahta()
        {
            karelerim = new Kare[8, 8];
            KareleriOlustur();
        }

        public Kare[,] Kareler
        {
            get
            {
                return karelerim;
            }
        }

        public List<Tas> Taslarim { get { return Taslar.TaslarListesi; } }

        void KareleriOlustur()
        {
            Kare kare;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        kare = new Kare(Renkler.Siyah, new Konum(i, j));
                    }
                    else
                    {
                        kare = new Kare(Renkler.Beyaz, new Konum(i, j));
                    }
                    karelerim[i, j] = kare;
                }
            }
        }

        Kare BosKareGetir()
        {
            Kare bosKare = null;

            if (BosKareVarMi())
            {
                Random rnd = new Random();
                do
                {
                    int x = rnd.Next(8);
                    int y = rnd.Next(8);
                    bosKare = this.Kareler[x, y];
                } while (bosKare.UzerindeTasVarMi());
            }

            return bosKare;
        }

        bool BosKareVarMi()
        {
            return Taslar.TaslarListesi.Count < 64;
        }

        public void TasUret(TasTipleri tasTipi)
        {
            Kare bosKare = BosKareGetir();
            if (bosKare == null)
            {
                throw new Exception("Tahta doldu");
            }

            Tas eklenecekTas = null;
            switch (tasTipi)
            {
                case TasTipleri.At:
                    eklenecekTas = new At();
                    break;
                case TasTipleri.Fil:
                    eklenecekTas = new Fil();
                    break;
                case TasTipleri.Kale:
                    eklenecekTas = new Kale();
                    break;
            }

            eklenecekTas.Lokasyon = bosKare.Lokasyon;
            Taslar.TasEkle(eklenecekTas);
        }

        public void TaslariHareketEttir()
        {
            List<Konum> goturelebilecekYerler = new List<Konum>();
            Random rnd = new Random();
            foreach (Tas item in Taslarim)
            {
                bool sonuc = TasHareketEdebilirMi(item, ref goturelebilecekYerler);
                if (sonuc)
                {
                    Konum yeniKonum = goturelebilecekYerler[rnd.Next(goturelebilecekYerler.Count)];
                    item.Lokasyon = yeniKonum;
                    goturelebilecekYerler.Clear();
                }
            }
        }

        bool TasHareketEdebilirMi(Tas t, ref List<Konum> gidebilecegiYerler)
        {
            Kare kare = null;
            foreach (Konum item in t.GidebilecegiYerler)
            {
                if (item.X < 0 || item.Y < 0 || item.X > 7 || item.Y > 7)
                {
                    continue;
                }
                kare = KonumaGoreKareGetir(item);
                if (!kare.UzerindeTasVarMi())
                {
                    gidebilecegiYerler.Add(item);
                }
            }

            return gidebilecegiYerler.Count >= 0;
        }

        Kare KonumaGoreKareGetir(Konum k)
        {
            return Kareler[k.X, k.Y];
        }

        public string TasResminiGetir(int x, int y)
        {
            Tas istenenTas = null;
            foreach (Tas item in this.Taslarim)
            {
                if (item.Lokasyon.X == x && item.Lokasyon.Y == y)
                {
                    istenenTas = item;
                    break;
                }
            }

            return istenenTas.Resim;
        }
    }
}
