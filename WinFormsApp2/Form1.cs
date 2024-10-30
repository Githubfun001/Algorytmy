namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List list = new List();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateDisplay()
        {
            label1.Text = list.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                list.AddFirst(liczba);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Podaj liczbê ca³kowit¹.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                list.AddLast(liczba);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Podaj liczbê ca³kowit¹.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Node? removedNode = list.RemoveFirst();
            if (removedNode != null)
            {
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Lista jest pusta.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Node? removedNode = list.RemoveLast();
            if (removedNode != null)
            {
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Lista jest pusta.");
            }
        }
    }
}