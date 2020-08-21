using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiczeniePI_WindowsForms
{
    public partial class FormMain : Form
    {
        enum MetodaObliczenPI
        {
            MonteCarlo,
            Prostokaty
        }
        static readonly Random losowe = new Random(); //Obiekt klasy Random potrzebny do generowania liczb pseudolosowych
        static List<Punkt> punkty = new List<Punkt>();
        public FormMain()
        {
            int punkty = 100;
            MetodaObliczenPI startowaMetoda = MetodaObliczenPI.MonteCarlo;

            InitializeComponent();

            tbIloscPunktow.Text = Convert.ToString(punkty);
            WyznaczPunkty(startowaMetoda, punkty);
            UzupelnijTekst(PoliczPI(startowaMetoda));
            WyswietlWykres(startowaMetoda);
            RysujKolo();
        }

        private void WyznaczPunkty(MetodaObliczenPI metoda, int ilePunktow) //Jesli 1 -> Monte Carlo
        {
            punkty.Clear();

            pbCalculation.Value = 0;
            pbCalculation.Maximum = ilePunktow;
            
            if(metoda == MetodaObliczenPI.MonteCarlo)
            {
                for (int i = 0; i < ilePunktow; i++)
                {
                    punkty.Add(new Punkt((float)losowe.NextDouble(), (float)losowe.NextDouble()));
                     pbCalculation.Value = i + 1;
                }
            }
            else if(metoda == MetodaObliczenPI.Prostokaty)
            {
                for (int i = 0; i < ilePunktow; i++)
                {
                    float x = (float)(i + 1) / (ilePunktow + 1);
                    float y = (float)Math.Sqrt(1-Math.Pow(x,2));
                    punkty.Add(new Punkt(x, y));
                    pbCalculation.Value = i + 1;
                }
            }


            WyczyscDataGridView();

            if(ilePunktow <= 100)
                dgvPunkty.DataSource = punkty;
        }

        private void WyczyscDataGridView()
        {
            dgvPunkty.DataSource = null;
            for (int i = 0; i < dgvPunkty.Rows.Count; i++)
            {
                dgvPunkty.Rows.RemoveAt(i);
            }
        }

        private void WyswietlWykres(MetodaObliczenPI metoda)
        {
            cWykres.DataSource = punkty;
            cWykres.Series[0].Points.Clear();
            if(metoda == MetodaObliczenPI.MonteCarlo)
            {
                cWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                for (int i = 0; i < punkty.Count; i++)
                {
                    cWykres.Series[0].Points.AddXY(punkty[i].X, punkty[i].Y);
                }
            }
            else if(metoda == MetodaObliczenPI.Prostokaty)
            {
                cWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
                for (int i = 0; i < punkty.Count; i++)
                {
                    if (i == 0)
                        cWykres.Series[0].Points.AddXY(0, punkty[i].Y);

                    if (i == punkty.Count - 1)
                        cWykres.Series[0].Points.AddXY(punkty[i].X, 0);


                    cWykres.Series[0].Points.AddXY(punkty[i].X, punkty[i].Y);
                    if (i < punkty.Count - 1)
                        cWykres.Series[0].Points.AddXY(punkty[i].X, punkty[i + 1].Y);



                }
            }
            cWykres.Invalidate();
        }

        private void RysujKolo()
        {
            double x = 1;
            double kat = 0.25;
            for (double i = 0; i < 90; i += kat)
            {
                double xprim = x * Math.Sin(i * Math.PI / 180.0);
                double yprim = x * Math.Cos(i * Math.PI / 180.0);

                cWykres.Series[1].Points.AddXY(xprim, yprim);
            }
            cWykres.Invalidate();
        }

        private void UzupelnijTekst(float wyliczonePI)
        {
            float blad = wyliczonePI - (float)Math.PI;

            tbWartoscPI.Text = Convert.ToString(wyliczonePI);
            tbMathPI.Text = Convert.ToString(Math.PI);
            tbBlad.Text = Convert.ToString(blad);
            tbBladBezwzgledny.Text = Convert.ToString(Math.Abs(blad));
        }

        private float PoliczPI(MetodaObliczenPI metoda)
        {
            float PI = 0f;
            if (metoda == MetodaObliczenPI.MonteCarlo)
            {
                int licznikWKole = 0;
                for (int i = 0; i < punkty.Count; i++)
                {
                    if (Math.Pow(punkty[i].X, 2) + Math.Pow(punkty[i].Y, 2) <= 1)
                        licznikWKole++;
                }
                PI = 4 * (float)licznikWKole / punkty.Count;
            }
            else if (metoda == MetodaObliczenPI.Prostokaty)
            {
                float sumaProstokatow = 0f;
                for (int i = 0; i < punkty.Count; i++)
                {
                    if(i > 0)
                        sumaProstokatow += (punkty[i].X - punkty[i-1].X) * punkty[i].Y;
                    else
                        sumaProstokatow += (punkty[i].X) * punkty[i].Y;
                }
                PI = 4 * sumaProstokatow;
            }

            return PI;
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            MetodaObliczenPI metoda = MetodaObliczenPI.MonteCarlo;

            //Jeśli możemy przekonwertować text na liczbę całkowitą wtedy następuje deklaracja tablicy
            if (int.TryParse(tbIloscPunktow.Text, out int ilePunktow))
            {
                if (rbMonteCarlo.Checked)
                    metoda = MetodaObliczenPI.MonteCarlo;
                else if (rbProstokaty.Checked)
                    metoda = MetodaObliczenPI.Prostokaty;

                WyznaczPunkty(metoda, ilePunktow);
                WyswietlWykres(metoda);
                UzupelnijTekst(PoliczPI(metoda));
            }
            else //W przeciwnym wypadku powiadamiamy użytkowanika o błędzie
            {
                MessageBox.Show("Błędna ilość punktów!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
