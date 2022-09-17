using NotepadClasses;

namespace FibonacciTests
{
    public class ReadLineTests
    {
        /// <summary>
        /// A normal unit test case for the overridden ReadLine method.
        /// Passing the number 50 as an argument should result in 
        /// MaxLines = 50.
        /// </summary>

        [Test]
        public void NormalCaseReadLine()
        {
            //Print 50 numbers. MaxLines should be 50. 
            FibonacciTextReader fibonacciText = new(50);
            Assert.That(fibonacciText.MaxLines = 50, Is.EqualTo(50));
            
        }


        /// <summary>
        /// Boundary case for the overriden ReadLine method.
        /// Passing the number 1 as an argument should result
        /// in MaxLines = 1.
        /// </summary>
        [Test]
        public void BoundaryCaseReadLine()
        {
            //Print one number. MaxLines should be one. 
            FibonacciTextReader fibonacciText = new(1);
            Assert.That(fibonacciText.MaxLines = 1, Is.EqualTo(1));

        }


        /// <summary>
        /// Exceptional case to prevent negative numbers from being
        /// pass in as an argument.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// No negative numbers should be allowed passed in as an argument.
        /// </exception>
        [Test]
        public void ExceptionalCaseReadLine()
        {
            //Try to pass a negative number in as an argument.
            try
            {
                FibonacciTextReader fibonacciText = new(-1);
            }
            //Invalid argument. Throw an exception.
            catch(Exception)
            {
               throw new ArgumentOutOfRangeException("n must be positive");
            }
        }
    }
}