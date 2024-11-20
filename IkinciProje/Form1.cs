using OOPInheritance_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkinciProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            //egt.Email => Gördügünüz üzere burası farklı bir proje oldugu icin ve buradaki Form1 Personel class'ından miras almadıgı icin Email (protected internal olan property'miz) buradan ulasılamaz bir haldedir...
        }
    }
}
