using OOPInheritance_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPInheritance_1
{
    public partial class Form1 : Form
    {

        /*
                        ****Inheritance Miras Alma/Verme
                        *
                        *Eger yarattıgınız bir sınıfın ögelerini baska sınıflarda da kullanmak istiyorsanız bu ögeleri tekrar tekrar yazmak geliştirilebilirlik, tekrar kullanılabilirligi ve yonetilebilirligi tamamen kapatacaktır...Aynı zamanda kod tekrar yaptıgınız icin genel sablonda bir degişiklik yapmak istediginiz takdirde tek tek tüm o özellikleri yazdıgımız sınıflarda degişikligi uygulamak zorunda kalacagız...
                        *
                        *
                        *Inheritance, bir sınıfın baska bir sınıfa kalıtım vermesidir...Bir sınıfa kalıtım veren sınıf ona tüm ögelerini aktarır. Özelliklerini bir sınıfa aktaran bir class'a base class deriz...Kalıtım alan sınıflara da türeyen sınıflar (derived clas) denir...Parent child ilişkisi gibi yaklasabilirsiniz...
                        *
                        *Mesela bir Ucak sınıfı düsünün...Aynı zamanda YolcuUcagı ve SavasUcagı sınıflarımız da olsun...YolcuUcagi ve SavasUcagi Ucak özelliklerini almak zorundadır...Bu durumda aslında iki farklı sınıf olsalar da Ucak sınıfından miras alacaklardır...Kalıtım veren sınıf Ucak sınıfı oldugundan dolayı base class'imiz Ucak olur...YolcuUcagi ve SavasUcagi ise base class'tan türeyen mirascı (derived,child) class'lardır...
                        *
                        *C#'ta Multi-Inheritance destegi yoktur...Yani bir sınıf sadece bir sınıftan miras alabilir...Tabii ki bu kesinlikle bir sınıfın istedigi kadar sınıfa miras veremeyecegi anlamına gelmez... 
                        *
                        *Zincirleme miras yapabilirsiniz...
                        *
                        *
                        *
                        *Protected erişim belirteci ile tanımlanmıs bir yapı sadece ve sadece o ilgili sınıfın miras verdigi alanlardan direkt olarak veya kendi icerisinde kullanılabilir...
                        *
                        *
                        *Protected internal
                        *Protected internal erişim belirteci : Bir yapının protected gibi de internal gibi de davranabildigini belirtir..(yani bir yapı hem kendi yaratıldıgı proje icerisinde kullanılabilir... Ayrı olarak miras verdigi yapılarda da (baska projede olsa dahi) kullanılır...
                        *
                        *Eger bir class miras alıyorsa miras aldıgı yapıdan daha kapsayıcı bir erişim belirtecine sahip olamaz...
                        *
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Personel p = new Egitmen();

            //List<Personel> personeller = new List<Personel>();
            //personeller.Add(new Mudur());
            //personeller.Add(new Egitmen());
            //personeller.Add(new Danisman());

            Personel egt = new Egitmen();
            //egt.Email => görüldügü üzere Email protected internal oldugu icin internal özelligi sayesinde yaratıldıgı proje icerisinde kullanılabiliyor aynı zamanda protected da oldugu icin miras verildigi yerde de gözlemlerseniz orada da kullanılabilecegini görürsünüz...

           
          



        }
    }
}
