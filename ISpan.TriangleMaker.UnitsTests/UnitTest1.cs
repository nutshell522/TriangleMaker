namespace ISpan.TriangleMaker.UnitsTests
{
    public class Tests
    {
        

        [Test]
        public void PrintTriangle_置左_3層三角形()
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
        public void PrintTriangle_置右_3層三角形()
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
        public void PrintTriangle_置中_3層三角形()
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
        public void PrintTriangle_置左_3層倒三角形()
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
        public void PrintTriangle_置右_3層倒三角形()
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
        public void PrintTriangle_置中_3層倒三角形()
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
        public void PrintTriangle_置中_字母3層三角形()
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
        public void PrintTriangle_置中_字母5層倒三角形()
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