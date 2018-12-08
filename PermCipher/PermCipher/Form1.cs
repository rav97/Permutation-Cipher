using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PermCipher
{
    public partial class Form1 : Form
    {
        public string inputText, filepath, exportPath, klucz;
        private bool readFile;
 
        public Form1()
        {
            InitializeComponent();
            manually.CheckState = CheckState.Checked;
            cipher.CheckState = CheckState.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
        private void cipher_CheckedChanged(object sender, EventArgs e)
        {
            switch (cipher.CheckState)
            {
                case CheckState.Checked:
                    decipher.CheckState = CheckState.Unchecked;
                    break;
                case CheckState.Unchecked:
                    decipher.CheckState = CheckState.Checked;
                    break;
            }
        }
        private void decipher_CheckedChanged(object sender, EventArgs e)
        {
            switch(decipher.CheckState)
            {
                case CheckState.Checked:
                    cipher.CheckState = CheckState.Unchecked;
                    break;
                case CheckState.Unchecked:
                    cipher.CheckState = CheckState.Checked;
                    break;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(cipher.CheckState != CheckState.Unchecked || decipher.CheckState != CheckState.Unchecked)
            {
                if (key.Text == "")
                    MessageBox.Show("Nie podano klucza");
                else
                {
                    if (key.Text.Length > 9)
                        MessageBox.Show("Za długi klucz!\nMaksymalna dlugosc klucza: 9");
                    else
                    {
                        if (keyCheck(key.Text))
                        {
                            klucz = key.Text;
                            inputText = input.Text;
                            if (cipher.CheckState == CheckState.Checked)
                            {
                                if(InputCheck(inputText))
                                    output.Text = szyfruj(inputText, klucz);
                                else
                                    MessageBox.Show("Niedozwolone znaki na wejściu.\nDozwolone znaki:\n-Alfabet angielski\n-Znaki specjalne");
                            }
                            if(decipher.CheckState==CheckState.Checked)
                            {
                                if (InputCheck(inputText))
                                    output.Text = deszyfruj(inputText, klucz);
                                else
                                    MessageBox.Show("Niedozwolone znaki na wejściu.\nDozwolone znaki:\n-Alfabet angielski\n-Znaki specjalne");
                            }
                        }
                        else
                            MessageBox.Show("Nieprawidłowy klucz!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Najpierw wybierz czynność!");
            }
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void opFile_Click(object sender, EventArgs e)
        {
            fromFile.CheckState = CheckState.Checked;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                //MessageBox.Show(filepath);
            }
            if (filepath != null)
            {
                if (readFile)
                {
                    FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                    try
                    {
                        StreamReader sr = new StreamReader(fs);
                        inputText = sr.ReadToEnd();
                        input.Text = inputText;
                        sr.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void FileExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(output.Text);
                    MessageBox.Show("Zapisano do pliku:\n"+saveFileDialog1.FileName);
                    sw.Close();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromFile_CheckedChanged(object sender, EventArgs e)
        {
            switch (fromFile.CheckState)
            {
                case CheckState.Checked:
                    opFile.Enabled = true;
                    input.Enabled = false;
                    readFile = true;
                    manually.CheckState = CheckState.Unchecked;
                    break;
                case CheckState.Unchecked:
                    opFile.Enabled = false;
                    input.Enabled = true;
                    readFile = false;
                    manually.CheckState = CheckState.Checked;
                    break;
            }
        }

        private void manually_CheckedChanged(object sender, EventArgs e)
        {
            switch (manually.CheckState)
            {
                case CheckState.Checked:
                    opFile.Enabled = false;
                    input.Enabled = true;
                    readFile = false;
                    fromFile.CheckState = CheckState.Unchecked;
                    break;
                case CheckState.Unchecked:
                    opFile.Enabled = true;
                    input.Enabled = false;
                    readFile = true;
                    fromFile.CheckState = CheckState.Checked;
                    break;
            }
        }
        private bool keyCheck(string key)
        {
            bool tn=true;
            for (int i = 0; i < key.Length; i++)
            {
                if ((int)key[i] < 48 || (int)key[i] > 57)
                {
                    tn = false;
                    break;
                }
            }
            if(tn)
            {
                string keyValid = "123456789";
                string s1 = keyValid.Substring(0, key.Length);
                string s2 = key;
                s2 = String.Concat(s2.OrderBy(c => c));
                if (s1 != s2)
                    tn = false;
            }
            return tn;
        }
        private int[] keyElem(string key)
        {
            int[] tab = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
            {
                tab[i] = (int)key[i] - 49;
            }
            return tab;
        }
        private string szyfruj(string txt, string klucz)
        {
            string szyfr = "";
            int dl_blok = klucz.Length;
            txt = normalizuj(txt, dl_blok);
            int il_blok = txt.Length / dl_blok;
            int[] tab = new int[dl_blok];
            tab = keyElem(klucz);
            char[,] znaki = przepisz(txt, dl_blok, il_blok);
            for (int i = 0; i < il_blok; i++)
            {
                foreach (int k in tab)
                    szyfr += znaki[k, i];
            }
            return szyfr;
        }
        private string deszyfruj(string txt, string klucz)
        {
            string deszyfr = "";
            int dl_blok = klucz.Length;
            txt = normalizuj(txt, dl_blok);
            int il_blok = txt.Length / dl_blok;
            int[] tab = new int[dl_blok];
            tab = keyElem(klucz);
            tab = permOdwr(tab);
            char[,] znaki = przepisz(txt, dl_blok, il_blok);
            for (int i = 0; i < il_blok; i++)
            {
                foreach (int k in tab)
                    deszyfr += znaki[k, i];
            }
            return deszyfr;
        }
        private string normalizuj(string txt, int dl)
        {
            int dop = dl - (txt.Length % dl);
            if (dop != dl)
                for (int i = 0; i < dop; i++)
                {
                    txt += ' ';
                }
            return txt;
        }
        private char[,] przepisz(string txt, int wier, int kol)
        {
            char[,] tab = new char[wier, kol];
            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < wier; j++)
                {
                    int przelicz = ((wier - 1) * i) + (j + i);
                    tab[j, i] = txt[przelicz];
                }
            }
            return tab;
        }
        private int[] permOdwr(int[] tab)
        {
            int[] tab2 = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    if (i == tab[j])
                        tab2[i] = j;
                }
                Console.WriteLine(tab2[i]);
            }
            return tab2;
        }
        private bool InputCheck(string input)
        {
            bool tn = true;
            for(int i=0;i<input.Length;i++)
            {
                if((int)input[i]<32 || (int)input[i]>126)
                {
                    if ((int)input[i] != 13 && (int)input[i] != 10)
                    {
                        tn = false;
                        break;
                    }
                }
                if (input[i] >= '0' && input[i] <= '9')
                {
                    tn = false;
                    break;
                }
            }
            return tn;
        }
    }
}