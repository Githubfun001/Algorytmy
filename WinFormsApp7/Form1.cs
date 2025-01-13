using System.Reflection.Emit;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String string1 = " " + textBox1.Text;
            String string2 = " " + textBox2.Text;


            int[,] tab = new int[string1.Length, string2.Length];


            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (string1[i] == string2[j])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }

            var wynik = string.Join(Environment.NewLine, Enumerable.Range(0, tab.GetLength(0))
                                .Select(i => string.Join("   ", Enumerable.Range(0, tab.GetLength(1))
                                .Select(j => tab[i, j].ToString()))));
            label1.Text = wynik + "\n\n" + "Najd³u¿szy podci¹g: " + tab[string1.Length-1, string2.Length-1];

        }
    }
}