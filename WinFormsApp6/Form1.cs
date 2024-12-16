using System.Collections.Immutable;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            string zdanie = textBox1.Text;

            Dictionary<Char, int> lista = new();

            foreach(char c in zdanie)
            {
                if(lista.ContainsKey(c))
                {
                    lista[c]++;
                }
                else
                {
                    lista.Add(c, 1);
                }
            }

            var sorted = lista.OrderBy(n => n.Value).ThenBy(n => n.GetType() == typeof(NodeGS) ? 0 : 1).ToList();


            var dictString = string.Join(Environment.NewLine, sorted.Select(pair => $"'{pair.Key}': {pair.Value}"));
            
            label1.Text = dictString;
        }
    }
}