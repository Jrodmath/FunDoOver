using System.Text;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace NotepadClasses
{
    public class FibonacciTextReader : System.IO.TextReader
    {
        //Fields
        //x: The first Fibonacci number.
        BigInteger x = 0;
        //y: The second Fibonacci number.
        BigInteger y = 0;
        //sum: The rolling sum of x and y.
        BigInteger sum = 0;
        //maxLines: The number of Fibonacci numbers that should be printed
        int maxLines = 0;

        //Properties

        public BigInteger X { get { return x; } }
        public BigInteger Y { get { return y; } }
        public BigInteger Sum { get { return sum; } }

        public int MaxLines { get; set; }

        //Default constructor to set x and y to zero.
        public FibonacciTextReader()
        {
            this.y = BigInteger.Zero;
            this.x = BigInteger.Zero;
        }

        //Constructors

        /// <summary>
        /// The driving constructor for FibonacciTextReader objects. 
        /// This constructor accepts an integer argument
        /// and sets MaxLines equal to that integer.
        /// </summary>
        /// <param name="n">
        /// n is an integer number, and it should be greater than zero.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Throw an argument exception if zero or a negative value is entered.
        /// </exception>
        public FibonacciTextReader(int n)
        {
            try
            {
                if(n > 0)
                {
                    this.MaxLines = n;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException("n must be positive");
            }  
        }

        public override string ReadLine()
        {
            if (MaxLines == 0) return null;
            string? text = null;

            BigInteger tmp = x;
            x = y;
            sum = tmp + y;
            y = sum;
            text = sum.ToString();
            return text;
        }

        public override string ReadToEnd()
        {
            string? text = null;
            int count = 1;
            x = 0;
            y = 1;
            StringBuilder sb = new();
            sb.Append(count.ToString() + ": ");
            sb.AppendLine(x.ToString());
            count++;
            sb.Append(count.ToString() + ": ");
            sb.AppendLine(y.ToString());
            count++;
            MaxLines -= 2;

            while (MaxLines > 0)
            {
                sb.Append(count.ToString() + ": ");

                sb.AppendLine(this.ReadLine());
                count++;
                MaxLines--;
            }
            string complete = sb.ToString();
            return complete;
        }
    }
}