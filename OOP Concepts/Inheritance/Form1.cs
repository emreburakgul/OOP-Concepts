using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var iskurIdCard = new IskurIdentityCard();
            iskurIdCard.FirstName = "Emre";
            iskurIdCard.LastName = "Aldemir";
            iskurIdCard.CourseName = "Yazılım";
            iskurIdCard.Height = 100;
            iskurIdCard.Width = 200;

            var civilIdCard = new NationalIdentityCard();
            civilIdCard.FirstName = "Emre";
            civilIdCard.LastName = "Aldemir";
            civilIdCard.PlaceOfBirth = "İzmir";
            civilIdCard.Width = 200;

            var card = new Card();
            card.Width = 100;
            card.Height = 75;
            var cardString = card.ToString(); // ToString() metodu object sınıfından geliyor
            // Object sınıfından yalnızca Card sınıfı kalırım alıyor (yazmasak da alıyor)


        }
    }
}
