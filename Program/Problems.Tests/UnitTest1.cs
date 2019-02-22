using NUnit.Framework;
using Problems;//other project I made


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
		//test case i
        public void Test1()
        {
            //Arrange
            Program p = new Program();
            //Act
            string i = p.Prefix("hello");
            //Assert
            Assert.AreEqual("5,1:hello",i);
        }

		[Test]
		//test case ii
		public void Test2()
		{
            //Arrange
            Program p = new Program();
            //Act
            string ii = p.Prefix("");
            //Assert
            Assert.AreEqual("0,0:",ii);
		}
		
		[Test]
		//test case iii
		public void Test3()
		{
            //Arrange
            Program p = new Program();
            //Act
            string iii = p.Prefix("what ... did you say?? ");
            //Assert
			//Prac says it's 27, but it should be 23...
            Assert.AreEqual("23,5:what ... did you say?? ",iii);
		}
    }
}