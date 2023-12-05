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
            // Event handler for the "Run encryption/decryption" button

            if ((Input1.Text != null) && (KeyBox1.SelectedItems.Count > 0))
            {
                var Input = Input1.Text;
                int Key = int.Parse(KeyBox1.Text);

                switch (encrypt1.Checked)
                {
                    case true:
                        Encrypt(Input, Key); // Call the Encrypt function
                        break;
                    case false:
                        Decrypt(Input, Key); // Call the Decrypt function
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
            // Function to perform text encryption

            TxtInput = TxtInput.ToLower();

            string CharList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

            List<char> TxtOutput = new List<char>();

            TxtInput.ToList().ForEach(znak => {
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

            Output1.Text = string.Join("", TxtOutput); // Display the encrypted text
        }

        void Decrypt(string TxtInput, int Key)
        {
            // Function to perform text decryption

            TxtInput = TxtInput.ToLower();

            string CharList = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";

            List<char> TxtOutput = new List<char>();

            TxtInput.ToList().ForEach(znak => {
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

            });

            Output1.Text = string.Join("", TxtOutput); // Display the decrypted text
        }

        private void KeyBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for changes in the selected key
        }

        private void encrypt1_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler for the "Encrypt" radio button selection

            label1.Text = "Normal text (input):"; // Update label text
            label3.Text = "Ciphertext (output):"; // Update label text
            Button_start.Text = "Run encryption"; // Update button text
        }

        private void decrypt1_CheckedChanged(object sender, EventArgs e)
        {
            // Event handler for the "Decrypt" radio button selection

            label3.Text = "Normal text (output):"; // Update label text
            label1.Text = "Ciphertext (input):"; // Update label text
            Button_start.Text = "Run decryption"; // Update button text
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
