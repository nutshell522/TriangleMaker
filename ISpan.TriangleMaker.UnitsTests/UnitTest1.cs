namespace ISpan.TriangleMaker.UnitsTests
{
    public class Tests
    {
        

        [Test]
        public void PrintTriangle_�m��_3�h�T����()
        {
            string ecpected = @"*
**
***
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.PadLeft);
            Assert.AreEqual(ecpected, actaul) ;
        }

        [Test]
        public void PrintTriangle_�m�k_3�h�T����()
        {
            string ecpected = @"  *
 **
***
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.PadRight);
            Assert.AreEqual(ecpected, actaul);
        }

        [Test]
        public void PrintTriangle_�m��_3�h�T����()
        {
            string ecpected = @"  *
 ***
*****
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.Center);
            Assert.AreEqual(ecpected, actaul);
        }

        [Test]
        public void PrintTriangle_�m��_3�h�ˤT����()
        {
            string ecpected = @"***
**
*
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.InvertedLeft);
            Assert.AreEqual(ecpected, actaul);
        }
        [Test]
        public void PrintTriangle_�m�k_3�h�ˤT����()
        {
            string ecpected = @"***
 **
  *
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.InvertedRight);
            Assert.AreEqual(ecpected, actaul);
        }

        [Test]
        public void PrintTriangle_�m��_3�h�ˤT����()
        {
            string ecpected = @"*****
 ***
  *
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, triangle.InvertCenter);
            Assert.AreEqual(ecpected, actaul);
        }

        [Test]
        public void PrintTriangle_�m��_�r��3�h�T����()
        {
            string ecpected = @"  A
 ABA
ABCBA
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(3, 'A' ,triangle.CharTriangle);
            Assert.AreEqual(ecpected, actaul);
        }
        [Test]
        public void PrintTriangle_�m��_�r��5�h�ˤT����()
        {
            string ecpected = @"ABCDEDCBA
 ABCDCBA
  ABCBA
   ABA
    A
";
            TriangleMaker triangle = new TriangleMaker();
            string actaul = triangle.PrintTriangle(5, 'A', triangle.InvertCharTriangle);
            Assert.AreEqual(ecpected, actaul);
        }
    }
}