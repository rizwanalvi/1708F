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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = MyEncryptionTriDes(txtValue.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = MyDecryptionTriDes(txtEncrypt.Text);
        }

        private static String hasbytes = "fxgyL";
        public static String MyEncryptionTriDes(String value) {
            byte[] keys;
            byte[] data;
            byte[] results;

            MD5CryptoServiceProvider mdb5 = new MD5CryptoServiceProvider();
            data = UTF8Encoding.UTF8.GetBytes(value);
            keys = mdb5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hasbytes));
            TripleDESCryptoServiceProvider tripeDesA1 = new TripleDESCryptoServiceProvider();
            tripeDesA1.Key = keys;
            tripeDesA1.Mode = CipherMode.ECB;
            tripeDesA1.Padding = PaddingMode.PKCS7;
            ICryptoTransform transfomer = tripeDesA1.CreateEncryptor();
           results = transfomer.TransformFinalBlock(data, 0, data.Length);                         
           return Convert.ToBase64String(results);
        }

        public static String MyDecryptionTriDes(String value)
        {
            byte[] keys;
            byte[] data;
            byte[] results;
            MD5CryptoServiceProvider mdb5 = new MD5CryptoServiceProvider();
            data = Convert.FromBase64String(value);
            keys = mdb5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hasbytes));
            TripleDESCryptoServiceProvider tripeDesA1 = new TripleDESCryptoServiceProvider();
            tripeDesA1.Key = keys;
            tripeDesA1.Mode = CipherMode.ECB;
            tripeDesA1.Padding = PaddingMode.PKCS7;
            ICryptoTransform transfomer = tripeDesA1.CreateDecryptor();
            results = transfomer.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(results);
        }
    }
}
