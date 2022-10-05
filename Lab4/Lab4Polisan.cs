using System;
using Lab4;

namespace Lab4
{
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;
        private string _color;

        public Triangle()
        {
            _a = 0;
            _b = 0;
            _c = 0;
            _color = "";
        }

        public Triangle(double a, double b, double c, string col)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._color = col;
        }

        public string this[int index]
        {
            get
            {
                if (index == 0) return _a.ToString();
                else if (index == 1) return _b.ToString();
                else if (index == 2) return _c.ToString();
                else if (index == 3) return _color;
                else return "Error";
            }
            set
            {
                if (index == 0) _a = Double.Parse(value);
                else if (index == 1) _b = Double.Parse(value);
                else if (index == 2) _c = Double.Parse(value);
                else if (index == 3) _color = value;
            }
        }
        public static Triangle operator++(Triangle triangle)
        {
            triangle._a++;
            triangle._b++;
            triangle._c++;
            return triangle;
        }
        
        public static Triangle operator--(Triangle triangle)
        {
            triangle._a--;
            triangle._b--;
            triangle._c--;
            return triangle;
        }
        public static bool operator true(Triangle triangle)
        {
            if(triangle._a + triangle._b > triangle._c)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Triangle triangle)
        {
            if(triangle._a + triangle._b > triangle._c)
            {
                return false;
            }
            return true;
        }
        public static Triangle operator*(Triangle triangle,int num)
        {
            triangle._a *= num;
            triangle._b *= num;
            triangle._c *= num;
            return triangle;
        }

        public override string ToString()
        {
            return $"A: {_a}, B: {_b}, C: {_c}, color: {_color}";
        }
    }

    class VectorUInt
    {
        private uint[] IntArray;
        private uint size;
        private int codeError;
        private static uint num_vec;

        public VectorUInt()
        {
            IntArray = new uint[1];
            IntArray[0] = 0;
            size = 1;
            codeError = 0;
            num_vec++;
        }

        public VectorUInt(uint size)
        {
            IntArray = new uint[size];
            for (var i = 0; i < size; i++)
            {
                IntArray[i] = 0;
            }

            this.size = size;
            num_vec++;
            codeError = 0;
        }

        public VectorUInt(uint size, uint num)
        {
            IntArray = new uint[size];
            for (var i = 0; i < size; i++)
            {
                IntArray[i] = num;
            }

            this.size = size;
            num_vec++;
            codeError = 0;
        }

        ~VectorUInt()
        {
            Console.WriteLine("Destructor");
        }

        public void inputArr()
        {
            for (var i = 0; i < size; i++)
            {
                uint.TryParse(Console.ReadLine(), out IntArray[i]);
            }
        }

        public void printArr()
        {
            for (var i = 0; i < size; i++)
            {
                Console.Write($"{IntArray[i]} ");
            }
            Console.WriteLine();
        }

        public void setArr(uint num)
        {
            for (var i = 0; i < size; i++)
            {
                IntArray[i] = num;
            }
        }

        public uint getSize()
        {
            return size;
        }
        public uint this[uint index]
        {
            get
            {
                if (index > size)
                {
                    codeError = -1;
                    return 0;
                }
                return IntArray[index];
            }
            set
            {
                if (index > size)
                {
                    codeError = -1;
                }
                else
                {
                    IntArray[index] = value;
                }
            }
        }
        public static VectorUInt operator++(VectorUInt vectoruint)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i]++;
            }
            return vectoruint;
        }
        
        public static VectorUInt operator--(VectorUInt vectoruint)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i]--;
            }
            return vectoruint;
        }
        public static bool operator true(VectorUInt vectoruint)
        {
            if(vectoruint.size != 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(VectorUInt vectoruint)
        {
            if(vectoruint.size != 0)
            {
                return false;
            }
            return true;
        }
        public static VectorUInt operator+(VectorUInt vectoruint, int num)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i] = Convert.ToUInt32(vectoruint.IntArray[i] + num);
            } 
            return vectoruint;
        }

        public static VectorUInt operator+(VectorUInt a, VectorUInt b)
        {
            uint lessSize = a.size < b.size ? a.size : b.size;
            for (var i = 0; i < lessSize; i++)
            {
                a.IntArray[i] += b.IntArray[i];
            }
            return a;
        }
        public static VectorUInt operator-(VectorUInt vectoruint, int num)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i] = Convert.ToUInt32(vectoruint.IntArray[i] - num);
            } 
            return vectoruint;
        }

        public static VectorUInt operator-(VectorUInt a, VectorUInt b)
        {
            uint lessSize = a.size < b.size ? a.size : b.size;
            for (var i = 0; i < lessSize; i++)
            {
                a.IntArray[i] -= b.IntArray[i];
            }
            return a;
        }
        public static VectorUInt operator*(VectorUInt vectoruint, int num)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i] = Convert.ToUInt32(vectoruint.IntArray[i] * num);
            } 
            return vectoruint;
        }

        public static VectorUInt operator*(VectorUInt a, VectorUInt b)
        {
            uint lessSize = a.size < b.size ? a.size : b.size;
            for (var i = 0; i < lessSize; i++)
            {
                a.IntArray[i] *= b.IntArray[i];
            }
            return a;
        }
        public static VectorUInt operator/(VectorUInt vectoruint, int num)
        {
            for (var i = 0; i < vectoruint.size; i++)
            {
                vectoruint.IntArray[i] = Convert.ToUInt32(vectoruint.IntArray[i] / num);
            } 
            return vectoruint;
        }

        public static VectorUInt operator/(VectorUInt a, VectorUInt b)
        {
            uint lessSize = a.size < b.size ? a.size : b.size;
            for (var i = 0; i < lessSize; i++)
            {
                a.IntArray[i] /= b.IntArray[i];
            }
            return a;
        }
        
    }

    class MatrixUint
    {
        private uint[,] IntArray;
        private uint n,m;
        private int codeError;
        private static uint num_m;

        public MatrixUint()
        {
            IntArray = new uint[1,1];
            IntArray[0,0] = 0;
            n = 1;
            m = 1;
            codeError = 0;
            num_m++;
        }

        public MatrixUint(uint n, uint m)
        {
            IntArray = new uint[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var c = 0; c < m; c++)
                {
                    IntArray[i, c] = 0;
                }
            }
            this.n = n;
            this.m = m;
            num_m++;
            codeError = 0;
        }

        public MatrixUint(uint n, uint m, uint num)
        {
            IntArray = new uint[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var c = 0; c < m; c++)
                {
                    IntArray[i, c] = num;
                }
            }
            this.n = n;
            this.m = m;
            num_m++;
            codeError = 0;
        }

        ~MatrixUint()
        {
            Console.WriteLine("Destructor");
        }

        public void inputMat()
        {
            for (var i = 0; i < n; i++)
            {
                for (var c = 0; c < m; c++)
                {
                    uint.TryParse(Console.ReadLine(), out IntArray[i,c]);
                }
            }
        }

        public void PrintMat()
        {
            for (var i = 0; i < n; i++) 
            {
                    for (var c = 0; c < m; c++)
                    {
                        Console.Write($"{IntArray[i,c]} ");
                    }
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void SetMat(uint num)
        {
            for (var i = 0; i < n; i++)
            {
                for (var c = 0; c < m; c++)
                {
                    IntArray[i, c] = num;
                }
            }
        }
        
        public uint this[uint i, uint j]
        {
            get
            {
                if (i > n || j > m)
                {
                    codeError = -1;
                    return 0;
                }
                return IntArray[i,j];
            }
            set
            {
                if (i > n || j > m)
                {
                    codeError = -1;
                }
                else
                {
                    IntArray[i, j] = value;
                }
            }
        }
        
        public uint this[int index]
        {
            //rown = n, column = m
            get
            {
                if (index < n * m - 1)
                {

                    return IntArray[index / m, (int)(index % m)];
                }
                else
                {
                    codeError = -1;
                    return 0;
                }
            }
            set
            {
                if (index < n * m - 1)
                {
                    IntArray[index / m, (int)(index % m)] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }
        
        public static MatrixUint operator++(MatrixUint matrixUint)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c]++;
                }
            }

            return matrixUint;
        }
        
        public static MatrixUint operator--(MatrixUint matrixUint)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c]--;
                }
            }
            return matrixUint;
        }
        public static bool operator true(MatrixUint matrixUint)
        {
            if(matrixUint.n != 0 && matrixUint.m != 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(MatrixUint matrixUint)
        {
            if(matrixUint.n != 0 && matrixUint.m != 0)
            {
                return false;
            }
            return true;
        }
        public static MatrixUint operator+(MatrixUint matrixUint, int num)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c] = Convert.ToUInt32(matrixUint.IntArray[i, c] + num);
                }
            }

            return matrixUint;
        }

        public static MatrixUint operator+(MatrixUint a, MatrixUint b)
        {
            uint lessSizeN = a.n < b.n ? a.n : b.n;
            uint lessSizeM = a.m < b.m ? a.m : b.m;
            for (var i = 0; i < lessSizeN; i++)
            {
                for (int c = 0; c < lessSizeM; c++)
                {
                    a.IntArray[i, c] += b.IntArray[i, c];
                }
            }
            return a;
        }
        public static MatrixUint operator-(MatrixUint matrixUint, int num)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c] = Convert.ToUInt32(matrixUint.IntArray[i,c] - num);
                }
            }

            return matrixUint;
        }

        public static MatrixUint operator-(MatrixUint a, MatrixUint b)
        {
            uint lessSizeN = a.n < b.n ? a.n : b.n;
            uint lessSizeM = a.m < b.m ? a.m : b.m;
            for (var i = 0; i < lessSizeN; i++)
            {
                for (int c = 0; c < lessSizeM; c++)
                {
                    a.IntArray[i, c] -= b.IntArray[i, c];
                }
            }
            return a;
        }
        public static MatrixUint operator*(MatrixUint matrixUint, int num)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c] = Convert.ToUInt32(matrixUint.IntArray[i,c] * num);
                }
            }
            return matrixUint;
        }

        public static MatrixUint operator*(MatrixUint a, MatrixUint b)
        {
            uint lessSizeN = a.n < b.n ? a.n : b.n;
            uint lessSizeM = a.m < b.m ? a.m : b.m;
            for (var i = 0; i < lessSizeN; i++)
            {
                for (int c = 0; c < lessSizeM; c++)
                {
                    a.IntArray[i, c] *= b.IntArray[i, c];
                }
            }
            return a;
        }
        public static MatrixUint operator/(MatrixUint matrixUint, int num)
        {
            for (var i = 0; i < matrixUint.n; i++)
            {
                for (var c = 0; c < matrixUint.m; c++)
                {
                    matrixUint.IntArray[i, c] = Convert.ToUInt32(matrixUint.IntArray[i, c] / num);
                }
            }

            return matrixUint;
        }

        public static MatrixUint operator/(MatrixUint a, MatrixUint b)
        {
            uint lessSizeN = a.n < b.n ? a.n : b.n;
            uint lessSizeM = a.m < b.m ? a.m : b.m;
            for (var i = 0; i < lessSizeN; i++)
            {
                for (int c = 0; c < lessSizeM; c++)
                {
                    a.IntArray[i, c] /= b.IntArray[i, c];
                }
            }
            return a;
        }
    }

}



static class Program
{
    static void Main()
    {
        var triangleA = new Triangle();
        var triangleB = new Triangle(4, 2, 3, "blue");
        Console.WriteLine($"Index[1]: {triangleB[1]}");
        Console.WriteLine("Triangle A: " + triangleA);
        Console.WriteLine("Triangle B: " + triangleA);
        triangleA++;
        Console.WriteLine("++: " + triangleA);
        triangleA--;
        Console.WriteLine("--: " + triangleA);
        Console.WriteLine(triangleA ? "Triangle A exists" : "Triangle A does not exists");
        Console.WriteLine(triangleB ? "Triangle B exists" : "Triangle B does not exists");
        triangleB = triangleB * 2;
        Console.WriteLine("Triangle B * 2: " + triangleB);
        //----
        var arrA = new VectorUInt();
        var arrB = new VectorUInt(5, 3);
        Console.WriteLine($"Index[1]: {arrB[1]}");
        Console.WriteLine("Array A: ");
        arrA.printArr();
        Console.WriteLine("Array B: ");
        arrB.printArr();
        arrA++;
        Console.WriteLine("A++: ");
        arrA.printArr();
        arrA--;
        Console.WriteLine("A--: ");
        arrA.printArr();
        Console.WriteLine(arrA ? "Array A exists" : "Array A does not exists");
        Console.WriteLine(arrB ? "Array B exists" : "Array B does not exists");
        Console.WriteLine("Array B: ");
        arrB.printArr();
        arrB = arrB * 2;
        Console.WriteLine("Array B * 2: ");
        arrB.printArr();
        //----
        var matA = new MatrixUint();
        var matB = new MatrixUint(3, 3, 1);
        Console.WriteLine($"Index[1]: {matB[1]}");
        Console.WriteLine("Matrix A: ");
        matA.PrintMat();
        Console.WriteLine("Matrix B: ");
        matB.PrintMat();
        matB++;
        Console.WriteLine("Matrix B++: " );
        matB.PrintMat();
        Console.WriteLine(matA ? "Matrix A exists" : "Matrix A does not exists");
        Console.WriteLine(matB ? "Matrix B exists" : "Matrix B does not exists");
        Console.WriteLine("Matrix B: ");
        matB.PrintMat();
        matB = matB * 2;
        Console.WriteLine("Matrix B * 2: ");
        matB.PrintMat();
        
    }
}