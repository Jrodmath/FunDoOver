using NotepadClasses;
using System.IO;
using System.Text;

namespace NotepadForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenericLoadText(TextReader readFile)
        {
            if (readFile == TextReader.Null)
            {
                throw new FileNotFoundException();
            }

            if (textBox1 != null)
            {
                textBox1.Clear();
            }

            string s = readFile.ReadToEnd().ToString();

            textBox1.Text = s;
        }


        private void LoadFromFile(StreamReader streamReader)
        {
            GenericLoadText(streamReader);
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader newReader = new StreamReader(openFileDialog.FileName);
                LoadFromFile(newReader);
            }
        }

        private void fibo50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciTextReader fibo50 = new FibonacciTextReader(50);
            GenericLoadText(fibo50);
        }

        private void fibo100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FibonacciTextReader fibo50 = new FibonacciTextReader(100);
            GenericLoadText(fibo50);
        }
    }
}