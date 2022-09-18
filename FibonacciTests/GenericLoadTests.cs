using NotepadClasses;
namespace FibonacciTests
{
    public class GenericLoadTests
    {
       

        /// <summary>
        /// An exception unit test case for the generic load method.
        /// Passing a null file as an argument should result in 
        /// a FileNotFoundException.
        /// </summary>

        [Test]
        public void ExceptionalCaseGenericLoad()
        {
            TextReader readFile = TextReader.Null;
            GenericLoadTextClass genericLoadTextClass = new GenericLoadTextClass();

            Assert.Throws<FileNotFoundException>(() => genericLoadTextClass.GenericLoadTextOther(readFile));
        }
    }
}
