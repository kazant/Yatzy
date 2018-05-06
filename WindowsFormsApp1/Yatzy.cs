using System;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApp1.YatzyKategoriBeregner;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const int CHECKBOXNUMMEREN = 0;
        private const int CHECKBOXNUMMERTO = 1;
        private const int CHECKBOXNUMMERTRE = 2;
        private const int CHECKBOXNUMMERFIRE = 3;
        private const int CHECKBOXNUMMERFEM = 4;

        private String[] bildepath = { @"..\Image\1.jpg", @"..\Image\2.jpg", @"..\Image\3.jpg", @"..\Image\4.jpg", @"..\Image\5.jpg", @"..\Image\6.jpg" };
        private int teller = 0;
        private int[] terninger = new int[5];
        private int[] sum = new int[14];
        private int totalsum = 0;
        private Random r = new Random();
        private YatzyPoengBeregner yatzyPoengBeregner = new YatzyPoengBeregner();
        private string kast = "";
       
        public Form1()
        {
            InitializeComponent();

        }

        private void Kast_Click(object sender, EventArgs e)
        {
            kast = "";

            //stop spiller å kaste mer enn 3 ganger på 1 runde
            if (teller >= 2) {
                btnKast.Enabled = false;
            }

            //ikke kast terninger som er på "hold"
            if (chBoxHold1.Checked == false)
            {
                terninger[CHECKBOXNUMMEREN] = r.Next(1, 7);
            }
            if (chBoxHold2.Checked == false)
            {
                terninger[CHECKBOXNUMMERTO] = r.Next(1, 7);
            }
            if (chBoxHold3.Checked == false)
            {
                terninger[CHECKBOXNUMMERTRE] = r.Next(1, 7);
            }
            if (chBoxHold4.Checked == false)
            {
                terninger[CHECKBOXNUMMERFIRE] = r.Next(1, 7);
            }
            if (chBoxHold5.Checked == false)
            {
                terninger[CHECKBOXNUMMERFEM] = r.Next(1, 7);
            }

            //lag kast string
            for (int i = 0; i < terninger.Length; i++)
            {
                kast += terninger[i] + ",";
            }

            //sett bilder
            picTerning1.Image = Image.FromFile(bildepath[terninger[0] - 1]);
            picTerning2.Image = Image.FromFile(bildepath[terninger[1] - 1]);
            picTerning3.Image = Image.FromFile(bildepath[terninger[2] - 1]);
            picTerning4.Image = Image.FromFile(bildepath[terninger[3] - 1]);
            picTerning5.Image = Image.FromFile(bildepath[terninger[4] - 1]);

            teller++;
            totalsum = 0;
            CheckboxEnabler();
        }

        public void uncheckCheckbox() {
            chBoxHold1.Checked = false;
            chBoxHold2.Checked = false;
            chBoxHold3.Checked = false;
            chBoxHold4.Checked = false;
            chBoxHold5.Checked = false;
            
            chBoxHold1.Enabled = false;
            chBoxHold2.Enabled = false;
            chBoxHold3.Enabled = false;
            chBoxHold4.Enabled = false;
            chBoxHold5.Enabled = false;
        }
        public void CheckboxEnabler()
        {
            chBoxHold1.Enabled = true;
            chBoxHold2.Enabled = true;
            chBoxHold3.Enabled = true;
            chBoxHold4.Enabled = true;
            chBoxHold5.Enabled = true;
        }

            public void BeregnTotalSum() {

            for (int i = 0; i < sum.Length; i++)
            {
                totalsum += sum[i];
                lblSumTotal.Text = totalsum.ToString();
            }
        }


        

        //reset for teller og enable på kast knapp når brukeren har valgt hvor en vil sette poengene sine
        public void knappOgTellerReset()
        {
            teller = 0;
            btnKast.Enabled = true;

        }

       
        private void btnEnere_Click(object sender, EventArgs e)
        {
            if (teller != 0) { 
            sum[0] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Enere);
            lblSumEnere.Text = sum[0].ToString();
            BeregnTotalSum();
            knappOgTellerReset();
            btnEnere.Enabled = false;
            uncheckCheckbox();
            }

        }

        private void btnToere_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[1] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Toere);
                lblSumToere.Text = sum[1].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnToere.Enabled = false;
                uncheckCheckbox();
                
            }
        }


        private void btnTreere_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[2] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Treere);
                lblSumTreere.Text = sum[2].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnTreere.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnFirere_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[3] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Firere);
                lblSumFirere.Text = sum[3].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnFirere.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnFemmere_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[4] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Femmere);
                lblSumFemmere.Text = sum[4].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnFemmere.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnSeksere_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[5] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Seksere);
                lblSumSeksere.Text = sum[5].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnSeksere.Enabled = false;
                uncheckCheckbox();
            }
        }
      

        private void btnPar_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[6] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Par);
                lblSumPar.Text = sum[6].ToString();
                BeregnTotalSum();
                btnPar.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnToPar_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[7] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.ToPar);
                lblSumToPar.Text = sum[7].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnToPar.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnTreLike_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[8] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.TreLike);
                lblSumTreLike.Text = sum[8].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnTreLike.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnFireLike_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[9] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.FireLike);
                lblSumFireLike.Text = sum[9].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnFireLike.Enabled = false;
                uncheckCheckbox();
            }
        }
        
        private void btnLitenStraight_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[10] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.LitenStraigt);
                lblSumLitenStraight.Text = sum[10].ToString();
                BeregnTotalSum();
                btnLitenStraight.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnStorStraight_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[11] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.StorStraight);
                lblSumStorStraight.Text = sum[11].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnStorStraight.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnFulltHus_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[12] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.FulltHus);
                lblSumFullthus.Text = sum[12].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnFulltHus.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnSjanse_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[13] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Sjanse);
                lblSumSjanse.Text = sum[13].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnSjanse.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnYatzy_Click(object sender, EventArgs e)
        {
            if (teller != 0)
            {
                sum[14] = yatzyPoengBeregner.BeregnPoeng(kast, Kategori.Yatzy);
                lblSumYatzy.Text = sum[14].ToString();
                BeregnTotalSum();
                knappOgTellerReset();
                btnYatzy.Enabled = false;
                uncheckCheckbox();
            }
        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            Resultat resultat = yatzyPoengBeregner.Max(kast);
            lblKategoriGetMax.Text = resultat.kategori.ToString();
            lblSumGetMax.Text = resultat.sum.ToString();
        }
    }
}

        


