using System;

namespace WindowsFormsApp1
{
    public class YatzyKategoriBeregner
    {

        public enum Kategori:int { Enere = 1, Toere, Treere, Firere, Femmere, Seksere, Par, ToPar, TreLike, FireLike, LitenStraigt, StorStraight, FulltHus, Sjanse, Yatzy };

        public int[] KategoriserTerninger( string[] kast) {
            int[] nyKastint = new int[6];
      
            for (int i = 0; i < kast.Length; i++)
            {

                if (Int32.Parse(kast[i]) == 1)
                {
                    nyKastint[0]++;
                }
                if (Int32.Parse(kast[i]) == 2)
                {
                    nyKastint[1]++;
                }
                if (Int32.Parse(kast[i]) == 3)
                {
                    nyKastint[2]++;
                }
                if (Int32.Parse(kast[i]) == 4)
                {
                    nyKastint[3]++;
                }
                if (Int32.Parse(kast[i]) == 5)
                {
                    nyKastint[4]++;
                }
                if (Int32.Parse(kast[i]) == 6)
                {
                    nyKastint[5]++;
                }
            }
            return nyKastint;
            }


        public int GetPoeng(Kategori kategori, string[] kast) {
            int sum = 0;

            for (int i = 0; i < kast.Length; i++)
            {
                if (Int32.Parse(kast[i]) == (int)kategori)
                {
                    sum += Int32.Parse(kast[i]);
                }
            }          
            return sum;
        }



        public int getPar(string[] kast)
        {
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if(terninger[i] >= 2)
                {
                    sum = 2 * (i + 1);         
                }
            }
            return sum;
        }

        public int getToPar(string[] kast)
        {       
            int teller = 0;
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if (terninger[i] >= 2)
                {
                    sum += 2 * (i + 1);
                    teller++;
                }
            }
            if (teller == 2) {
                return sum;
            }else return 0;
        }


        public int getTreLike(string[] kast)
        {
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if (terninger[i] >= 3)
                {
                    sum = 3 * (i + 1);
                }                
            }
            return sum;
        }

        public int getFireLike(string[] kast)
        {
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if (terninger[i] >= 4)
                {
                    sum = 4 * (i + 1);
                }
            }
            return sum;
        }


        public int getLitenStraight(string[] kast) {
            int sum = 0;
            int teller = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length -1; i++)
            {
                if (terninger[i] == 1)
                {
                    teller++;
                }
            }
            if (teller == 5)
            {
                sum = 1 + 2 + 3 + 4 + 5;
            }
            return sum;         
        }

        public int getStorStraight(string[] kast)
        {
            int sum = 0;
            int teller = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 1; i < terninger.Length; i++)
            {
                if (terninger[i] == 1)
                {
                    teller++;
                }
            }
            if (teller == 5)
            {
                sum = 2 + 3 + 4 + 5 + 6;
            }
            return sum;
        }

        public int getFulltHus(string[] kast)
        {
            int sum = 0;
            int teller1 = 0;
            int teller2 = 0;
            int terningVerdiVedTreLike = 0;
            int terningverdiVedToLike = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if (terninger[i] == 3)
                {
                    teller1++;
                    terningVerdiVedTreLike = i+1;
                }
                else if(terninger[i] == 2)
                {
                    terningverdiVedToLike = i+1;
                    teller2++;
                }
                
            }
            if (teller1 == 1 && teller2 ==1)
            {
                sum = (terningVerdiVedTreLike * 3) + (terningverdiVedToLike * 2);
            }
            return sum;
        }
            

        public int getSjanse(string[] kast)
        {
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                sum += terninger[i] * (i+1);
            }
            return sum;
        }

        public int getYatzy(string[] kast)
        {
            int sum = 0;
            var terninger = KategoriserTerninger(kast);

            for (int i = 0; i < terninger.Length; i++)
            {
                if (terninger[i] == 5)
                {
                    sum = 50;
                }
            }
            return sum;          
        }
    }
}
