using System;
using System.Collections;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //sınıflar gibi sıkça kullanılır
            string[] stu =  { "e", "k", "b" };
            stu[0] = "c";
            // bununla ilk değeri kaybediyor olmam zorluk 
            // sebebi de referans tipli değişken 
            ArrayList list = new ArrayList();
            list.Add("2");// obje olarak istediği koyabilirim
            list.Add(2);

            List<string> liste1 = new List<string>();
            liste1.Add("100");
            var x = liste1.Count(); // kaç item in liste
            var y = liste1.Contains("1000");
            liste1.AddRange(liste1); // içine başka bir liste koymak
            //----liste örneği--------------------
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "emir",
                Email = "..."
            };
            Customer c2 = new Customer()
            {
                Id = 2,
                Name = "emir2",
                Email = ".-.-."
            };
            Customer c3 = new Customer()
            {
                Id = 2,
                Name = "emir3"
            };
            c3.Email = "emir3.dd";

            List<Customer> customerList = new List<Customer>()
            {
                new Customer()
                {
                    Id = 3,
                    Name = "seda",
                    Email = "seda..."
                }
            };
            customerList.Add(c1);
            customerList.Add(c2);
            customerList.Add(c3);

            foreach (var i in customerList)
            {
                Console.WriteLine(i.Name);
            }
            list.Remove(
                c1 
            );

            list.Contains(
                c1 
            );
            //------Dictionary------------
            //key/ value

            Dictionary<string, string> dic = new  Dictionary<string, string>();
            dic.Add("name","lale");
            var dicResult = dic["name"];
            
            Dictionary<string,int> dicInt =new  Dictionary<string,int>();

            dicInt.Add("bir",100);
            dicInt.Add("iki",900);

            // ayriyeten dic.ContainKey and dic.ContainValue metodları var 
        }
    }
}