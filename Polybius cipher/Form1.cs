using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Polybius_cipher
{
    public partial class Form1 : Form
    {

        TableLayoutPanel siatka = new TableLayoutPanel();
        public class PolyList
        {
            public char id { get; set; }
            public int XAx { get; set; }
            public int YAx { get; set; }
        }


        List<PolyList> PolybiusList = new List<PolyList>();

        public Form1()
        {
            InitializeComponent();
            StworzSiatke(5, 7);
            // czytaj();
        }

        private void StworzSiatke(int liczbaWierszy, int liczbaKolumn)
        {

            siatka.Dock = DockStyle.Fill;
            siatka.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int i = 0; i < liczbaWierszy; i++)
            {
                siatka.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                for (int j = 0; j < liczbaKolumn; j++)
                {
                    siatka.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    TextBox poleTekstowe = new TextBox();
                    poleTekstowe.Text = (i * 10 + j).ToString();
                    poleTekstowe.Width = 20;
                    // poleTekstowe.MaxLength = 2;
                    siatka.Controls.Add(poleTekstowe, j, i);
                }
            }

            panel1.Controls.Add(siatka);




        }


        private void czytaj()
        {


            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    TextBox pt = siatka.GetControlFromPosition(i, j) as TextBox;

                    string wartosc = pt.Text;

                    PolybiusList.Add(new PolyList() { id = wartosc[0], XAx = j, YAx = i });



                }

            }

            //for (int k = 0; k <= 5; k++) { };







        }

        private void button1_Click(object sender, EventArgs e)
        {
            czytaj();
            string InputTxT = InputBox.Text.ToLower();

            List<char> Output = new List<char>();

            foreach (char letter in InputTxT)
            {
                PolyList znalezionaKlasa = PolybiusList.FirstOrDefault(klasa => klasa.id == letter);

                Output.Add((znalezionaKlasa.XAx+1).ToString()[0]);
                Output.Add((znalezionaKlasa.YAx+1).ToString()[0]);

            }

            string FinalOutput = string.Join("", Output);
            OutputBox.Text = FinalOutput;

               // PolyList znalezionaKlasa = PolybiusList.FirstOrDefault(klasa => klasa.id == 'q');

            // label4.Text = ($" {znalezionaKlasa.XAx} {znalezionaKlasa.YAx}");

            //  czytaj();
        }
    }
}