namespace Criphers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encrypt1.Checked = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if ((Input1.Text != null) && (KeyBox1.SelectedItems.Count > 0))
            {
                var Input = Input1.Text;
                int Key = int.Parse(KeyBox1.Text);


                switch (encrypt1.Checked)
                {
                    case true:
                        Encrypt(Input, Key);

                        break;
                    case false:
                        Decrypt(Input, Key);

                        break;
                }


            }
            else
            {
                MessageBox.Show("Set input text and key to start");
            }



        }


        void Encrypt(string TxtInput, int Key)
        {


            TxtInput = TxtInput.ToLower();


            string CharList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

            List<char> TxtOutput = new List<char>();


            TxtInput.ToList().ForEach(znak =>
            {
                int index = CharList.IndexOf(znak);
                if (index != -1)
                {
                    int CharIndex = index + Key;


                    if (CharIndex >= 35)
                    {
                        CharIndex -= 35;
                    }


                    TxtOutput.Add(CharList[CharIndex]);


                }

            });

            Output1.Text = string.Join("", TxtOutput);

        }




        void Decrypt(string TxtInput, int Key)
        {


            TxtInput = TxtInput.ToLower();


            string CharList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

            List<char> TxtOutput = new List<char>();


            TxtInput.ToList().ForEach(znak =>
            {
                int index = CharList.IndexOf(znak);
                if (index != -1)
                {
                    int CharIndex = index - Key;

                    if (CharIndex < 0)
                    {
                        CharIndex += 35;
                    }


                    TxtOutput.Add(CharList[CharIndex]);


                }


                // Tutaj możesz wykonywać operacje na każdym znaku 'znak'
            });

            // int aa = (int)'a';
            // int zz = (int)'ż';
            Output1.Text = string.Join("", TxtOutput);
        }


        private void KeyBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void encrypt1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Normal text (input):";
            label3.Text = "Ciphertext (output):";
            Button_start.Text = "Run encryption";
        }

        private void decrypt1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Normal text (output):";
            label1.Text = "Ciphertext (input):";
            Button_start.Text = "Run decryption";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}