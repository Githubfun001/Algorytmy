namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Graf graf;
        public Form1()
        {
            InitializeComponent();
            graf = new Graf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "BFS: " + string.Join(" ", graf.Wszerz(graf.nodes[0]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DFS: " + string.Join(" ", graf.Wglab(graf.nodes[0]));
        }
    }
}
