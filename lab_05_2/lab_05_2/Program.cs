using System;
using System.Text;

interface IParent
{
    string Info();
    void Metod();
}

class Child1 : IParent
{
    protected double pole1;
    protected double pole2;
    protected double pole3;

    public Child1(double ticketPrice, int seatCount)
    {
        pole1 = ticketPrice;
        pole2 = seatCount;
    }

    public string Info()
    {
        return $"Загальний: Вартість квитка: {pole1:C}, Кількість білетів: {pole2}, Дохід: {pole3:C}";
    }

    public void Metod()
    {
        pole3 = pole1 * pole2;
    }
}

class Child2 : IParent
{
    protected double pole1;
    protected double pole2;
    protected double pole3;
    protected double pole4;

    public Child2(double ticketPrice, int seatCount, double additionalPrice)
    {
        pole1 = ticketPrice;
        pole2 = seatCount;
        pole4 = additionalPrice;
    }

    public string Info()
    {
        return $"Плацкартний: Вартість квитка: {pole1:C}, Кількість квитків: {pole2}, Додаткові послуги: {pole4:C}, Дохід: {pole3:C}";
    }

    public void Metod()
    {
        pole3 = pole1 * pole2 + pole2 * pole4 * 0.5;
    }
}

class Child3 : IParent
{
    protected double pole1;
    protected double pole2;
    protected double pole3;
    protected double pole5;

    public Child3(double ticketPrice, int seatCount, double additionalPrice)
    {
        pole1 = ticketPrice;
        pole2 = seatCount;
        pole5 = additionalPrice;
    }

    public string Info()
    {
        return $"Купейний: Вартість квитка: {pole1:C}, Кількість квитків: {pole2}, Додаткові послуги: {pole5:C}, Дохід: {pole3:C}";
    }

    public void Metod()
    {
        pole3 = pole2 * (pole1 + pole5);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int wagonType = random.Next(1, 4);

            switch(wagonType)
            {
                case 1:
                    double ticketPrice1 = random.Next(10, 30);
                    int seatCount1 = random.Next(10, 30);
                    IParent child1 = new Child1(ticketPrice1, seatCount1);
                    child1.Metod();
                    Console.WriteLine(child1.Info());
                    break;

                case 2:
                    double ticketPrice2 = random.Next(100, 160);
                    int seatCount2 = random.Next(10, 30);
                    double additionalPrice2 = random.Next(15, 30);
                    IParent child2 = new Child2(ticketPrice2, seatCount2, additionalPrice2);
                    child2.Metod();
                    Console.WriteLine(child2.Info());
                    break;

                case 3:
                    double ticketPrice3 = random.Next(210, 300);
                    int seatCount3 = random.Next(10, 30);
                    double additionalPrice3 = random.Next(30, 50);
                    IParent child3 = new Child3(ticketPrice3, seatCount3, additionalPrice3);
                    child3.Metod();
                    Console.WriteLine(child3.Info());
                    break;
            }
        }
    }
}