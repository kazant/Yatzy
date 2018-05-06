using System;
using static WindowsFormsApp1.YatzyKategoriBeregner;

namespace WindowsFormsApp1
{
    public class YatzyPoengBeregner
    {

        public int BeregnPoeng(string kast, Kategori kategori) {

            YatzyKategoriBeregner resultat = new YatzyKategoriBeregner();
            int sum = 0;
            string[] cleanKast = splitString(kast);
            switch (kategori)
            {
                case Kategori.Enere:
                    {
                       return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Toere:
                    {
                        return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Treere:
                    {
                        return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Firere:
                    {
                        return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Femmere:
                    {
                        return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Seksere:
                    {
                        return sum = resultat.GetPoeng(kategori, cleanKast);
                    }
                case Kategori.Par:
                    {
                        return sum = resultat.getPar(cleanKast);
                    }
                case Kategori.ToPar:
                    {
                        return sum = resultat.getToPar(cleanKast);
                    }
                case Kategori.TreLike:
                    {
                        return sum = resultat.getTreLike(cleanKast);
                    }
                case Kategori.FireLike:
                    {
                        return sum = resultat.getFireLike(cleanKast);
                    }
                case Kategori.LitenStraigt:
                    {
                        return sum = resultat.getLitenStraight(cleanKast);
                    }
                case Kategori.StorStraight:
                    {
                        return sum = resultat.getStorStraight(cleanKast);
                    }
                case Kategori.FulltHus:
                    {
                        return sum = resultat.getFulltHus(cleanKast);
                    }
                case Kategori.Sjanse:
                    {
                        return sum = resultat.getSjanse(cleanKast);
                    }
                case Kategori.Yatzy:
                    {
                       return sum = resultat.getYatzy(cleanKast);
                    }

            }
            return sum;
        }

        public string[] splitString(string kast)
        {
            string[] kastArray = kast.Split(',');
            Array.Resize(ref kastArray, kastArray.Length - 1);
            return kastArray;
        }


        public Resultat Max(string kast) {

            int etResultat;
            int sum = 0;
            int kategorinr = 0;
            
            for (int i = 0; i < 14; i++)
            {
                etResultat =  BeregnPoeng(kast, (Kategori)i + 1);
                if (etResultat > sum) {
                    sum = etResultat;
                    kategorinr = i+1;
                }
            }
            Resultat resultat = new Resultat();
            resultat.sum = sum;
            resultat.kategori = (Kategori)kategorinr;
            return resultat;
        }

            
    }
}
