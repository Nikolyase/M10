using System;

namespace M10
{
    public class Calc : ICalculator, IException
    {
        ILogger Logger { get; }
        public Calc (ILogger logger)
        {
            Logger = logger;
        }
        
        public void Solve(int numberOne, int numberTwo)
        {
            Logger.Event($"Сумма чисел {numberOne} и {numberTwo} равна {numberOne + numberTwo}");
        }
        
        public void ExpErr()
        {
            Logger.Error("Введено некорректное значение, вводите числа!");
        }
        
        public void FinColor()
        {
            Logger.BaseColor();
        }
    }
}

