// See https://aka.ms/new-console-template for more information
using Test3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Паттерн Адаптер");
        ProRoom pro = new ProRoom();
        pro.Init(10.5, 2, 16.5);
        RoomAdapter adapter = new RoomAdapter();
        double result = adapter.Calc(pro);
        Console.WriteLine($"Входные данные: pro (площадь комнаты 10.5м2, 2 человека в комнате, 16.5 дополнительной площади)");
        Console.WriteLine($"Средняя площадь на человека (по базовой формуле через адаптер): {result:F2}");
    }
}
