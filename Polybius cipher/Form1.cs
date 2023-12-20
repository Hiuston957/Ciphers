using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Polybius_cipher.Form1;
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

            public int BigID;

            public PolyList(char Id, int xAx, int yAx)
            {
                id = Id;
                XAx = xAx;
                YAx = yAx;
                BigID = XAx * 10 + YAx;
            }

        }


        public List<PolyList> PolybiusList = new List<PolyList>();
        public bool ErrorList=false;
        public Form1()
        {
            InitializeComponent();
            StworzSiatke(5, 7);
            
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
                   
                    poleTekstowe.Text = "-";
                    poleTekstowe.Width = 20;
                    
                    siatka.Controls.Add(poleTekstowe, j, i);
                }
            }

            panel1.Controls.Add(siatka);




        }






        private void Czytaj()
        {
            Dictionary<char, int> checkletter = new Dictionary<char, int>();

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 4; j++) 
                {
                    TextBox? pt = siatka.GetControlFromPosition(i, j) as TextBox;

                    string wartosc = pt.Text;
                    char finalwartosc = wartosc[0];

                   



                    if (checkletter.ContainsKey((char)wartosc[0]))
                    {

                         MessageBox.Show("character array contains duplicates", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        ErrorList = false;
                        return;
                       
                    }
                    else
                        checkletter.TryAdd(finalwartosc, 1);
                  









                    PolybiusList.Add(new PolyList((char)wartosc[0], j + 1, i + 1));



                }

            }


            if (checkletter.Count != 35)
            {
                ErrorList = false;
                MessageBox.Show("character array contains errors", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
              





            }


        private void encrypt()
        {
            Czytaj();
          
           // if (ErrorList==false) { return; }

            string InputTxT = InputBox.Text.ToLower();
            InputTxT = CheckStringEn(InputTxT);

            List<char> Output = new List<char>();

            foreach (char letter in InputTxT)
            {
                PolyList znalezionaKlasa = PolybiusList.FirstOrDefault(klasa => klasa.id == letter);

                Output.Add((znalezionaKlasa.XAx).ToString()[0]);
                Output.Add((znalezionaKlasa.YAx).ToString()[0]);

            }

            string FinalOutput = string.Join("", Output);
            OutputBox.Text = FinalOutput;
            Console.WriteLine(FinalOutput);

        }





        private void button1_Click(object sender, EventArgs e)
        {


            encrypt();


        }

        private void decrypt()
        {
            Czytaj();
           // if (ErrorList == false) { return; }

            string TxtToDecrypt = InputBox.Text.ToLower();
            TxtToDecrypt = CheckStringDe(TxtToDecrypt);


            char[] charInput = TxtToDecrypt.ToCharArray();

            int length = charInput.Length;

            int[,] TxtCord = new int[length / 2, 2];

            for (int i = 0; i < length; i += 2)
            {
                TxtCord[i / 2, 0] = charInput[i] - '0';
                TxtCord[i / 2, 1] = charInput[i + 1] - '0';
            }

            char[] output = new char[length / 2];

            for (int i = 0; i < output.Length; i++)
            {

                output[i] = FindIdByBigID(PolybiusList, TxtCord[i, 0] * 10 + TxtCord[i, 1]);

            }
            OutputBox.Text = new string(output);

        }



        public char FindIdByBigID(List<PolyList> polyList, int targetBigID)
        {

            PolyList foundObject = polyList.Find(obj => obj.BigID == targetBigID);


            return foundObject != null ? foundObject.id : '\0';
        }



        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Run_decipher_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }



        static string CheckStringEn(string input)
        {

            string charList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            char[] allowedChars = charList.ToCharArray();
            char[] resultArray = new char[input.Length];
            int resultIndex = 0;

            foreach (char character in input)
            {
                if (Array.IndexOf(allowedChars, character) != -1)
                {
                    
                    resultArray[resultIndex++] = character;
                }
              
            }

            
            return new string(resultArray, 0, resultIndex);
        }

        static string CheckStringDe(string input)
        {

            string charList = "0123456789";
            char[] allowedChars = charList.ToCharArray();
            char[] resultArray = new char[input.Length];
            int resultIndex = 0;

            foreach (char character in input)
            {
                if (Array.IndexOf(allowedChars, character) != -1)
                {
                    
                    resultArray[resultIndex++] = character;
                }
                
            }

            
            return new string(resultArray, 0, resultIndex);
        }

        static void MoreComplicatedDE(string input)
        {
            char[] resultArray = new char[input.Length];
            if (input.Length > 2) 
            {
                
                int a= resultArray[2] - '0';
                int b = resultArray[2] - '0';

               // a=(a+2)

            }


        }



    }
}