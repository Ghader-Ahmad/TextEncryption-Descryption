using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEncryption_Descryption.Properties;
using System.Threading;
using System.Net.Http.Headers;

namespace TextEncryption_Descryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Byte Index = 0; 

        private string EncryptionText(string Text, Byte Key)
        {
            char[] EncryptText = new char[Text.Length];

            for (int i = 0; i < Text.Length; i++)
            {
                EncryptText[i] = Convert.ToChar((Convert.ToByte(Text[i]) + Key));
            }

            return new string(EncryptText);
        }

        private string DescryptionText(string Text, Byte Key)
        {
            char[] DescryptText = new char[Text.Length];

            for (int i = 0; i < Text.Length; i++)
            {
                DescryptText[i] = Convert.ToChar(Convert.ToByte(Text[i] - Key));
            }
            
            return new string(DescryptText);
        }


        private bool ValidationText(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text) || textbox.Text == "Please Enter The Text!")
            {

                MessageBox.Show("Please Enter the Text!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox.Focus();
                return false;
            }

            else
                return true;
        }

        private string GetText()
        {
            return txtEText.Text;
        }
        private string GetEncryptText()
        {
            return txtDText.Text;
        }

        private Byte GetCryptionKey()
        {
            return Convert.ToByte(lblKey.Text);
        }



        private void UpdateUIForPrgressParEncryption(bool Bool)
        {
            btnEncryptionText.Visible = !Bool;

            lblProgressEncrypt.Visible = Bool;
            pbEncrypt.Visible = Bool;

            pbEncrypt.Value = 0;

        }

        private void UpdateUIForPrgressParDescryption(bool Bool)
        {
            btnDescryptionText.Visible = !Bool;

            lblProgressDescrypt.Visible = Bool;
            pbDescrypt.Visible = Bool;

            pbDescrypt.Value = 0;
        }



        private void IncreaseEncryptionProgressPar()
        {
            UpdateUIForPrgressParEncryption(true);

            for (int i =0; i < 11; i++)
            {
                if (pbEncrypt.Value < pbEncrypt.Maximum)
                {
                    Thread.Sleep(100);

                    pbEncrypt.Value += 10;
                    lblProgressEncrypt.Text = (((float)pbEncrypt.Value / pbEncrypt.Maximum) * 100) + "%";

                    pbEncrypt.Refresh();
                    lblProgressEncrypt.Refresh();
                }
                else
                    UpdateUIForPrgressParEncryption(false);
            }
        }

        private void IncreaseDescryptionProgressPar()
        {
            UpdateUIForPrgressParDescryption(true);

            for (int i = 0; i < 11; i++ )
            {
                if (pbDescrypt.Value < pbDescrypt.Maximum)
                {
                    Thread.Sleep(100);

                    pbDescrypt.Value += 10;
                    lblProgressDescrypt.Text = (((float)pbDescrypt.Value / pbDescrypt.Maximum) * 100) + "%";

                    pbDescrypt.Refresh();
                    lblProgressDescrypt.Refresh();
                }

                else
                    UpdateUIForPrgressParDescryption(false);
            }

        }



        private void ConvertTextToEncryptionText()
        {
            string Text = GetText();
            if (!ValidationText(txtEText))
                return;

            IncreaseEncryptionProgressPar();
            Byte Key = GetCryptionKey();

            if (MessageBox.Show("Text Encrypted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                btnClearEncrypt.Visible = true;

            txtEEncryptText.Text = EncryptionText(Text, Key);
        }

        private void ConvertTextToDescryptionText()
        {
            string Text = GetEncryptText();
            if (!ValidationText(txtDText))
                return;


            IncreaseDescryptionProgressPar();
            Byte Key = GetCryptionKey();

            if (MessageBox.Show("Text Decrypted!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                btnClearDescrypt.Visible = true;

            txtDDescryptText.Text = DescryptionText(Text, Key);
        }



        private void WhiteTheme()
        {
            this.BackColor = Color.White;
            lblTitle.ForeColor = Color.Coral;
            lblDateAndTime.ForeColor = Color.Black;

            pDescryption.BackColor = Color.Navy;
            pEncryption.BackColor = Color.Lime;

            tbKey.BackColor = Color.GreenYellow;

            btnEncryptionText.BackColor = Color.PaleTurquoise;
            btnDescryptionText.BackColor = Color.PaleTurquoise;

        }

        private void DarkTheme()
        {
            this.BackColor = Color.Black;
            lblTitle.ForeColor = Color.Peru;
            lblDateAndTime.ForeColor = Color.White;

            pEncryption.BackColor = Color.DarkGreen;
            pDescryption.BackColor = Color.FromArgb(0, 0, 64);

            tbKey.BackColor = Color.ForestGreen;

            btnDescryptionText.BackColor = Color.DarkMagenta;
            btnEncryptionText.BackColor = Color.SaddleBrown;
        }

        private void ChangeTheme()
        {
            if (btnTheme.Tag.ToString() == "1")
            {
                btnTheme.BackgroundImage = Resources.WhiteTheme;
                btnTheme.Tag = 2;
                WhiteTheme();
            }

            else 
            {
                btnTheme.BackgroundImage = Resources.BlackTheme;
                btnTheme.Tag = 1;
                DarkTheme();
            }
        }


        private void SetImageLock(Byte Index)
        {
            if (Index == 0)
                pbLock.Image = Resources.CloseLock;

            else
                pbLock.Image = Resources.OpenLock;
        }



        private void ClearEncyptionText()
        {
            txtEEncryptText.Clear();
            btnClearEncrypt.Visible = false;
        }

        private void ClearDescrptionText()
        {
            txtDDescryptText.Clear();
            btnClearDescrypt.Visible = false;
        }

        private void ClearTextBoxes (Control Parent)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                }

                else if (control.HasChildren)
                {
                    ClearTextBoxes(control);
                }
            }
        }

        private void CloseThisForm()
        {
            if (MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void Copy()
        {
            if (ActiveControl is TextBox textbox)
            {
                Clipboard.SetText(textbox.SelectedText);
            }
        }

        private void Past()
        {
            if (ActiveControl is TextBox textbox)
            {
                int selectionStart = textbox.SelectionStart;

                textbox.Text = textbox.Text.Insert(selectionStart, Clipboard.GetText());

                textbox.SelectionStart = selectionStart + Clipboard.GetText().Length;
            }
        }

        private void Cut()
        {
            if (ActiveControl is TextBox textbox)
            {
                Clipboard.SetText(textbox.SelectedText);
                textbox.SelectedText = string.Empty;
            }
        }

        private void Delete()
        {
            if  (ActiveControl is TextBox textBox)
            {
                textBox.Clear();
            }
        }



        private void tbKey_Scroll(object sender, EventArgs e)
        {
            lblKey.Text = tbKey.Value.ToString();
        }

        private void btnEncryptionText_Click(object sender, EventArgs e)
        {
            ConvertTextToEncryptionText();
        }

        private void btnDescryptionText_Click(object sender, EventArgs e)
        {
            ConvertTextToDescryptionText();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void pbEncrypt_Click(object sender, EventArgs e)
        {
            lblProgressEncrypt.Text = pbEncrypt.Value.ToString();
        }

        private void txtEText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();

                errorProvider1.SetError(((TextBox)sender), "Please enter a Text!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        private void btnClearEncrypt_Click(object sender, EventArgs e)
        {
            ClearEncyptionText();
        }

        private void btnClearDescrypt_Click(object sender, EventArgs e)
        {
            ClearDescrptionText();
        }





        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CloseThisForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt");
            if (Index == 0)
            {
                SetImageLock(Index);
                Index = 1;
            }
            else
            {
                SetImageLock(Index);
                Index = 0;
            } 
                
        }


        private void txtEText_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = "Please Enter The Text!";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }

        private void txtEText_Enter_1(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "Please Enter The Text!")
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Past();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
