using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class NationalIdentityCard
    {
        // Constructor metot
        // Bir sınıftan instance oluşturulurken kullanılan metot
        // new keyword'ü ile birlikte çağırılır
        // Constructor metotların DÖNÜŞ TİPİ YOKTUR
        // Constructor metotların İSMİ SINIF İSMİYLE AYNIDIR
        // Biz constructor metot yazmasak da csharp derleyici
        // kendiliğinden public ve parametresiz bir constructor metot oluşturur

        // Diğer bir deyişle, constructor metodu neden kullanılır??
        // Nesnenin ilk oluşturulduğu durumda ilk değerlerinin atanması/belirlenmesi
        // için kullanılır
        // Nesnenin ilk durumu: Durum => State
        public NationalIdentityCard(string firstName, string lastName)
        {
            //_firstName = firstName;
            FirstName = firstName; 
            LastName = lastName;
        }

        // Bir property'i readonly yapmanın alternatif yöntemi
        // Property'de yalnızca get metodunu auto şekilde bırakıp yazabilirsiniz
        // Bu property'ler derlendiğinde yine kendi private (backing) field'ları oluşur
        // ve yalnızca constructor metodunda değeri atanabilir.
        public string FirstName { get; } // auto readonly property

        // Bir property'yi set metodunu silerek Readonly hale getirmenin eski yöntemi
        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //}

        // set metodu private access modifier'ı ile işaretlenerek de bir property
        // readonly hale getirilebilir
        // Ancak!! Bir property'i yalnızca { get; } metodu ile tanımlamak ile
        // { get; private set;} şeklinde tanımlamak arasında ince bir fark var!
        // { get; } şeklinde tanımlanmış property'nin değeri yalnızca constructor içinde atanabilir
        // { get; private set; } property'nin değeri sınıf içerisinde herhangi bir metot
        // tarafından atanabilir
        public string LastName { get; private set; }

        public void UydurukMetot()
        {
            // FirstName = "Misaki"; FirstName { get; } şeklinde tanımlandığından bu satır
            // hatalıdır, proje derlenmez
            LastName = "Taro"; // LastName { get; private set; } olarak tanımlandığından
            // constructor metot dışında da LastName değeri değiştirilebilir (yalnızca bu
            // sınıf içerisinden)
        }
    }
}
