using System;

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

}