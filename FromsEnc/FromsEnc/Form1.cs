using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using EasyEncryption;

namespace FromsEnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            var md5 = EasyEncryption.MD5.ComputeMD5Hash(input);

            textBox2.Text = md5;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input_valid = textBox4.Text;
            bool CheckVailid = EasyEncryption.MD5.IsValidMD5(input_valid);

            if (CheckVailid == true)
            {

                label4.Text = "Valided (Md5)";

            }
            else
            {
                label4.Text = "Not Valided (Md5)";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input_sha1 = textBox5.Text;
            string encrypt_sha1 = EasyEncryption.SHA.ComputeSHA1Hash(input_sha1);

            textBox3.Text = encrypt_sha1;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input_sha256 = textBox7.Text;
            string encrypt_sha256 = EasyEncryption.SHA.ComputeSHA1Hash(input_sha256);
            textBox6.Text = encrypt_sha256;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string text = textBox15.Text;
            string key = "12345678901234567890123456789012"; // 32 bytes for AES key (256-bit)
            string iv = "1234567890123456";  // 16 bytes for AES IV (128-bit)
            string encryptedString = EasyEncryption.AES.Encrypt(text, key, iv);
            textBox14.Text = encryptedString;
          


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox15.Text;
            string key = "12345678901234567890123456789012"; // 32 bytes for AES key (256-bit)
            string iv = "1234567890123456";  // 16 bytes for AES IV (128-bit)

            string enc = textBox13.Text;
            string decryptedString = EasyEncryption.AES.Decrypt(enc, key, iv);
            textBox12.Text = decryptedString;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = textBox9.Text;
            string key = "12345678"; 
            string iv = "12345678"; 
            string encryptedString = EasyEncryption.DES.Encrypt(text, key, iv);
            textBox8.Text = encryptedString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text = textBox11.Text;
            string key = "12345678";
            string iv = "12345678";
            string encryptedString = EasyEncryption.DES.Decrypt(text, key, iv);
            textBox10.Text = encryptedString;
        }
    }
}