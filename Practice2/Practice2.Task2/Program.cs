// a
void mToKm(double m)
{
    double km = m / 1000;
    Console.WriteLine($"{m} метр(-ов) это {km} километр(-ов)");
}
mToKm(1345);

Console.ReadKey();

// b
void kmToCm(double km)
{
    double cm = km * 100000;
    Console.WriteLine($"{km} километр(-ов) это {cm} сантиметр(-ов)");
}
kmToCm(3.5);

Console.ReadKey();

// c
void msToKmh(double ms)
{
    double kmh = ms * 3.6;
    Console.WriteLine($"{ms} метр(-ов) в секунду это {kmh} километр(-ов) в час");
}
msToKmh(15);

Console.ReadKey();

// d
void cToF(double c)
{
    double f = c * 9 / 5 + 32;
    Console.WriteLine($"{c} градус(-ов) Цельсия это {f} градус(-ов) Фаренгейта");
}
cToF(36.6);

Console.ReadKey();