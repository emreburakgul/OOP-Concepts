using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Arrays hatırlatma
            int[] numbers = new int[10];
            string[] names = new string[5];

            long[] values = new long[] { 100, 200, 300, 400 };

            // Dizinin boyutunu bu şekilde 1 arttırıyorduk
            Array.Resize(ref values, values.Length + 1);

            // Dizinin boyutunu bu şekilde 1 azaltabiliyorduk
            Array.Resize(ref values, values.Length - 1);

            // Dizinin bütün elemanlarını silmek, 0 boyutlu yeni bir
            // dizi oluşturmak
            Array.Resize(ref values, 0);

            // Collections
            ArrayList arrayList = new ArrayList();
            var arrayListCount = arrayList.Count; // ArrayList'in mevcut boyutu

            // Hatta daha genel bir ifadeyle; koleksiyonların boyutu Count property'si
            // üzerinden okunabilir
            // Diziler için aynı değeri Length property'si ile okuyabiliyordum..

            arrayList.Add(100);
            arrayList.Add(200);
            arrayList.Add(300);
            arrayList.Add(400);
            //arrayList.Add("Tsubasa");

            var firstItem = arrayList[0];
            var lastItem = arrayList[arrayList.Count - 1];

            //var firstNumber = (int)firstItem;
            var firstNumber = (int)arrayList[0];
            var lastNumber = (int)arrayList[arrayList.Count - 1];

            var total = firstNumber + lastNumber;

            arrayList.Remove(100); // İlk gördüğü 100 değerini silecek
            arrayList.RemoveAt(0); // İlk elemanı silmek için
            arrayList.RemoveAt(arrayList.Count - 1); // Son elemanı silmek için
            arrayList.RemoveRange(0, 5); // 0'ıncı index'ten başla, 5 eleman sil

            arrayList.Clear(); // Bütün elemanları sil

            // TYPE CHECK (tip kontrolü)
            // Upcast yapılmış bir değerin aslında hangi tipte olduğunun kontrolü

            // is keyword'ü biraz daha yeni bir keyword
            if (arrayList[0] is int)
            {
                var number = (int)arrayList[0];
            }

            // is'den önce type check işlemi bu şekilde yapılıyordu
            if (arrayList[0].GetType() == typeof(int))
            {
                var number = (int)arrayList[0];
            }

            // ArrayList'in bu kullanım zorluklarından dolayı...

            // Generic Collections

            //List<int> list = new List<int>();
            var list = new List<int>();
            // Generic; bir sınıfın başka bir tip parametresiyle zenginleştirilmesi
            // Tip isminin parametre olarak kullanıldığı sınıflar

            list.Add(100); // Generic List'e eleman ekleme
            //list.Add("Tsubasa"); // Bu satırı derleyemezsin

            var firstElement = list[0]; // İlk elemanı okuma (doğrudan int tipinde)
            var lastElement = list[list.Count - 1]; // son elemanı okuma (hep aynı, ezberlemeyin)

            list[0] = 200; // i'inci elemanın değerini atama

            list.Remove(100); // ArrayList ile yine aynı, ilk gördüğü 100 değerini çıkartacak


            // Dizi oluştururken dizinin boyutunu en baştan bildirmem gerekiyordu
            var namesArray = new string[3];
            namesArray[0] = "Tsubasa";

            // Koleksiyonlarda böyle bir durum yok, güzelliklerinden birisi de bu
            var playerNames = new List<string>();
            playerNames.Add("Tsubasa");
            playerNames.Add("Misaki");
            playerNames.Add("Hyuga");
            //playerNames.Add(100); // Bu sefer de bu instance'a int ekleyemem, derleme hatası

            playerNames[1] = "Genzo";

            playerNames.Remove("Hyuga");
            playerNames.RemoveAt(0);
            playerNames.Clear();

            // Initialize ederek instance oluşturma
            var players = new List<string>()
            {
                "Tsubasa",
                "Misaki",
                "Hyuga"
            };

            // Dictionary
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Elma", "Apple");
            dictionary.Add("Portakal", "Orange");

            var fruit01 = dictionary["Elma"]; // fruit01 değişkeninin değeri "Apple" string'i
            var fruit02 = dictionary["Portakal"]; // fruit02 değişkeninin değeri "Orange"

            dictionary["Elma"] = "APPLE";

            dictionary.Remove("Elma"); // Elma anahtarında kayıtlı olan Apple silindi

            var dictionary02 = new Dictionary<int, string>();
            dictionary02.Add(100, "Yüz");

            dictionary02[100] = "YÜZ"; // 100 elemanlı bir dizi/koleksiyon gibi düşünülmesin
            // Bu dictionary tipindeki koleksiyonda yalnızca 1 eleman mevcut, o da 100 anahtar
            // değerine sahip cepte tutuluyor

            var dictionary02Size = dictionary02.Count; // Diğer koleksiyonlarda olduğu gibi
            // eleman sayısını yine Count ile okuyabiliyorum

            var dictionary03 = new Dictionary<string, int>();
            dictionary03.Add("Yüz", 100);
            var valueOfYuz = dictionary03["Yüz"];

            // Foreach => her biri için anlamına gelir
            // Bir koleksiyonun elemanlarını ilk değerden son değere kadar tek tek
            // dolaşmak için kullanılır
            // Döngü gibi gözükse de tam olarak bir döngü sayılmaz
            // Foreach yapısına Iteration (iterasyon, yineleme) yapısı denir
            foreach (var item in dictionary03)
            {
                // item değişkeni, bu foreach yineleme yapısının her adımında
                // dictionary03 içindeki, sıradaki eleman olarak atanacaktır
                var itemKey = item.Key; // bu adımdaki elemanın anahtarı
                var itemValue = item.Value; // bu adımdaki elemanın değeri
            }

            // foreach yapısını tüm koleksiyonlar/diziler ile kullanabiliyorum
            foreach (var playerName in playerNames)
            {
                // foreach içerisinde, her adım için oluşturulan değişkenin (şu an playerName)
                // değeri değiştirilemez!! Readonly mantığıyla çalışır (immutable)
                //playerName = "Misaki"; // derlenmez, hata verir
            }

            for (int i = 0; i < playerNames.Count; i++)
            {
                // döngülerde i'inci elemanın değeri değiştirmek kısıtlanmamıştır
                playerNames[i] = "Misaki";
            }

            //string playerName;
            //for (int i = 0; i < playerNames.Count; i++)
            //{
            //    playerName = playerNames[i];
            //}
        }
    }
}
