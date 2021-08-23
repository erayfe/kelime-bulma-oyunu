using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Bulma
{
    public partial class Form1 : Form
    {
        //Buraya istediğiniz kelimeleri yazabilirsiniz
        string[] kelimeler = { "BİLGİSAYAR", "KETÇAP", "TELEFON", "PATATES" ,"MENDİL","ÇİKOLATA","BARDAK",
            "CÜZDAN","TABANCA","DEFTER"};
        string kelime;
        char[] ayir;
        int i = 0;
        int hak = 6;
        int puan;
        int boyut;
        int[] dogru = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        Random r = new Random();
        int ras;

        public Form1()
        {
            InitializeComponent();

            a.Visible = false;
            b.Visible = false;
            c.Visible = false;
            c2.Visible = false;
            d.Visible = false;
            e2.Visible = false;
            f.Visible = false;
            g.Visible = false;
            g2.Visible = false;
            h.Visible = false;
            i2.Visible = false;
            i3.Visible = false;
            j.Visible = false;
            k.Visible = false;
            l.Visible = false;
            m.Visible = false;
            n.Visible = false;
            o.Visible = false;
            o2.Visible = false;
            p.Visible = false;
            r2.Visible = false;
            s.Visible = false;
            s2.Visible = false;
            t.Visible = false;
            u.Visible = false;
            u2.Visible = false;
            v.Visible = false;
            y.Visible = false;
            z.Visible = false;

            a.MouseClick += new MouseEventHandler(bc_MouseClick);
            b.MouseClick += new MouseEventHandler(bc_MouseClick);
            c.MouseClick += new MouseEventHandler(bc_MouseClick);
            c2.MouseClick += new MouseEventHandler(bc_MouseClick);
            d.MouseClick += new MouseEventHandler(bc_MouseClick);
            e2.MouseClick += new MouseEventHandler(bc_MouseClick);
            f.MouseClick += new MouseEventHandler(bc_MouseClick);
            g.MouseClick += new MouseEventHandler(bc_MouseClick);
            g2.MouseClick += new MouseEventHandler(bc_MouseClick);
            h.MouseClick += new MouseEventHandler(bc_MouseClick);
            i2.MouseClick += new MouseEventHandler(bc_MouseClick);
            i3.MouseClick += new MouseEventHandler(bc_MouseClick);
            j.MouseClick += new MouseEventHandler(bc_MouseClick);
            k.MouseClick += new MouseEventHandler(bc_MouseClick);
            l.MouseClick += new MouseEventHandler(bc_MouseClick);
            m.MouseClick += new MouseEventHandler(bc_MouseClick);
            n.MouseClick += new MouseEventHandler(bc_MouseClick);
            o.MouseClick += new MouseEventHandler(bc_MouseClick);
            o2.MouseClick += new MouseEventHandler(bc_MouseClick);
            p.MouseClick += new MouseEventHandler(bc_MouseClick);
            r2.MouseClick += new MouseEventHandler(bc_MouseClick);
            s.MouseClick += new MouseEventHandler(bc_MouseClick);
            s2.MouseClick += new MouseEventHandler(bc_MouseClick);
            t.MouseClick += new MouseEventHandler(bc_MouseClick);
            u.MouseClick += new MouseEventHandler(bc_MouseClick);
            u2.MouseClick += new MouseEventHandler(bc_MouseClick);
            v.MouseClick += new MouseEventHandler(bc_MouseClick);
            y.MouseClick += new MouseEventHandler(bc_MouseClick);
            z.MouseClick += new MouseEventHandler(bc_MouseClick);
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            ras = r.Next(10 );
            kelime = kelimeler[ras];
            ayir = kelime.ToCharArray();
            boyut = kelime.Length-1;
            i = 0;
            hak = 6;
            kazan.Text = "";
            label1.Text = "";
            kalanhak.Text = ($"KALAN HAK: {hak}");
            Label[] harfler = { harf1, harf2, harf3, harf4, harf5, harf6, harf7, harf8, harf9, harf10 };
            

            while(i <= boyut)
            {
                harfler[i].Text = "_";
                dogru[i] = 0;
                i++;
            }
            while (i < 10)
            {
                harfler[i].Text = " ";
                dogru[i] = 1;
                i++;
            }
            button1.Visible = false;
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            c2.Visible = true;
            d.Visible = true;
            e2.Visible = true;
            f.Visible = true;
            g.Visible = true;
            g2.Visible = true;
            h.Visible = true;
            i2.Visible = true;
            i3.Visible = true;
            j.Visible = true;
            k.Visible = true;
            l.Visible = true;
            m.Visible = true;
            n.Visible = true;
            o.Visible = true;
            o2.Visible = true;
            p.Visible = true;
            r2.Visible = true;
            s.Visible = true;
            s2.Visible = true;
            t.Visible = true;
            u.Visible = true;
            u2.Visible = true;
            v.Visible = true;
            y.Visible = true;
            z.Visible = true;
        }

        void bc_MouseClick(object sender, MouseEventArgs e)
        {
            Button bc = (Button)sender;

            i = 0;
            puan = 0;

            int kontrol = 0;
            Label[] harfler = { harf1, harf2, harf3, harf4, harf5, harf6, harf7, harf8, harf9, harf10 };

            while (i <= boyut)
            {
                if (bc.Text == ayir[i].ToString())
                {
                    harfler[i].Text = ayir[i].ToString();
                    dogru[i] = 1;
                    kontrol = 1;
                }
                i++;


            }
            i = 0;
            while (i < 10)
            {
                if (dogru[i] == 1)
                    puan++;
                i++;
            }

            if (kontrol == 0)
            {
                hak--;
                kalanhak.Text = ($"KALAN HAK: {hak}");
            }
            if (puan == 10)
            {
                kazan.Text = "TEBRİKLER KAZANDIN";
                button1.Visible = true;
                kalanhak.Text = "";
                a.Visible = false;
                b.Visible = false;
                c.Visible = false;
                c2.Visible = false;
                d.Visible = false;
                e2.Visible = false;
                f.Visible = false;
                g.Visible = false;
                g2.Visible = false;
                h.Visible = false;
                i2.Visible = false;
                i3.Visible = false;
                j.Visible = false;
                k.Visible = false;
                l.Visible = false;
                m.Visible = false;
                n.Visible = false;
                o.Visible = false;
                o2.Visible = false;
                p.Visible = false;
                r2.Visible = false;
                s.Visible = false;
                s2.Visible = false;
                t.Visible = false;
                u.Visible = false;
                u2.Visible = false;
                v.Visible = false;
                y.Visible = false;
                z.Visible = false;
            }
            if (hak == 0)
            {
                kazan.Text = "KAYBETTİN";
                button1.Visible = true;
                kalanhak.Text = "";
                label1.Text = ($"DOĞRU CEVAP: {kelime}");
                a.Visible = false;
                b.Visible = false;
                c.Visible = false;
                c2.Visible = false;
                d.Visible = false;
                e2.Visible = false;
                f.Visible = false;
                g.Visible = false;
                g2.Visible = false;
                h.Visible = false;
                i2.Visible = false;
                i3.Visible = false;
                j.Visible = false;
                k.Visible = false;
                l.Visible = false;
                m.Visible = false;
                n.Visible = false;
                o.Visible = false;
                o2.Visible = false;
                p.Visible = false;
                r2.Visible = false;
                s.Visible = false;
                s2.Visible = false;
                t.Visible = false;
                u.Visible = false;
                u2.Visible = false;
                v.Visible = false;
                y.Visible = false;
                z.Visible = false;
            }
            
            bc.Visible = false;
        }
    }
}
