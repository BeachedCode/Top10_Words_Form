using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beach_Ethan_Assign_5
{
    public partial class Form1 : Form
    {
        private string selectedFilePath1;
        private string selectedFilePath2;
        public Form1()
        {
            InitializeComponent();
        }

        private string BrowseForFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }

        private async void btnBrowse1_Click(object sender, EventArgs e)
        {
            selectedFilePath1 = BrowseForFile();
            if (!string.IsNullOrEmpty(selectedFilePath1))
            {
                await ProcessFileAsync(selectedFilePath1, listBox1);
                txtFilePath1.Text = Path.GetFileName(selectedFilePath1);
            }
        }

        private async void btnBrowse2_Click(object sender, EventArgs e)
        {
            selectedFilePath2 = BrowseForFile();
            if (!string.IsNullOrEmpty(selectedFilePath2))
            {
                await ProcessFileAsync(selectedFilePath2, listBox2);
                txtFilePath2.Text = Path.GetFileName(selectedFilePath2);
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            await ProcessFileAsync(txtFilePath1.Text, listBox1);
            await ProcessFileAsync(txtFilePath2.Text, listBox2);
        }

        private async Task ProcessFileAsync(string filePath, ListBox listBox)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string fileContent = await ReadFileAsync(filePath);
                    var topWords = await GetTopWordsAsync(fileContent);
                    DisplayTopWords(topWords, listBox);
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async Task<string> ReadFileAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        private async Task<Dictionary<string, int>> GetTopWordsAsync(string content)
        {
            return await Task.Run(() =>
            {
                var words = Regex.Split(content, @"\W+")
                    .Where(word => !string.IsNullOrWhiteSpace(word))
                    .Select(word => word.ToLower());

                var wordCount = new Dictionary<string, int>();

                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }

                return wordCount.OrderByDescending(kvp => kvp.Value)
                                .Take(10)
                                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            });
        }

        private void DisplayTopWords(Dictionary<string, int> topWords, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var kvp in topWords)
            {
                listBox.Items.Add($"{kvp.Key}: {kvp.Value} times");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}