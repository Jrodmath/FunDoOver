using NotepadClasses;
using System.IO;
using System.Text;
using System.Windows.Forms.Design;

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
            /*if (readFile == TextReader.Null)
            {
                throw new FileNotFoundException();
            }

            if (textBox1 != null)
            {
                textBox1.Clear();
            }

            string s = readFile.ReadToEnd().ToString();*/
            GenericLoadTextClass myLoader = new GenericLoadTextClass();
            string s = myLoader.GenericLoadTextOther(readFile);

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

        private void saveFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
                using StreamWriter sw = new StreamWriter(s);
                {
                    sw.Write(textBox1.Text);
                }
            }
        }
    }
}