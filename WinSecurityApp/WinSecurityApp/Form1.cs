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

namespace WinSecurityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = EncryptionTriDes(textBox1.Text);
        }

        private static String hashbytes = "Azqhahayel";
        public static String EncryptionTriDes(String value) {
            byte[] keys;
            byte[] data;
            byte[] result;
            SHA1 mdb5 = new SHA1CryptoServiceProvider();

          //  MD5CryptoServiceProvider mdb5 = new MD5CryptoServiceProvider();
            data = UTF8Encoding.UTF8.GetBytes(value);
            keys = mdb5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashbytes));
            TripleDESCryptoServiceProvider triDesTest = new TripleDESCryptoServiceProvider();
            triDesTest.Key = keys;
            triDesTest.Mode = CipherMode.ECB;
            triDesTest.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformer = triDesTest.CreateEncryptor();
            result = transformer.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }


        public static String DecryptionTriDes(String value)
        {
            byte[] keys;
            byte[] data;
            byte[] result;
            SHA1 mdb5 = new SHA1CryptoServiceProvider();
           // MD5CryptoServiceProvider mdb5 = new MD5CryptoServiceProvider();
            data = Convert.FromBase64String(value);
            keys = mdb5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hashbytes));
            TripleDESCryptoServiceProvider triDesTest = new TripleDESCryptoServiceProvider();
            triDesTest.Key = keys;
            triDesTest.Mode = CipherMode.ECB;
            triDesTest.Padding = PaddingMode.PKCS7;
            ICryptoTransform transformer = triDesTest.CreateEncryptor();
            result = transformer.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox3.Text=  DecryptionTriDes(textBox2.Text);
        }
    }
}
