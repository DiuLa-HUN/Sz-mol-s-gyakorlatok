namespace Számolós_gyakorlatok
{
    partial class frm_foablak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_meddig = new Label();
            tb_meddig = new TextBox();
            tb_elso_szam = new TextBox();
            lb_muvelet = new Label();
            tb_masodik_szam = new TextBox();
            lb_egyenlo = new Label();
            tb_eredmeny = new TextBox();
            bt_inditas = new Button();
            rtb_magyarazat = new RichTextBox();
            bt_ellenorzes = new Button();
            lb_jok = new Label();
            lb_rosszak = new Label();
            tb_jok = new TextBox();
            tb_rosszak = new TextBox();
            bt_valtoztatas = new Button();
            cb_szorzasosztas = new CheckBox();
            SuspendLayout();
            // 
            // lb_meddig
            // 
            lb_meddig.AutoSize = true;
            lb_meddig.Location = new Point(14, 16);
            lb_meddig.Name = "lb_meddig";
            lb_meddig.Size = new Size(234, 20);
            lb_meddig.TabIndex = 0;
            lb_meddig.Text = "Írd ide meddig mehet a számolás:";
            // 
            // tb_meddig
            // 
            tb_meddig.Cursor = Cursors.AppStarting;
            tb_meddig.Location = new Point(254, 13);
            tb_meddig.Margin = new Padding(3, 4, 3, 4);
            tb_meddig.Name = "tb_meddig";
            tb_meddig.Size = new Size(114, 27);
            tb_meddig.TabIndex = 1;
            tb_meddig.TextAlign = HorizontalAlignment.Center;
            tb_meddig.KeyPress += tb_meddig_KeyPress;
            // 
            // tb_elso_szam
            // 
            tb_elso_szam.Enabled = false;
            tb_elso_szam.Font = new Font("Segoe UI", 20F);
            tb_elso_szam.Location = new Point(9, 223);
            tb_elso_szam.Margin = new Padding(3, 4, 3, 4);
            tb_elso_szam.Name = "tb_elso_szam";
            tb_elso_szam.Size = new Size(114, 52);
            tb_elso_szam.TabIndex = 4;
            tb_elso_szam.TextAlign = HorizontalAlignment.Center;
            tb_elso_szam.KeyPress += tb_elso_szam_KeyPress;
            // 
            // lb_muvelet
            // 
            lb_muvelet.AutoSize = true;
            lb_muvelet.Font = new Font("Segoe UI", 20F);
            lb_muvelet.Location = new Point(129, 223);
            lb_muvelet.Name = "lb_muvelet";
            lb_muvelet.Size = new Size(43, 46);
            lb_muvelet.TabIndex = 5;
            lb_muvelet.Text = "+";
            // 
            // tb_masodik_szam
            // 
            tb_masodik_szam.Enabled = false;
            tb_masodik_szam.Font = new Font("Segoe UI", 20F);
            tb_masodik_szam.Location = new Point(176, 223);
            tb_masodik_szam.Margin = new Padding(3, 4, 3, 4);
            tb_masodik_szam.Name = "tb_masodik_szam";
            tb_masodik_szam.Size = new Size(114, 52);
            tb_masodik_szam.TabIndex = 6;
            tb_masodik_szam.TextAlign = HorizontalAlignment.Center;
            tb_masodik_szam.KeyPress += tb_masodik_szam_KeyPress;
            // 
            // lb_egyenlo
            // 
            lb_egyenlo.AutoSize = true;
            lb_egyenlo.Font = new Font("Segoe UI", 20F);
            lb_egyenlo.Location = new Point(296, 226);
            lb_egyenlo.Name = "lb_egyenlo";
            lb_egyenlo.Size = new Size(43, 46);
            lb_egyenlo.TabIndex = 7;
            lb_egyenlo.Text = "=";
            // 
            // tb_eredmeny
            // 
            tb_eredmeny.Enabled = false;
            tb_eredmeny.Font = new Font("Segoe UI", 20F);
            tb_eredmeny.Location = new Point(345, 223);
            tb_eredmeny.Margin = new Padding(3, 4, 3, 4);
            tb_eredmeny.Name = "tb_eredmeny";
            tb_eredmeny.Size = new Size(114, 52);
            tb_eredmeny.TabIndex = 8;
            tb_eredmeny.TextAlign = HorizontalAlignment.Center;
            tb_eredmeny.KeyPress += tb_eredmeny_KeyPress;
            // 
            // bt_inditas
            // 
            bt_inditas.Location = new Point(670, 13);
            bt_inditas.Margin = new Padding(3, 4, 3, 4);
            bt_inditas.Name = "bt_inditas";
            bt_inditas.Size = new Size(100, 60);
            bt_inditas.TabIndex = 9;
            bt_inditas.Text = "Indítás";
            bt_inditas.UseVisualStyleBackColor = true;
            bt_inditas.Click += bt_inditas_Click;
            // 
            // rtb_magyarazat
            // 
            rtb_magyarazat.Enabled = false;
            rtb_magyarazat.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtb_magyarazat.Location = new Point(9, 47);
            rtb_magyarazat.Name = "rtb_magyarazat";
            rtb_magyarazat.Size = new Size(655, 169);
            rtb_magyarazat.TabIndex = 10;
            rtb_magyarazat.Text = "Helló!\nÍrd be mennyi legyen a maximális szám, ameddig számolni szeretnél és jelöld be, hogy legyen-e szorzás és osztás is. Alapból összeadás és kivonás van benne és a gép véletlenszerűen választ.";
            // 
            // bt_ellenorzes
            // 
            bt_ellenorzes.Enabled = false;
            bt_ellenorzes.Font = new Font("Segoe UI", 20F);
            bt_ellenorzes.Location = new Point(490, 222);
            bt_ellenorzes.Name = "bt_ellenorzes";
            bt_ellenorzes.Size = new Size(280, 53);
            bt_ellenorzes.TabIndex = 11;
            bt_ellenorzes.Text = "Ellenőrzés";
            bt_ellenorzes.UseVisualStyleBackColor = true;
            bt_ellenorzes.Click += bt_ellenorzes_Click;
            // 
            // lb_jok
            // 
            lb_jok.AutoSize = true;
            lb_jok.Font = new Font("Segoe UI", 20F);
            lb_jok.Location = new Point(9, 291);
            lb_jok.Name = "lb_jok";
            lb_jok.Size = new Size(239, 46);
            lb_jok.TabIndex = 12;
            lb_jok.Text = "Jó számolások:";
            // 
            // lb_rosszak
            // 
            lb_rosszak.AutoSize = true;
            lb_rosszak.Font = new Font("Segoe UI", 20F);
            lb_rosszak.Location = new Point(9, 362);
            lb_rosszak.Name = "lb_rosszak";
            lb_rosszak.Size = new Size(339, 46);
            lb_rosszak.TabIndex = 13;
            lb_rosszak.Text = "Elrontott számolások:";
            // 
            // tb_jok
            // 
            tb_jok.Enabled = false;
            tb_jok.Font = new Font("Segoe UI", 20F);
            tb_jok.Location = new Point(361, 288);
            tb_jok.Name = "tb_jok";
            tb_jok.Size = new Size(125, 52);
            tb_jok.TabIndex = 14;
            tb_jok.Text = "0";
            tb_jok.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_rosszak
            // 
            tb_rosszak.Enabled = false;
            tb_rosszak.Font = new Font("Segoe UI", 20F);
            tb_rosszak.Location = new Point(361, 359);
            tb_rosszak.Name = "tb_rosszak";
            tb_rosszak.Size = new Size(125, 52);
            tb_rosszak.TabIndex = 15;
            tb_rosszak.Text = "0";
            tb_rosszak.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_valtoztatas
            // 
            bt_valtoztatas.Enabled = false;
            bt_valtoztatas.Location = new Point(670, 80);
            bt_valtoztatas.Name = "bt_valtoztatas";
            bt_valtoztatas.Size = new Size(100, 60);
            bt_valtoztatas.TabIndex = 16;
            bt_valtoztatas.Text = "Változtatás";
            bt_valtoztatas.UseVisualStyleBackColor = true;
            bt_valtoztatas.Click += bt_valtoztatas_Click;
            // 
            // cb_szorzasosztas
            // 
            cb_szorzasosztas.AutoSize = true;
            cb_szorzasosztas.Location = new Point(374, 14);
            cb_szorzasosztas.Name = "cb_szorzasosztas";
            cb_szorzasosztas.Size = new Size(214, 24);
            cb_szorzasosztas.TabIndex = 17;
            cb_szorzasosztas.Text = "Legyen szorzás és osztás is?";
            cb_szorzasosztas.UseVisualStyleBackColor = true;
            // 
            // frm_foablak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 438);
            Controls.Add(cb_szorzasosztas);
            Controls.Add(bt_valtoztatas);
            Controls.Add(tb_rosszak);
            Controls.Add(tb_jok);
            Controls.Add(lb_rosszak);
            Controls.Add(lb_jok);
            Controls.Add(bt_ellenorzes);
            Controls.Add(rtb_magyarazat);
            Controls.Add(bt_inditas);
            Controls.Add(tb_eredmeny);
            Controls.Add(lb_egyenlo);
            Controls.Add(tb_masodik_szam);
            Controls.Add(lb_muvelet);
            Controls.Add(tb_elso_szam);
            Controls.Add(tb_meddig);
            Controls.Add(lb_meddig);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frm_foablak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Számolós gyakorlás";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_meddig;
        private TextBox tb_meddig;
        private TextBox tb_elso_szam;
        private Label lb_muvelet;
        private TextBox tb_masodik_szam;
        private Label lb_egyenlo;
        private TextBox tb_eredmeny;
        private Button bt_inditas;
        private RichTextBox rtb_magyarazat;
        private Button bt_ellenorzes;
        private Label lb_jok;
        private Label lb_rosszak;
        private TextBox tb_jok;
        private TextBox tb_rosszak;
        private Button bt_valtoztatas;
        private CheckBox cb_szorzasosztas;
    }
}
