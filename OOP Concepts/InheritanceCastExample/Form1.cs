using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceCastExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            const string text = "Abracadabra";

            for (int i = 0; i < Controls.Count; i++)
            {
                // Aşağıdaki gibi bir işlem yapıyorsak, mesela UI üzerinde yer alan tüm
                // kontrollerin sadece Text özelliğini değiştirmek gibi bir işlem yapıyorsak
                // bu kontrolleri (Controls[i]'yi) tek tek TextBox, ComboBox gibi kendi özüne
                // geri cast etmeye gerek yok. Doğrudan Controls[i].Text property'sini set etmek
                // işimi fazlasıyla görüyor

                // "Ben hariç tüm kontrollerin text'ini değiştir" gibi bir şey isteseydim
                if (Controls[i] != sender)
                {
                    Controls[i].Text = text;
                }

                //if (Controls[i].Name != "btnChange")
                //{

                //}

                //if (Controls[i].Text != "Değiştir")
                //{

                //}
            }
        }

        // Aşağıdaki gibi bir metodu Control tipinde bir parametre ile yazmak müthiş
        // manasız bir işlem. Bunun yerine aşağıdaki alternatif çok daha yakışıklı
        //private void ResetSelectedItem(Control control)
        //{
        //    if (control is ComboBox)
        //    {
        //        var comboBox = (ComboBox)control;
        //        comboBox.SelectedIndex = -1;
        //    }
        //}

        private void ResetSelectedItem(ListControl listControl)
        {
            listControl.SelectedIndex = -1;
        }

        private void btnResetSelectedItem_Click(object sender, EventArgs e)
        {
            // Bu metot artık ListControl tipinde bir parametre beklediği için
            // TextBox instance'ı ile metodu çağıramam. Tam da istediğim durum
            //ResetSelectedItem(textBox1);
            ResetSelectedItem(comboBox1);
            ResetSelectedItem(listBox1);
        }
    }
}
