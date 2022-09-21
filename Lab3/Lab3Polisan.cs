using System;

namespace Lab3
{
    class Triangle
    {
        private int _a, _b, _c;
        private readonly int _color;
    
        public Triangle(int a, int b, int c, int color)
        {
            _a = a;
            _b = b;
            _c = c;
            _color = color;
        }
    
        public void Print()
        {
            Console.WriteLine($"A: {_a}\nB: {_b}\nC: {_c}\nColor:{_color}");
        }
    
        public double Perimeter()
        {
            return _a + _b + _c;
        }
    
        public double Area()
        {
            var p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    
        public void SetA(int newA)
        {
            _a = newA;
        }
    
        public void SetB(int newB)
        {
            _b = newB;
        }
    
        public void SetC(int newC)
        {
            _c = newC;
        }
    
        public int GetA()
        {
            return _a;
        }
    
        public int GetB()
        {
            return _b;
        }
    
        public int GetC()
        {
            return _c;
        }
    
        public int GetColor()
        {
            return _color;
        }
    }

    class Engine
    {
        protected string Model;

        public Engine()
        {
            Model = "Default engine";
        }

        public void Show()
        {
            Console.WriteLine($"Model: {Model}");
        }

    }

    class InternalEngine : Engine
    {
        private readonly double _v;
        public InternalEngine()
        {
            _v = 5;
            Model = "Internal engine";
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }
    
    class DieselEngine : Engine
    {
        private readonly double _v;
        public DieselEngine()
        {
            _v = 2;
            Model = "Diesel engine";
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }
    
    class ReactEngine : Engine
    {
        private readonly double _v;
        public ReactEngine()
        {
            _v = 6;
            Model = "React engine";
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }

    static class Program
    {
        static void Main()
        {
            Triangle a = new(8,2,9,4);
            a.Print();
            a.SetB(3);
            a.Print();
            Console.WriteLine($"P: {a.Perimeter()}\nS: {a.Area()}");
            Engine engine = new();
            engine.Show();
            InternalEngine internalEngine = new();
            internalEngine.Show();
            ReactEngine reactEngine = new();
            reactEngine.Show();
            DieselEngine dieselEngine = new();
            dieselEngine.Show();
        }
    }

    
}



