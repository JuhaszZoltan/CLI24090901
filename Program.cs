using CLI24090901;

List<Keres> keresek = [];
using StreamReader sr = new(@"..\..\..\src\NASAlog.txt");
while (!sr.EndOfStream) keresek.Add(new(sr.ReadLine()));

Console.WriteLine($"5. feladat: keresek szama: {keresek.Count}");

int? osszMeret = keresek.Sum(k => k.Meret);
Console.WriteLine($"6. feladat: Valaszok osszes merete: {osszMeret} byte");

int vanDomain = keresek.Count(k => k.Domain);

Console.WriteLine($"8. feladat: Domain-es keresek: {vanDomain / (float)keresek.Count * 100:0.00}%");

var statisztika = keresek.GroupBy(k => k.Kod)
    .ToDictionary(grp => grp.Key, grp => grp.Count())
    .OrderBy(kvp => kvp.Key);
Console.WriteLine("9. feladat: Statisztika:");
foreach (var kvp in statisztika) 
    Console.WriteLine($"\t{kvp.Key}: {kvp.Value} db");

