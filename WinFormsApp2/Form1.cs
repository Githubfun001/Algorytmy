namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List list = new List();
        private BST bst = new BST();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateDisplay()
        {
            label1.Text = list.ToString();
        }
        private void UpdateBSTDisplay()
        {
            label2.Text = DisplayTree(bst.root);
        }

        private string DisplayTree(NodeT? node)
        {
            if (node == null)
                return "";

            string left = DisplayTree(node.lewe);
            string right = DisplayTree(node.prawe);

            return $"{node.data} {left} {right}";
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int liczba))
            {
                bst.Add(liczba);
                UpdateBSTDisplay();
            }
            else
            {
                MessageBox.Show("Podaj liczbę całkowitą.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int liczba))
            {
                NodeT? nodeToRemove = FindNode(bst.root, liczba);
                if (nodeToRemove != null)
                {
                    bst.RemoveElement(nodeToRemove);
                    UpdateBSTDisplay();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono węzła z podaną wartością.");
                }
            }
            else
            {
                MessageBox.Show("Podaj liczbę całkowitą.");
            }
        }

        private NodeT? FindNode(NodeT? root, int value)
        {
            NodeT? current = root;
            while (current != null)
            {
                if (current.data == value)
                    return current;
                else if (value < current.data)
                    current = current.lewe;
                else
                    current = current.prawe;
            }
            return null;
        }
    }
}