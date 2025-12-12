namespace ABHeicConverter.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var dirReader = new DirectoryReader("C:\\Dest\\TestImages\\");
            List<string> files = dirReader.GetDirectoryFiles().ToList();
            files.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            Assert.IsTrue(files.Count > 1);

        }
    }
}