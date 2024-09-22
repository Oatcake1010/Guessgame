namespace Guesswordgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] words = new[]{"driver","signature","history","response","president","highway",
        "computer","appartment","forest","chocolate","lawyer",};
        int index = 0, score = 0;
        Random random = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label_result.Text = "Result";
            label_result.BackColor = Color.Peru;
            displayWord();
            button_next.Enabled = true;
            button_start.Enabled = false;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            checkWord();
            if (index < words.Length - 1)
            {
                index++;
                displayWord();
            }
            index++;
            displayWord();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // create a function to display the words 
        public void displayWord()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);

            string word = words[index];

            word = word.Remove(pos1, 1).Insert(pos1, "_");
            word = word.Remove(pos2, 1).Insert(pos2, "_");
            word = word.Remove(pos3, 1).Insert(pos3, "_");

            label_word.Text = word;
        }
        // create a function to check if the guessed word is correct 
        public void checkWord()
        {
            if (textBox_guess.Text.ToLower().Equals(words[index]))
            {
                label_result.Text = "Correct";
                label_result.BackColor = Color.Green;
                score++;
            }
            else
            {
                label_result.Text = "Wrong";
                label_result.BackColor = Color.Red;
            }
            if(index == words.Length - 1)
            {
                button_start.Enabled = true;
                button_next.Enabled = false;
            }
            textBox_guess.Text = "";
            label_score.Text = score.ToString() + " / " + words.Length.ToString();

        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }
    }
}
    
