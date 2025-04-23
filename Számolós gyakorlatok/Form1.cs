namespace Számolós_gyakorlatok
{
    public partial class frm_foablak : Form
    {
        public frm_foablak()
        {
            InitializeComponent();
            cb_szorzasosztas.Enabled = false;
        }

        public int nagy;
        public string meddig;
        public string eredmeny;
        public int melyik;
        public int jok;
        public int rosszak;
        public int muvelet;

        //Indítás előtti ellenőrzés és beállítás, ha a feltételek megfelelőek
        private void bt_inditas_Click(object sender, EventArgs e)
        {
            meddig = tb_meddig.Text;
            if (meddig == "")
                MessageBox.Show("Nincs beírva meddig mehet a számolás!");
            else if (cb_szorzasosztas.Checked == true)
            {
                bt_inditas.Enabled = false;
                bt_valtoztatas.Enabled = true;
                cb_szorzasosztas.Enabled = false;
                bt_ellenorzes.Enabled = true;
                tb_meddig.Enabled = false;
                nagy = 5;
                szamolas();
            }
            else 
            {
                bt_inditas.Enabled = false;
                bt_valtoztatas.Enabled = true;
                cb_szorzasosztas.Enabled = false;
                bt_ellenorzes.Enabled = true;
                tb_meddig.Enabled = false;
                nagy = 3;
                szamolas();
            }
        }

        //A számolási művelet és a kitalálandó mező elrejtése véletlenszerűen
        public void szamolas()
        {
            int meddigmehet = Convert.ToInt32(meddig);
            Random veletlen = new Random();
            int kiszamolando = veletlen.Next(1, 4);
            int legnagyobbszam = veletlen.Next(1, meddigmehet + 1);
            int seged = veletlen.Next(1, legnagyobbszam + 1);
            int masikseged = legnagyobbszam - seged;
            melyik = 0;
            muvelet = veletlen.Next(1, nagy);


            switch (muvelet)
            {
                case 1:
                    lb_muvelet.Text = "+";
                    tb_eredmeny.Text = legnagyobbszam.ToString();
                    tb_elso_szam.Text = seged.ToString();
                    tb_masodik_szam.Text = masikseged.ToString();
                    break;
                case 2:
                    lb_muvelet.Text = "-";
                    tb_elso_szam.Text = legnagyobbszam.ToString();
                    tb_masodik_szam.Text = seged.ToString();
                    tb_eredmeny.Text = masikseged.ToString();
                    break;
                case 3:
                    lb_muvelet.Text = "*";
                    tb_elso_szam.Text = legnagyobbszam.ToString();
                    tb_masodik_szam.Text = seged.ToString();
                    tb_eredmeny.Text = masikseged.ToString();
                    break;
                case 4:
                    lb_muvelet.Text = "/";
                    tb_elso_szam.Text = legnagyobbszam.ToString();
                    tb_masodik_szam.Text = seged.ToString();
                    tb_eredmeny.Text = masikseged.ToString();
                    break;
            }



            switch (kiszamolando)
            {
                case 1:
                    tb_elso_szam.Enabled = true;
                    eredmeny = tb_elso_szam.Text;
                    melyik = 1;
                    tb_elso_szam.Text = "";
                    tb_elso_szam.Focus();
                    tb_masodik_szam.Enabled = false;
                    tb_eredmeny.Enabled = false;
                    break;
                case 2:
                    tb_elso_szam.Enabled = false;
                    tb_masodik_szam.Enabled = true;
                    eredmeny = tb_masodik_szam.Text;
                    melyik = 2;
                    tb_masodik_szam.Text = "";
                    tb_masodik_szam.Focus();
                    tb_eredmeny.Enabled = false;
                    break;
                case 3:
                    tb_elso_szam.Enabled = false;
                    tb_masodik_szam.Enabled = false;
                    tb_eredmeny.Enabled = true;
                    eredmeny = tb_eredmeny.Text;
                    melyik = 3;
                    tb_eredmeny.Text = "";
                    tb_eredmeny.Focus();
                    break;
            }
        }

        //Itt van beállítva, hogy csak számokat lehessen beírni a mezőkbe
        private void tb_meddig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_elso_szam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) // Enter billentyű érzékelése
            {
                ellenorzes();
                e.Handled = true;
            }
        }

        private void tb_masodik_szam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) // Enter billentyű érzékelése
            {
                ellenorzes();
                e.Handled = true;
            }
        }

        private void tb_eredmeny_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) // Enter billentyű érzékelése
            {
                ellenorzes();
                e.Handled = true;
            }
        }

        //Itt ellenőrizzük le, hogy a beírt szám jó vagy nem és az alapján a teendők
        private void ellenorzes()
        {
            if (tb_elso_szam.Text == "" || tb_masodik_szam.Text == "" || tb_eredmeny.Text == "")
                MessageBox.Show("Nem írtál be semmit!");
            else
            {
                switch (melyik)
                {
                    case 1:
                        if (eredmeny == tb_elso_szam.Text)
                        {
                            MessageBox.Show("Szép volt. Jöhet a következő!");
                            jok++;
                            tb_jok.Text = jok.ToString();
                            szamolas();
                        }
                        else
                        {
                            MessageBox.Show("Sajnos ez nem jó. Próbáld újra!");
                            rosszak++;
                            tb_rosszak.Text = rosszak.ToString();
                        }
                        break;
                    case 2:
                        if (eredmeny == tb_masodik_szam.Text)
                        {
                            MessageBox.Show("Szép volt. Jöhet a következő!");
                            jok++;
                            tb_jok.Text = jok.ToString();
                            szamolas();
                        }
                        else
                        {
                            MessageBox.Show("Sajnos ez nem jó. Próbáld újra!");
                            rosszak++;
                            tb_rosszak.Text = rosszak.ToString();
                        }
                        break;
                    case 3:
                        if (eredmeny == tb_eredmeny.Text)
                        {
                            MessageBox.Show("Szép volt. Jöhet a következő!");
                            jok++;
                            tb_jok.Text = jok.ToString();
                            szamolas();
                        }
                        else
                        {
                            MessageBox.Show("Sajnos ez nem jó. Próbáld újra!");
                            rosszak++;
                            tb_rosszak.Text = rosszak.ToString();
                        }
                        break;
                }
            }
        }

        private void bt_valtoztatas_Click(object sender, EventArgs e)
        {
            bt_inditas.Enabled = true;
            bt_valtoztatas.Enabled = false;
            //cb_szorzasosztas.Enabled = true;
            bt_ellenorzes.Enabled = false;
            tb_elso_szam.Enabled = false;
            tb_elso_szam.Text = "";
            tb_masodik_szam.Enabled = false;
            tb_masodik_szam.Text = "";
            tb_eredmeny.Enabled = false;
            tb_eredmeny.Text = "";
            tb_meddig.Enabled = true;
        }

        private void bt_ellenorzes_Click(object sender, EventArgs e)
        {
            ellenorzes();
        }
    }
}