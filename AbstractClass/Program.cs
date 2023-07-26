using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract class'tan türeyen sınıflara ne yapması gerektiğini
            //söyler,nasıl yapması gerektiğini türeyen sınıf kendi içinde barındırır
            //bu abstract class'tan miras alan class'lar bu abstract class gibi davranır
            Student student1 = new Student();
            //Student(); bu constructer çağırmaya yarar
            // classiçerisinde constructer üretmedik fakat bir class oluştuğunda
            // default olarak bir constructer oluşur
            // bu bizim bu class'tan instance üretmemize yarar
            student1.Talk();
            Console.WriteLine("Student age: " + student1.Age); // set edilmeden çağırıldığında default 0 dönüyor
             
            // abstract class tek başına bir şey ifade etmez ve bir instance üretmemeize izin vermez
            //----------------------------------------
            Console.WriteLine("--------Constructer Kullanımı-------------");
            Console.WriteLine($"Name:{student1.Name},Age:{student1.Age}");
            // abstract class içinden static method çağırılması
            People.WriteSomething();
            // static class amacı değişmeyen, yardımcı classlardır
            
            // dışarda bir class oluşturduk
            AccessModifiersandConstructurs ins1 = new AccessModifiersandConstructurs("mehmet", "somewher");
            //Console.WriteLine($"Name:{ins1.Name},Address:{ins1.Address}"); // burada public ike çağırımı
            // addresi orada private yaptıktan sonra 
            Console.WriteLine($"Name:{ins1.Name},Address:{ins1.getAddress("smwhere")}");
            specialClass specialClass1 = new specialClass("name", "somewher");
            //var mail = specialClass1.Mail; // protected yapınnca hata aldım
            var name = specialClass1.Name;
            // ulaşabildiklerim public olanlar
        }
    }

    public abstract class People
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract void Talk();
        
        public static void WriteSomething(){} // bu nadir bir kullanım 
        // bu metoda people instance oluşturamadığımız için ulaşamamazı gerekir 
        // fakat static old için ulaşabilirz

        public abstract int GetAge();
        // burada void olmamasına rağmen hata vermez
        // çnkü burada içini dolduramayız inherit olunan classlar kendilerine 
        // özgü biçimde doldurmalıdır
    }

    public class Student : People
    {
        public Student(int age,String name) //constructer yaptık,artık bir instance üretilmek istendiğinde
        //bu cons çağırılacak
        {
            base.Age = age; // ilk age parent class'tan gelen age field 
            //ikinci age ise cons çağırılırken
            // yani instance oluşturulurken konulan age
            Name = name;
        }
        public Student() //duruma göre boş ve herhangi params almadan oluşturulması gerekn constructerlar olabilir
        {
            
        }
        public override void Talk() // bunu yazmak zorunlu,çünkü bu inherite edilen class içerisinde abstrack olarak tanımlanan bir method
        {
            Console.WriteLine("i am a student");
            
        }

        public override int GetAge()
        {
            return Age;
        }
        // değişmesini istediğim her ayrı class'da değişeceği için abstract yapılmış bir method
    }

    public class Employer : People
    {
        public override void Talk()
        {
            Console.WriteLine("i am a employer");
        }

        public override int GetAge()
        {
            return Age;
        }
    }
}