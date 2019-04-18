using System;

namespace ServiceTrain2.Services
{
    public class RandomCounter:ICounter
    {
        public int Value { get; }
        static Random Rnd = new Random();
        private int _value;
        public RandomCounter()
        {
            _value = Rnd.Next(0, 1000000);
        }
    }
}