using DSRSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsCorrectKey()
        {
            string pattern = @"[^0-9]";
            Regex reg = new Regex(pattern);
            if (this.e.Text == "" || this.d.Text == "" || this.n.Text == "")
            {
                return false;
            }

            if (reg.Match(e.Text).Success || reg.Match(d.Text).Success || reg.Match(n.Text).Success)
            {
                return false;
            }

            return true;
        }

        private bool IsCorrectSignature()
        {
            string pattern = @"[^0-9]";
            Regex reg = new Regex(pattern);
            if (this.sig.Text == "" || reg.Match(sig.Text).Success)
            {
                return false;
            }

            return true;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (this.input.Text == "")
            {
                MessageBox.Show("enter text");
                return;
            }

            if (!IsCorrectKey())
            {
                MessageBox.Show("wrong key entered");
                return;
            }

            if (!IsCorrectSignature())
            {
                MessageBox.Show("wrong signature entered");
                return;
            }

            Key key = new Key(BigInteger.Parse(this.e.Text), BigInteger.Parse(this.n.Text), BigInteger.Parse(this.d.Text));
            DigSignatureRSA rsa = new DigSignatureRSA(key);
            if (rsa.CheckDigitalSignature(this.input.Text, BigInteger.Parse(this.sig.Text)))
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }

        }

        private void GenKey_Click(object sender, EventArgs e)
        {
            KeyGenerator keyGen = new KeyGenerator();
            Key key = keyGen.GenerateKey(32);
            this.e.Text = Convert.ToString(key.e);
            this.n.Text = Convert.ToString(key.n);
            this.d.Text = Convert.ToString(key.d);
        }

        private void GenSig_Click(object sender, EventArgs e)
        {
            if (!IsCorrectKey())
            {
                MessageBox.Show("wrong key entered");
                return;
            }

            Key key = new Key(BigInteger.Parse(this.e.Text), BigInteger.Parse(this.n.Text), BigInteger.Parse(this.d.Text));
            DigSignatureRSA rsa = new DigSignatureRSA(key);
            this.sig.Text = Convert.ToString(rsa.GetDigitalSignature(this.input.Text));
        }
    }
}
