using NUnit.Framework;

namespace MarathonAssessment.Tests
{
    public class BoxMoverTests
    {
        private BoxMover boxMover;
        [SetUp]
        public void Setup()
        {
            boxMover = new BoxMover();
        }

        [Test]
        [TestCase(2, 2, 2, 1)]
        [TestCase(11, 2, 2, 7)]
        [TestCase(11, 2, 3, 4)]
        [TestCase(3, 2, 5, 3)]
        [TestCase(101, 2, 5, 0)]
        [TestCase(0, 2, 5, 0)]
        [TestCase(10, 6, 5, 0)]
        [TestCase(10, 0, 5, 0)]
        [TestCase(5, 2, 6, 0)]
        [TestCase(5, 2, 1, 0)]
        public void GetNumberOfPiles_Test(int boxes, int maxCarry, int maxParts, int expectedOutput)
        {
            var actualOutput = boxMover.GetNumberOfPiles(boxes, maxCarry, maxParts);
            Assert.That(actualOutput, Is.EqualTo(expectedOutput));
        }
    }
}