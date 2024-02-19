// See https://aka.ms/new-console-template for more information
using CSharp12News;
using CSharp12News.PrimaryConst;

var primaryConst = new PrimaryConst("Selçuk", 28);
Console.WriteLine(primaryConst.ToString());
var primaryConst2 = new PrimaryConst("Selçuk", 28, "Software Engineer");
Console.WriteLine(primaryConst2.ToString());
var intBase = new InitBase("Selçuk");
Console.WriteLine(intBase.SomeMethod());