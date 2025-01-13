using System.Collections.Immutable;
using System.Xml.Linq;

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

            var nodes = new List<NodeG>();

            foreach (var pair in lista)
            {
                var node = new NodeGS(pair.Value, pair.Key);
                nodes.Add(node);
            }

            while (nodes.Count > 1)
            {
                nodes.Sort((x, y) => x.data.CompareTo(y.data));

                var min1 = nodes[0];
                var min2 = nodes[1];

                var parent = new NodeG(min1.data + min2.data);
                parent.lewe = min1;
                parent.prawe = min2;
                min1.rodzic = parent;
                min2.rodzic = parent;

                nodes.RemoveAt(0);
                nodes.RemoveAt(0);

                nodes.Add(parent);
            }

            var root = nodes[0];
            var codes = new Dictionary<char, string>();

            GenerateHuffmanCodes(root, "", codes);

            var codesString = string.Join(Environment.NewLine, codes.Select(pair => $"'{pair.Key}': {pair.Value}"));
            label2.Text = "Kody Huffmana:\n" + codesString;

        }

        private void GenerateHuffmanCodes(NodeG node, string code, Dictionary<char, string> codes)
        {
            if (node is NodeGS nodeGS)
            {
                codes[nodeGS.symbol] = code;
            }

            if (node.lewe != null)
                GenerateHuffmanCodes(node.lewe, code + "0", codes);
            if (node.prawe != null)
                GenerateHuffmanCodes(node.prawe, code + "1", codes);
        }
    }
}