using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var button = new Button();
            button.Text = "Button";
            button.Left = 20;
            button.Top = 20;

            var textBox = new TextBox();
            textBox.Left = 20;
            textBox.Top = 70;

            var label = new Label();
            label.Text = "Label";
            label.Left = 20;
            label.Top = 120;

            // Doğrudan Button tipinde bir UI nesnesi eklerken
            Controls.Add(button);

            // farkında olmadan bu aşağıdaki işlem gerçekleşir
            // Aslında Button tipindeki bu nesne, implicit olarak (kapalı)
            // Control tipine cast edilir ve o şekilde Controls koleksiyonuna
            // eklenir. Aşağıdaki satırlarda, biz farketmeden arka planda
            // nasıl bir Cast işlemi gerçekleşiyor onu görmeye çalıştık.
            // Tabii ki de, bizim aşağıdaki gibi bir explicit (açık) cast
            // etme işlemi yapmamıza gerek yok..
            var buttonAsControl = (Control)button;
            Controls.Add(buttonAsControl);

            // Eğer cast işlemi OOP dillerde mümkün olmasaydı, Form'un Controls koleksiyonuna
            // sadece aşağıdaki gibi, neredeyse hiç anlamı olmayan Control tipinde instance'lar
            // ekleyebilirdim. TextBox, Button, ComboBox vs.. hiçbirini forma ekleyemezdim
            var control = new Control();
            Controls.Add(control);


            // Instance alıyorum
            // Upcast
            Control labelControl = new Label();
            Control buttonControl = new Button();
            Control textBoxControl = new TextBox();

            // Yukarıdaki satırlarda kapalı olarak gerçekleşen cast işlemi
            // arka planda aşağıdakine benzer bir işlem gerçekleştiriyor şeklinde
            // düşünülebilir. TextBox tipinde bir instance oluşuyor ve bu instance Control
            // tipinde bir değişkene atanıyor.
            // Yukarıdaki ile farkı; biri implicit diğeri explicit şekilde yazılmış durumda
            var textBox02 = new TextBox();
            var textBoxControl02 = (Control)textBox02;
            

            var comboBox = new ComboBox();
            comboBox.SelectedIndex = -1;

            // Atalarına doğru upcast edilmiş bir nesnenin, kendi sınıfında tanımlanmış
            // üyelerine erişim sağlayamam. Bu doğal bir sonuçtur.
            Control comboBoxControl = comboBox;
            //comboBoxControl.SelectedIndex = -1; // Bu satır doğal olarak bir derleme hatasıdır
            
            

        }
    }
}
