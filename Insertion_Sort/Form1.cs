namespace Insertion_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = textBox1.Text.Split().Select(int.Parse).ToArray();
            int i, key, j;
            for (i = 1; i < numbers.Length; i++)
            {
                key = numbers[i];
                j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }
            for (i = 0; i < numbers.Length; i++)
            {
                textBox2.Text += (Convert.ToString(numbers[i]) + " ");
            }
        }
    }
}