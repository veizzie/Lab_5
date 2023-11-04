using System;
using System.Text;

abstract class Parent
{
    protected double pole1;
    protected double pole2;

    public abstract string Info();
    public abstract void Metod1();
    public abstract void Metod2();
}

class Child1 : Parent
{
    public Child1(double rate)
    {
        pole1 = rate;
    }

    public override string Info()
    {
        return $"Зарплата: {pole1 :C}, Премія: {pole2:C}";
    }

    public override void Metod1()
    {
        pole1 = pole1;
    }

    public override void Metod2()
    {
        pole2 = pole1 * 0.25;
    }
}

class Child2 : Parent
{
    protected double pole3;
    protected double pole4;

    public Child2(double hours, double rate)
    {
        pole3 = hours;
        pole4 = rate;
    }

    public override string Info()
    {
        return $"Кількість годин: {pole3}, Вартість години: {pole4:C}, Зарплата: {pole1:C}, Премія: {pole2:C}";
    }

    public override void Metod1()
    {
        pole1 = pole3 * pole4;
    }

    public override void Metod2()
    {
        pole2 = 2000;
    }
}

class Child3 : Parent
{
    protected double pole5;

    public Child3(double salesAmount)
    {
        pole5 = salesAmount;
    }

    public override string Info()
    {
        return $"Сума продаж: {pole5:C}, Зарплата: {pole1:C}, Премія: {pole2:C}";
    }

    public override void Metod1()
    {
        pole1 = pole5 * 0.10;
    }

    public override void Metod2()
    {
        pole2 = pole1 * 0.20;
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
            int employeeType = random.Next(1, 4);

            switch(employeeType)
            {
                case 1:
                    double rate = random.Next(5000, 15000);
                    Child1 child1 = new Child1(rate);
                    child1.Metod1();
                    child1.Metod2();
                    Console.WriteLine("На ставці: "+child1.Info());
                    break;

                case 2:
                    double hours = random.Next(10, 100);
                    double ratePerHour = random.Next(200, 300);
                    Child2 child2 = new Child2(hours, ratePerHour);
                    child2.Metod1();
                    child2.Metod2();
                    Console.WriteLine("Погодинник: "+child2.Info());
                    break;

                case 3:
                    double salesAmount = random.Next(100000, 200000);
                    Child3 child3 = new Child3(salesAmount);
                    child3.Metod1();
                    child3.Metod2();
                    Console.WriteLine("На відстоку: "+child3.Info());
                    break;
            }
        }
    }
}