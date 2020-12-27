using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Benchmark.Quantities.codegen
{

  public static class FourierTransform
  {
    public enum Direction
    {
      Forward = 1,
      Backward = -1
    };

    public static void DFT(Complex[] data, Direction direction)
    {
      int n = data.Length;
      double arg, cos, sin;
      var dst = new Complex[n];

      // for each destination element
      for (int i = 0; i < dst.Length; i++)
      {
        dst[i] = Complex.Zero;

        arg = -(int)direction * 2.0 * System.Math.PI * (double)i / (double)n;

        // sum source elements
        for (int j = 0; j < data.Length; j++)
        {
          cos = System.Math.Cos(j * arg);
          sin = System.Math.Sin(j * arg);

          double re = data[j].Real * cos - data[j].Imaginary * sin;
          double im = data[j].Real * sin + data[j].Imaginary * cos;

          dst[i] += new Complex(re, im);
        }
      }

      // copy elements
      if (direction == Direction.Forward)
      {
        // devide also for forward transform
        for (int i = 0; i < data.Length; i++)
          data[i] /= n;
      }
      else
      {
        for (int i = 0; i < data.Length; i++)
          data[i] = dst[i];
      }
    }

    public static void DFT2(Complex[,] data, Direction direction)
    {
      int n = data.GetLength(0);  // rows
      int m = data.GetLength(1);  // columns
      double arg, cos, sin;
      var dst = new Complex[System.Math.Max(n, m)];

      // process rows
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < dst.Length; j++)
        {
          dst[j] = Complex.Zero;

          arg = -(int)direction * 2.0 * System.Math.PI * (double)j / (double)m;

          // sum source elements
          for (int k = 0; k < m; k++)
          {
            cos = System.Math.Cos(k * arg);
            sin = System.Math.Sin(k * arg);

            double re = data[i, k].Real * cos - data[i, k].Imaginary * sin;
            double im = data[i, k].Real * sin + data[i, k].Imaginary * cos;

            dst[j] += new Complex(re, im);
          }
        }

        // copy elements
        if (direction == Direction.Forward)
        {
          // devide also for forward transform
          for (int j = 0; j < dst.Length; j++)
            data[i, j] = dst[j] / m;
        }
        else
        {
          for (int j = 0; j < dst.Length; j++)
            data[i, j] = dst[j];
        }
      }

      // process columns
      for (int j = 0; j < m; j++)
      {
        for (int i = 0; i < n; i++)
        {
          dst[i] = Complex.Zero;

          arg = -(int)direction * 2.0 * System.Math.PI * (double)i / (double)n;

          // sum source elements
          for (int k = 0; k < n; k++)
          {
            cos = System.Math.Cos(k * arg);
            sin = System.Math.Sin(k * arg);

            double re = data[k, j].Real * cos - data[k, j].Imaginary * sin;
            double im = data[k, j].Real * sin + data[k, j].Imaginary * cos;

            dst[i] += new Complex(re, im);
          }
        }

        // copy elements
        if (direction == Direction.Forward)
        {
          // devide also for forward transform
          for (int i = 0; i < dst.Length; i++)
            data[i, j] = dst[i] / n;
        }
        else
        {
          for (int i = 0; i < dst.Length; i++)
            data[i, j] = dst[i];
        }
      }
    }

    public static void FFT(Complex[] data, Direction direction)
    {
      int n = data.Length;
      int m = Log2(n);

      // reorder data first
      ReorderData(data);

      // compute FFT
      int tn = 1, tm;

      for (int k = 1; k <= m; k++)
      {
        Complex[] rotation = FourierTransform.GetComplexRotation(k, direction);

        tm = tn;
        tn <<= 1;

        for (int i = 0; i < tm; i++)
        {
          Complex t = rotation[i];

          for (int even = i; even < n; even += tn)
          {
            int odd = even + tm;
            Complex ce = data[even];
            Complex co = data[odd];

            double tr = co.Real * t.Real - co.Imaginary * t.Imaginary;
            double ti = co.Real * t.Imaginary + co.Imaginary * t.Real;

            data[even] += new Complex(tr, ti);
            data[odd] = new Complex(ce.Real - tr, ce.Imaginary - ti);
          }
        }
      }

      if (direction == Direction.Forward)
      {
        for (int i = 0; i < data.Length; i++)
          data[i] /= (double)n;
      }
    }

    public static void FFT2(Complex[,] data, Direction direction)
    {
      int k = data.GetLength(0);
      int n = data.GetLength(1);

      // check data size
      if (!IsPowerOf2(k) || !IsPowerOf2(n))
        throw new ArgumentException("The matrix rows and columns must be a power of 2.");

      if (k < minLength || k > maxLength || n < minLength || n > maxLength)
        throw new ArgumentException("Incorrect data length.");

      // process rows
      var row = new Complex[n];

      for (int i = 0; i < k; i++)
      {
        // copy row
        for (int j = 0; j < row.Length; j++)
          row[j] = data[i, j];

        // transform it
        FourierTransform.FFT(row, direction);

        // copy back
        for (int j = 0; j < row.Length; j++)
          data[i, j] = row[j];
      }

      // process columns
      var col = new Complex[k];

      for (int j = 0; j < n; j++)
      {
        // copy column
        for (int i = 0; i < k; i++)
          col[i] = data[i, j];

        // transform it
        FourierTransform.FFT(col, direction);

        // copy back
        for (int i = 0; i < k; i++)
          data[i, j] = col[i];
      }
    }

    private const int minLength = 2;
    private const int maxLength = 16384;
    private const int minBits = 1;
    private const int maxBits = 14;
    private static int[][] reversedBits = new int[maxBits][];
    private static Complex[,][] complexRotation = new Complex[maxBits, 2][];

    // Get array, indicating which data members should be swapped before FFT
    private static int[] GetReversedBits(int numberOfBits)
    {
      if ((numberOfBits < minBits) || (numberOfBits > maxBits))
        throw new ArgumentOutOfRangeException();

      // check if the array is already calculated
      if (reversedBits[numberOfBits - 1] == null)
      {
        int n = Pow2(numberOfBits);
        int[] rBits = new int[n];

        // calculate the array
        for (int i = 0; i < n; i++)
        {
          int oldBits = i;
          int newBits = 0;

          for (int j = 0; j < numberOfBits; j++)
          {
            newBits = (newBits << 1) | (oldBits & 1);
            oldBits = (oldBits >> 1);
          }
          rBits[i] = newBits;
        }
        reversedBits[numberOfBits - 1] = rBits;
      }
      return reversedBits[numberOfBits - 1];
    }

    // Get rotation of complex number
    private static Complex[] GetComplexRotation(int numberOfBits, Direction direction)
    {
      int directionIndex = (direction == Direction.Forward) ? 0 : 1;

      // check if the array is already calculated
      if (complexRotation[numberOfBits - 1, directionIndex] == null)
      {
        int n = 1 << (numberOfBits - 1);
        double uR = 1.0;
        double uI = 0.0;
        double angle = System.Math.PI / n * (int)direction;
        double wR = System.Math.Cos(angle);
        double wI = System.Math.Sin(angle);
        double t;
        Complex[] rotation = new Complex[n];

        for (int i = 0; i < n; i++)
        {
          rotation[i] = new Complex(uR, uI);
          t = uR * wI + uI * wR;
          uR = uR * wR - uI * wI;
          uI = t;
        }

        complexRotation[numberOfBits - 1, directionIndex] = rotation;
      }
      return complexRotation[numberOfBits - 1, directionIndex];
    }

    // Reorder data for FFT using
    private static void ReorderData(Complex[] data)
    {
      int len = data.Length;

      // check data length
      if ((len < minLength) || (len > maxLength) || (!IsPowerOf2(len)))
        throw new ArgumentException("Incorrect data length.");

      int[] rBits = GetReversedBits(Log2(len));

      for (int i = 0; i < len; i++)
      {
        int s = rBits[i];

        if (s > i)
        {
          Complex t = data[i];
          data[i] = data[s];
          data[s] = t;
        }
      }
    }

    private static int Pow2(int power)
    {
      return ((power >= 0) && (power <= 30)) ? (1 << power) : 0;
    }

    private static bool IsPowerOf2(int x)
    {
      return (x > 0) ? ((x & (x - 1)) == 0) : false;
    }

    public static int Log2(int x)
    {
      if (x <= 65536)
      {
        if (x <= 256)
        {
          if (x <= 16)
          {
            if (x <= 4)
            {
              if (x <= 2)
              {
                if (x <= 1)
                  return 0;
                return 1;
              }
              return 2;
            }
            if (x <= 8)
              return 3;
            return 4;
          }
          if (x <= 64)
          {
            if (x <= 32)
              return 5;
            return 6;
          }
          if (x <= 128)
            return 7;
          return 8;
        }
        if (x <= 4096)
        {
          if (x <= 1024)
          {
            if (x <= 512)
              return 9;
            return 10;
          }
          if (x <= 2048)
            return 11;
          return 12;
        }
        if (x <= 16384)
        {
          if (x <= 8192)
            return 13;
          return 14;
        }
        if (x <= 32768)
          return 15;
        return 16;
      }

      if (x <= 16777216)
      {
        if (x <= 1048576)
        {
          if (x <= 262144)
          {
            if (x <= 131072)
              return 17;
            return 18;
          }
          if (x <= 524288)
            return 19;
          return 20;
        }
        if (x <= 4194304)
        {
          if (x <= 2097152)
            return 21;
          return 22;
        }
        if (x <= 8388608)
          return 23;
        return 24;
      }
      if (x <= 268435456)
      {
        if (x <= 67108864)
        {
          if (x <= 33554432)
            return 25;
          return 26;
        }
        if (x <= 134217728)
          return 27;
        return 28;
      }
      if (x <= 1073741824)
      {
        if (x <= 536870912)
          return 29;
        return 30;
      }
      return 31;
    }
  }
}
