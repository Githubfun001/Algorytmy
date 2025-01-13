namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private Graf1 Graf;
        private NodeG1 start;
        public Form1()
        {
            InitializeComponent();

            var a = new NodeG1(0);
            var b = new NodeG1(1);
            var c = new NodeG1(2);
            var d = new NodeG1(3);
            var e = new NodeG1(4);
            var f = new NodeG1(5);

            var edge01 = new Edge(a, b, 3);
            var edge04 = new Edge(a, e, 3);
            var edge12 = new Edge(b, c, 1);
            var edge23 = new Edge(c, d, 3);
            var edge25 = new Edge(c, f, 1);
            var edge45 = new Edge(e, f, 2);
            var edge53 = new Edge(f, d, 1);
            var edge31 = new Edge(d, b, 3);
            var edge50 = new Edge(f, a, 6);

            Graf = new Graf1();
            Graf.Add(edge01);
            Graf.Add(edge04);
            Graf.Add(edge12);
            Graf.Add(edge23);
            Graf.Add(edge25);
            Graf.Add(edge45);
            Graf.Add(edge53);
            Graf.Add(edge31);
            Graf.Add(edge50);

            start = a;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var odleglosci = Graf.Dijkstra(start);

            textBox1.Clear();
            foreach (var (node, distance) in odleglosci)
            {
                textBox1.AppendText($"Node {node.data}: {distance}{Environment.NewLine}");
            }
        }
    }
}