using Satranc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancOyunu
{
    public partial class Form1 : Form
    {
        Tahta satrancTahtasi;

        public Form1()
        {
            InitializeComponent();
            satrancTahtasi = new Tahta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowTahta.Size = new Size(Tahta.KareBoyutu * 8, Tahta.KareBoyutu * 8);
            cmbTasTipleri.DataSource = Enum.GetValues(typeof(TasTipleri));
            TahtayiEkranaCiz();
        }

        private void TahtayiEkranaCiz()
        {
            flowTahta.Controls.Clear();
            Panel pnlKare = null;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pnlKare = new Panel();
                    pnlKare.Name = "pnlKare" + i + j;
                    pnlKare.Width = Tahta.KareBoyutu;
                    pnlKare.Height = Tahta.KareBoyutu;
                    pnlKare.Left = i * Tahta.KareBoyutu;
                    pnlKare.Top = j * Tahta.KareBoyutu;
                    if (satrancTahtasi.Kareler[i, j].UzerindeTasVarMi())
                    {
                        string resim = satrancTahtasi.TasResminiGetir(i,j);
                        pnlKare.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + resim);
                        pnlKare.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        pnlKare.BackColor = satrancTahtasi.Kareler[i, j].Renk == Renkler.Siyah ? Color.Black : Color.White;
                    }
                    flowTahta.Controls.Add(pnlKare);
                }
            }
        }

        private void btnTasEkle_Click(object sender, EventArgs e)
        {
            TasTipleri tasTipi = (TasTipleri)cmbTasTipleri.SelectedItem;
            satrancTahtasi.TasUret(tasTipi);
            TahtayiEkranaCiz();
        }

        private void btnTaslariOynat_Click(object sender, EventArgs e)
        {
            //if (timer1.Enabled)
            //{
            //    timer1.Stop();
            //}
            //else
            //{
            //    timer1.Start();
            //}
            satrancTahtasi.TaslariHareketEttir();
            TahtayiEkranaCiz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            satrancTahtasi.TaslariHareketEttir();
            TahtayiEkranaCiz();
        }
    }
}
