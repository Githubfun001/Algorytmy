namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf graf = new();
            List<int> list = new();
            for (int i = 0; i < graf.nodes.Count; i++)
                list.Add(graf.nodes.ToString());
            label1.Text = list.ToString();
        }
    }
}