Console.OutputEncoding = System.Text.Encoding.Default;

const double CAPPUCINO = 1;
const double CACAU = 2;
const double TEA = 3;
const double QUIT = 4;

const double CAPPUCINO_PRICE = 3.50;
const double CACAU_PRICE = 2.50;
const double TEA_PRICE = 1.50;

double Money = 0;
double Produkt = 0;
double Prize = 0;

System.Console.WriteLine("Please enter your Money (multiple with 0.5$)");
Money = double.Parse(Console.ReadLine()!);

while (Money % 0.5 == 0 && Money >= TEA_PRICE)
{


    if (Money % 0.5 != 0)
    {
        System.Console.WriteLine("Your money is not multiple with 0.5");
    }

    if (Money <= TEA_PRICE)
    {
        System.Console.WriteLine("You hav not  enough money");
    }
    else
    {
        System.Console.WriteLine("Invalid Input");
    }
}

while (Produkt != QUIT || Money! <= TEA_PRICE)
{
    System.Console.WriteLine("Please enter what you want to have :");
    System.Console.WriteLine("Cappuccino -> 3.50$ (1),");
    System.Console.WriteLine("Cacao -> 2.50$ (2),");
    System.Console.WriteLine("Tea -> 1.50$ (3),");
    System.Console.WriteLine("or use Quit if you dont want anything else (4) ");
    Produkt = double.Parse(Console.ReadLine()!);

    switch (Produkt)
    {
        case (TEA):
            Prize = TEA_PRICE;
            break;

        case (CACAU):
            Prize = CACAU_PRICE;
            break;

        case (CAPPUCINO):
            Prize = CAPPUCINO_PRICE;
            break;
    }

    while (Money < Prize && Produkt != QUIT)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry you do not have enough Money ");
        Console.WriteLine("Take something cheaper  or leave!");
        Console.ResetColor();

        Console.WriteLine("Wich product would you like to buy?");
        System.Console.WriteLine("Cappuccino -> 3.50$ (1),");
        System.Console.WriteLine("Cacao -> 2.50$ (2),");
        System.Console.WriteLine("Tea -> 1.50$ (3),");
        System.Console.WriteLine("or use Quit if you dont want anything else (4) ");
        Produkt = double.Parse(Console.ReadLine()!);

        switch (Produkt)
        {
        case (TEA):
            Prize = TEA_PRICE;
            break;

        case (CACAU):
            Prize = CACAU_PRICE;
            break;

        case (CAPPUCINO):
            Prize = CAPPUCINO_PRICE;
            break;
        }
           

        
    }
}

double ZWEI_EURO = 0;
double EIN_EURO = 0;
double NULLFÜNF_EURO = 0;

if (Produkt == QUIT || Money < TEA_PRICE)
{
    Console.WriteLine($"You will get {Money} back.");
    ZWEI_EURO = (int)Money / 2;
    EIN_EURO = (int)Money % 2;
    NULLFÜNF_EURO = (Money - ZWEI_EURO * 2 - EIN_EURO * 1) / 0.5;

    Console.WriteLine($"You will get {ZWEI_EURO} x2Euro pieces");
    Console.WriteLine($"You will get {EIN_EURO} x1Euro pieces");
    Console.WriteLine($"You will get {NULLFÜNF_EURO} x0.5Euro pieces");
}
