using System;

namespace TestProj
{
    internal class Bottle
    {
        internal event Action<float> WaterEvent;
        private float _water;

        internal float Water
        {
            get { return _water; }
            set
            {
                _water = value;
                if (_water < 0)
                {
                    _water = 0;
                    Console.WriteLine("물이 부족해..");
                }

                if (_water > 1000)
                {
                    _water = 1000;
                    Console.WriteLine("물이 넘쳤다!");
                }
                WaterEvent?.Invoke(_water);
            }
        }

        internal float Max { get; set; }
    }
}
