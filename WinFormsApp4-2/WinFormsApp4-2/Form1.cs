namespace WinFormsApp4_2
{
    public partial class Form1 : Form
    {
        private BST drzewo = new BST();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WyswietlDrzewo()
        {
            treeView1.Nodes.Clear();

            if (drzewo.root != null)
            {
                TreeNode rootNode = PrzeksztalcNaTreeNode(drzewo.root);
                treeView1.Nodes.Add(rootNode);
                treeView1.ExpandAll();
            }
        }

        private TreeNode PrzeksztalcNaTreeNode(NodeT current)
        {
            if (current == null)
                return null;

            TreeNode node = new TreeNode(current.data.ToString());

            if (current.lewe != null)
                node.Nodes.Add(PrzeksztalcNaTreeNode(current.lewe));

            if (current.prawe != null)
                node.Nodes.Add(PrzeksztalcNaTreeNode(current.prawe));

            return node;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WyswietlDrzewo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                drzewo.Add(int.Parse(textBox1.Text));
                MessageBox.Show("Pomyœlnie dodano element");
            }
            catch
            {
                MessageBox.Show("Podano nieprawid³owy format.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> result = drzewo.InOrder(drzewo.root);
            textBox2.Text = string.Join(", ", result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> result = drzewo.PreOrder(drzewo.root);
            textBox2.Text = string.Join(", ", result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> result = drzewo.PostOrder(drzewo.root);
            textBox2.Text = string.Join(", ", result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                drzewo.Delete(value);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Podaj poprawn¹ liczbê.");
            }
        }
    }
}
