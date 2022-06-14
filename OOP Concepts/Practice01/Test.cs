using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice01
{
    class Test
    {

        int number01;
        // field'ları asla access modifier olmadan tanımlamayın
        // fieler'ları mutlaka isminin en başında _ olacak şekilde yazın
        // Ve bu satırda yaptığım işlemin adı: Initialize etmeden field tanımlama
        // Yalnızca field tanımlama

        private int _number02;
        // Uygun formatta field tanımlama hemen bir üstteki satırda olduğu gibidir
        // Üstteki satırda yaptığım işlem; Initialize ederek Field tanımlama
        // Field'ı tanımlama ve ilk değerini verme

        private string _name = "Default";

        public Test()
        {
            _number02 = 10;

            var total = number01 + _number02;
            // yukarıdaki işlemde number01 isimli field'a ilk değer verilmemiş
            // olmasına rağmen dotnet tarafından runtime'da o field'ın ilk
            // değeri otomatik olarak 0 belirlenir
            // sanki constructor metodun ilk satırında number01 = 0; gibi
            // bir işlemin yapıldığını düşünebilirsiniz

            int n01;
            int n02 = 10;

            //var total02 = n01 + n02;
            // n01 bir değişkendir, ve ilk değer ataması yapılmadığı için
            // asla ve asla bir işlem içerisinde kullanamam!!

            // Yarın bir gün alttaki satırları görünce kafanız karışmasın diye
            // not :)
            // Constructor metotta yazılmış bir sürü kod olabilir
            // Bunu anlatabilmek için öylemesine rastgele kodlar yazdık
            // ve field'ların ilk değerinin atanması işleminin, Constructor
            // metotta ilk satıra yerleştirildiğini anlatmak için aşağıdaki
            // saçmalama/dummy kod yazılmıştı
            var button = new Button();
            button.Text = "Kaydet";
            //
            //
            //

            while (true)
            {

            }

        }

        // overload
        // aynı metodun aynı isimle ancak farklı parametrelerle
        // bir nevi farklı versiyonlarının yazılması
        public Test(string name)
        {
            
        }

        // **************************************************** //
        // GENEL YAZILIMCILIK İLE İLGİLİ ÇOK ÇOK TEMEL BİLGİLER
        // Çalışan kodlar yalnızca metotlardır!!

        // Daha önce bahsettiğimiz;
        // 1. Kodlar yukarıdan aşağıya yürütülür
        // 2. Karar kontrol yapılarıyla (if/if-else/switch) kod akışını
        // kontrol edebilirim
        // 3. Döngü kontrol yapılarıyla kod akışını ve tekrarı kontrol
        // edebilirim
        // Kuralları METOT İÇERİSİNDEN BAHSEDER!!

        // Haliyle; yukarı yazılan kodlama kuralları yalnızca metot içerisine
        // kod yazarken geçerlidir. Diğer bir değişle; sınıf içerisine
        // sırayla çalışacak kod yazamam, if-else yapısını yazamam, döngü
        // yazamam

        // Breakpoint özünde yalnızca METOTLARIN içerisine eklenebilir
    }
}
