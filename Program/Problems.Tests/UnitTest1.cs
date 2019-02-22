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
            //Test 1:
            //Arrange
            Program p = new Program();
            //Act
            string i = p.Prefix("hello");
            //Assert
            Assert.AreEqual("5,1:hello",i);
            
            //Test 2:
            //Arrange -- none since all test cases use p
            //Act
            string ii = p.Prefix("");
            //Assert
            Assert.AreEqual("0,0:",ii);

            //Test 3:
            //Arrange -- none since all test cases use p 
            //Act
            string iii = p.Prefix("what ... did you say?? ");
            //Assert
            //practical says that length is 27, but is actually 23.
             Assert.AreEqual("23,5:what ... did you say?? ",iii);

             //Test 4:  (extra case 1)
             //Arrange -- again not needed
             //Act
             string iv = p.Prefix("  how many  words  is this  even??   ");
             //Assert
             Assert.AreEqual("37,6:  how many  words  is this  even??   ",iv);

             //Test 5: (extra case 2)
             //Arrange -- not needed
             //Act
             string v = p.Prefix(" lots of spaces   in these words  indeed      ... yeah ");
             //Assert
             Assert.AreEqual("55,9: lots of spaces   in these words  indeed      ... yeah ",v);

             //Test 6: (extra case 3)
             //Arrange -- note needed
             //Act 
             string vi = p.Prefix("          ");
             //Assert
             Assert.AreEqual("10,0:          ",vi);
        }
    }
}