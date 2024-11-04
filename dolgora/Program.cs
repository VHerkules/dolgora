using dolgora;
using System.Text;

List<Versenyzo> versenyzok = [];
using StreamReader sr = new("..\\..\\..\\src\\forras.txt",Encoding.UTF8);

while (!sr.EndOfStream)
{
    versenyzok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"veresenyzok szama: {versenyzok.Count}");

//3csop
var f1 = versenyzok
    .Count(v => v.Kategoria == "25-29");
Console.WriteLine($"versenyzők száma '25-29' korkategóriában: {f1}");

var f2 = versenyzok
    .Average(v => 2024 - v.Szul);
Console.WriteLine($"versenyzők átlagéletkora: {f2:00}");

var f3 = versenyzok
    .Sum(v => v.VersenyIdok["úszás"].TotalHours);
Console.WriteLine($"a versenyzők úszással töltött összideje órában. 2tj-ig kerekítve: {f3:0.00}");

var f4 = versenyzok
    .Where(v => v.Kategoria == "elit")
    .Average(v => v.VersenyIdok["úszás"].TotalMinutes);
Console.WriteLine($"átlagos úszási idő elit kategóriában: {f4:00}");

var f5 = versenyzok
    .Where(v => v.Nem)
    .Min(v => v.Osszido);
Console.WriteLine($"férfi győztes (legrövidebb összidő): {f5}");

//1csop
var f6 = versenyzok
    .Count(v => v.Kategoria == "elit");
Console.WriteLine($"versenyzők száma 'elit' kategóriában: {f6}");

var f7 = versenyzok
    .Where(v => !v.Nem)
    .Average(v => 2024 - v.Szul);
Console.WriteLine($"női versenyzők átlagéletkora: {f7:00}");

var f8 = versenyzok
    .Sum(v => v.VersenyIdok["kerékpározás"].TotalHours);
Console.WriteLine($"a versenyzők kerékpározással töltött összideje órában. 2tj-ig kerekítve: {f8:0.00}");

var f9 = versenyzok
    .Where(v => v.Kategoria == "elit junior")
    .Average(v => v.VersenyIdok["úszás"].TotalSeconds);
Console.WriteLine($"átlagos úszási idő elit junior kategóriában: {f9:00}");
