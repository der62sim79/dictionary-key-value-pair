using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        Dictionary<string, string> germanToEnglishDict = new Dictionary<string, string>();

        public Woerterbuch()
        {
            InitializeComponent();
            importCsv();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGermanWord.Text;
            var englishWord = tbEnglishWord.Text;

            if(!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                germanToEnglishDict.Add(germanWord, englishWord );
                UpdateTranslations();
            }


        }

        private void UpdateTranslations()
        {
            lBoxGermanWords.DataSource = germanToEnglishDict.Keys.ToList();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;
            if(!string.IsNullOrEmpty(selectedWord) && germanToEnglishDict.ContainsKey(selectedWord))
            {
                tbTranslation.Text = germanToEnglishDict[selectedWord];
            }
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {

           using(var writer = new StreamWriter(@"C:\Users\DCV\Desktop\dic.csv"))
            {
                foreach(var pair in germanToEnglishDict)
                {
                    writer.WriteLine("{0};{1};", pair.Key, pair.Value);
                }
            }
        }

        private void importCsv()
        {

            var pairs = File.ReadLines(@"C:\Users\DCV\Desktop\dic.csv")
                .Select(line => line.Split(';'))
                .Select(x => new { german = x[0], others = x[1] });

            germanToEnglishDict.Clear();

            pairs.ToList().ForEach(x => germanToEnglishDict.Add(x.german, x.others));
            
            UpdateTranslations();
        }
    }
}
