// See https://aka.ms/new-console-template for more information

using GenericClasses.Helper;

Console.WriteLine("Hello, World!");

// Icustomer ve Iproduct interfaceleri crud işlemleri 
// yaptığı ve birden fazla objenin her biri için aynı işlemleri yapan
// interfaceler oluşturmamız gerektiği için 
// objelerin hepsi için içine generic atayabileceğimiz genel bir 
// interface olan IRepository oluşturduk (Abstract klasörünün içinde )


string[] list = {"nisa","şevval"};
int[] listInteger =  { 1, 2, 3 };

List<string> genericList = new List<string>();
foreach (var item in list)
{
    genericList.Add(item);
}

Tools tools = new Tools();
List<string> genericList2 = tools.CreateList(list);
foreach (var i in genericList2)
{
    Console.WriteLine(i);
}

// intiger list için 

List<int> genericListInt = tools.CreateList(listInteger);

foreach (var i in genericList2)
{
    Console.WriteLine(i);
}