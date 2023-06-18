using PiggyBank.Abstract;
using PiggyBank.Concrete;
using PiggyBank.Exception_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class KumbaraFRM : Form
    {
        #region Fields

        private readonly List<KagitPara> KagitParalar;
        private readonly List<BozukPara> BozukParalar;
        private readonly List<Para> KumbaradakiKagitParalar = new List<Para>();
        private readonly List<Para> KumbaradakiBozukParalar = new List<Para>();

        Kumbara kumbara;
        Para secilenPara;
        double toplamFazlaHacim = 0;
        double toplamHacim = 0;
        bool katlandiMi = false;
        double minToplamHacim = 0;
        double birikenTutar = 0;
        double katlanmisParaHacmi = 0;
        int kumbaraKirilmaSayisi = 0;

        #endregion

        #region Constructor

        public KumbaraFRM()
        {
            InitializeComponent();

            if (KagitParalar == null)
            {
                KagitParalar = new List<KagitPara>();
            }

            if (BozukParalar == null)
            {
                BozukParalar = new List<BozukPara>();
            }

            if (kumbara == null)
            {
                kumbara = new Kumbara(75000);
            }
        }

        #endregion

        #region Methods

        private void KumbaraFRM_Load(object sender, EventArgs e)
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Deger = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Deger = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Deger = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Deger = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Deger = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Deger = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Deger = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Deger = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Deger = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Deger = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Deger = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Deger = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Seçiniz");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Ad);
            }
            cmbKagitPara.SelectedIndex = 0;

            cmbBozukPara.Items.Add("Seçiniz");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Ad);
            }
            cmbBozukPara.SelectedIndex = 0;

        }

        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara;
            if (cmbKagitPara.SelectedIndex > 0)
            {
                cmbBozukPara.Enabled = false;
                atilacakPara = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
            else
            {
                cmbBozukPara.Enabled = true;
            }
        }

        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            string atilacakPara;
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacakPara = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacakPara == item.Ad)
                    {
                        secilenPara = item;
                    }
                }
            }
            else
            {
                cmbKagitPara.Enabled = true;
            }
        }

        private void btnParaAt_Click(object sender, EventArgs e)
        {


            try
            {
                double fazlaHacim = 0;
                if (secilenPara == null)
                {
                    throw new AtilacakParaSecilmediException();

                }

                if (secilenPara is BozukPara)
                {
                    BozukPara bozukPara = (BozukPara)secilenPara;

                    if (toplamHacim + bozukPara.Hacim() + bozukPara.FazladanHacimHesapla(secilenPara.Hacim()) >= kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDoluException();

                    }
                    fazlaHacim = bozukPara.FazladanHacimHesapla(bozukPara.Hacim());
                    toplamFazlaHacim += fazlaHacim;
                    KumbaradakiBozukParalar.Add(bozukPara);
                    birikenTutar += bozukPara.Deger;
                    minToplamHacim += bozukPara.MinumumHacim(bozukPara.Hacim());
                    toplamHacim += bozukPara.Hacim() + fazlaHacim;
                    kumbara.ParaEkle(bozukPara.Hacim() + fazlaHacim);
                }
                else if (secilenPara is KagitPara)
                {
                    KagitPara kagitPara = (KagitPara)secilenPara;
                    if (katlandiMi == false)
                    {
                        throw new ParaKatlanmadiException();

                    }

                    fazlaHacim = kagitPara.FazladanHacimHesapla(kagitPara.Hacim());
                    toplamFazlaHacim += fazlaHacim;
                    KumbaradakiKagitParalar.Add(kagitPara);
                    birikenTutar += kagitPara.Deger;
                    minToplamHacim += kagitPara.MinumumHacim(katlanmisParaHacmi);
                    toplamHacim += kagitPara.Hacim() + fazlaHacim;
                    kumbara.ParaEkle(kagitPara.Hacim() + fazlaHacim);

                    if (toplamHacim + kagitPara.Hacim() + kagitPara.FazladanHacimHesapla(secilenPara.Hacim()) > kumbara.KumbaraHacmi)

                    {
                        throw new KumbaraDoluException();

                    }
                }
                else
                {
                    MessageBox.Show("Seçilen para türü bulunamadı");
                }

                lblFazlaHacim.Text = toplamFazlaHacim.ToString();
                lblToplamHacim.Text = toplamHacim.ToString();

                cmbBozukPara.SelectedIndex = 0;
                cmbKagitPara.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParaKatla_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (secilenPara == null)
                {
                    throw new AtilacakParaSecilmediKatlaException();

                }

                KagitPara katlanacak = (KagitPara)secilenPara;
                if (katlanacak != null)
                {
                    katlandiMi = true;
                    katlanmisParaHacmi = katlanacak.Katla(katlanacak.Hacim());
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Demir para katlanamaz.");
            }
            catch (AtilacakParaSecilmediKatlaException ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnKumbaraSalla_Click(object sender, EventArgs e)
        {
            if (toplamHacim > toplamFazlaHacim && toplamFazlaHacim > 0)
            {
                toplamHacim = toplamHacim - kumbara.Salla(toplamFazlaHacim);
                kumbara.ParaEkle(-kumbara.Salla(toplamFazlaHacim));
            }
            toplamFazlaHacim = 0;

            lblFazlaHacim.Text = toplamFazlaHacim.ToString();
            lblToplamHacim.Text = minToplamHacim.ToString();
        }

        private void btnKumbaraKir_Click(object sender, EventArgs e)
        {

            if (kumbaraKirilmaSayisi < 2)
            {
                kumbaraKirilmaSayisi++;
                KumbarayiGoster();
                KumbaraSifirla();
            }
            else
            {

                MessageBox.Show("Kumbara kırma limitine geldiniz daha fazla kırılamaz çıkış yapılıyor.");
                Application.Exit();
                return;
            }
        }

        private void KumbarayiGoster()
        {
            foreach (var item in KumbaradakiBozukParalar)
            {
                lbKumbara.Items.Add(item.Deger + " - " + item.Ad);
            }
            foreach (var item in KumbaradakiKagitParalar)
            {
                lbKumbara.Items.Add(item.Deger + " - " + item.Ad);
            }
        }

        private void KumbaraSifirla()
        {
            birikenTutar = 0;
            kumbara.ToplamParaHacim = 0;
            toplamHacim = 0;
            toplamFazlaHacim = 0;
            KumbaradakiBozukParalar.Clear();
            KumbaradakiKagitParalar.Clear();
            lblFazlaHacim.Text = "0";
            lblToplamHacim.Text = "0";
        }


        #endregion
    }
}