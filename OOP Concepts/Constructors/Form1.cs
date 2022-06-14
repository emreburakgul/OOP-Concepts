using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var random = new Random();
            var button = new Button();

            // new keyword'ünün yanında çağırdığımız, bir sınıftan (veya struct'tan)
            // yeni bir nesne oluşturan metoda CONSTRUCTOR metot denir


            // idCard değişkeninin tuttuğu heap adresi => 0x1234
            var idCard = new NationalIdentityCard("Tsubasa", "Ozora");
            // Ben isim-soyisim bilgisini nesneyi ilk oluşturuken tanımlayayım
            //idCard.FirstName = "Misaki"; // Sonrasında bu bilgi değiştirilemesin

            MessageBox.Show(idCard.FirstName + " " + idCard.LastName);

            //idCard.FirstName = "Misaki";
            //idCard.LastName = "Taro";

            //idCard.LastName = "Taro";

            // idCard değişkeninin tuttuğu heap adresi => 0x5678
            // Bu satırda ben yeni bir nesne oluşturuyorum. Bu işlem aynı nesnenin
            // bir değerini değiştirmek anlamına GELMEZ!!11!!1!
            idCard = new NationalIdentityCard("Tsubasa", "Taro");

            // Eğer bir sınıfa en az bir tane constructor metodu siz yazdıysanız
            // otomatik olarak oluşturulan public/parametresiz constructor metot
            // artık oluşturulmaz!!
            // var idCard2 = new NationalIdentityCard(); => Bu satır derleme hatası verir.

            //idCard.FirstName = "Tsubasa";
        }
    }
}
