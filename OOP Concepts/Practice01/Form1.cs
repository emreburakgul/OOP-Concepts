using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice01
{
    /*
     * Person
    - FirstName read/write
    - LastName read/write
    - FullName read

    Form1 sınıfında
    - txtFirstName
    - txtLastName
    - txtFullName (readonly)

    1. Aşama: Formdaki bir butona basınca txtFullName'de nesnenin tam adı görüntülensin
    2. Aşama: TextBox değerleri değiştikçe txtFullName'in değeri değiştirilsin
     (Butona basmaksızın)
     */

    public partial class Form1 : Form
    {
        // field'lar, nesnenin yaşam süresi boyunca nesne içerisinde
        // saklanacaktır (özellikle içindeki değer silinmediği sürece)
        // private field'lara sınıf içerisinde istediğim her metot içerisinden
        // erişebilirim.

        // Çok istisnai bir durum olmadığı sürece field'lar mutlaka private
        // veya protected olmalıdır. Diğer bir değişle; asla public olmamalıdır

        // field isimlerine mutlaka _ (alt tire) sembolü ile başlayın

        // Sınıf içerisine, metot gövdesine yazdığım gibi normal kodlama
        // yapamam. Sınıf içerisine yalnızca üye tanımlaması yapabilirim
        // Üye: Field, Property, Method, Constructor, Event (, Nested Class)

        // string name = ""; bu tanımlanan şey değişken değil field
        // name = "Tsubasa"; ve ben class gövdesinde field değerini değiştiremem
        // name.Trim(); ve class gövdesinde statement/expression çalıştıramam,
        // metot çağıramam!!

        // Field'lara (ve properylere) ilk değer atanması işlemine
        // initialize denir.
        // Initial: ilk durum
        // Initialize: ilk durumuna getirme (ilk değerini atama)
        private Person _person = new Person();

        // Bir event handler metodunu farklı nesnelerin eventlerine
        // bağlayabilirsiniz. Ancak bunun şartı her iki event'in de aynı
        // delegate tipinde olmasıdır...

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            _person.FirstName = txtFirstName.Text.Trim();
            _person.LastName = txtLastName.Text.Trim();

            txtFullName.Text = _person.FullName;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var person = new Person();
            person.FirstName = txtFirstName.Text.Trim();
            person.LastName = txtLastName.Text.Trim();

            txtFullName.Text = person.FullName;
        }
    }
}
