Random dice = new Random();

int dado1 = dice.Next(1, 7);
int dado2 = dice.Next(1, 7);
int dado3 = dice.Next(1, 7);

int total = dado1 + dado2 + dado3;

Console.WriteLine($"Los dados dicen: {dado1} + {dado2} + {dado3} y el total es= {total}");

if ((dado1 == dado2) || (dado2 == dado3) || (dado1 == dado3))
{
    if ((dado1 == dado2) && (dado2 == dado3))
    {
        Console.WriteLine("Triple => 3 dados iguales!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("Doble => 2 dados iguales!  +2 bonus to total! ");
        total += 2;
    }

    Console.WriteLine($"Tu total incluyendo el bono: {total}");
}

if (total >= 16)
{
    Console.WriteLine("Te ganaste un auto 🚗🚗!");
}
else if (total >= 10)
{
    Console.WriteLine("Te ganaste una compu 💻💻!");
}
else if (total == 7)
{
    Console.WriteLine("Ganas un viaje para dos ✈️✈️✈️!");
}
else
{
    Console.WriteLine("Ganas una bici  🚲🚲🚲 !");
}























