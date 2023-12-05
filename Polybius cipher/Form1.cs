﻿using System.IO;
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
                    //poleTekstowe.Text = (i * 10 + j).ToString();
                    poleTekstowe.Text = "-";
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

                    // PolybiusList.Add(new PolyList() { id = (char) wartosc[0], XAx = j, YAx = i });
                    PolybiusList.Add(new PolyList((char)wartosc[0], j + 1, i + 1));



                }

            }

            //for (int k = 0; k <= 5; k++) { };







        }


        private void encrypt()
        {
            czytaj();
            string InputTxT = InputBox.Text.ToLower();
            InputTxT = CheckString(InputTxT);

            List<char> Output = new List<char>();

            foreach (char letter in InputTxT)
            {
                PolyList znalezionaKlasa = PolybiusList.FirstOrDefault(klasa => klasa.id == letter);

                Output.Add((znalezionaKlasa.XAx).ToString()[0]);
                Output.Add((znalezionaKlasa.YAx).ToString()[0]);

            }

            string FinalOutput = string.Join("", Output);
            OutputBox.Text = FinalOutput;

        }





        private void button1_Click(object sender, EventArgs e)
        {


            encrypt();


        }

        private void decrypt()
        {
            czytaj();

            string TxtToDecrypt = InputBox.Text.ToLower();

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



        static string CheckString(string input)
        {

            string charList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            char[] allowedChars = charList.ToCharArray();
            char[] resultArray = new char[input.Length];
            int resultIndex = 0;

            foreach (char character in input)
            {
                if (Array.IndexOf(allowedChars, character) != -1)
                {
                    // Znak jest z tablicy dozwolonych, dodaj do wynikowego ciągu
                    resultArray[resultIndex++] = character;
                }
                // Inaczej pomijamy znak spoza tablicy
            }

            // Konwertuj tablicę wynikową do ciągu
            return new string(resultArray, 0, resultIndex);
        }




    }
}