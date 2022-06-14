using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // Sınıf tanımının yanına : sembolü koyduktan sonra
    // sağ tarafa yazdığım sınıftan MİRAS/KALITIM alıyorum
    // Kalıtım almanın diğer bir adı, bir sınıfı genişletmek
    // (extend) olarak da kullanılabiliyor

    // Kalıtım/Miras:
    // 01. (Genişletme-extend bakış açısından) Bir sınıfın üyelerinin
    // yeterli olmadığı durumda başka bir sınıf geliştirerek genişletilmesi
    // 02. (Ortak özellikleri bir yere toplama) Birden fazla sınıfın
    // içereceği üyelerin ortak üyeler olması durumunda, bir zemin/alt sınıf
    // oluşturarak bu ortak özelliklerin tek bir sınıfa toplanması, diğer
    // sınıfların bu sınıftan miras alarak üretilmesi

    // Kurallar
    // - Bir sınıf yalnızca tek bir sınıftan kalıtım alabilir
    // - Ancak kalıtım aldığım sınıf yine başka bir sınıftan miras alıyor olabilir
    // - Hiçbir şeyden miras almayan sınıf OTOMATİK OLARAK OBJECT sınıfından kalıtım alır
    // - struct'lar kalıtım alamaz
    // - ANCAK siz bir struct yazıp kalıtım aldıramasanız da o kendisi yine object tipinden
    // türetilir

    // Nüfus Cüzdanı
    class NationalIdentityCard : BaseIdentityCard
    {
        // POCO: Plain Old CLR (CSharp) Object
        // POJO: Plain Old Java Object
        // Yalnızca veri tutan (genellikle sadece auto-property içeren)
        // sınıflara verilen ad/lakab
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long CivilizationNumber { get; set; } // TC
        public string NameOfFather { get; set; }
        public string NameOfMother { get; set; }
    }
}
