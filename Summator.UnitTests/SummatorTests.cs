using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            
            var expected = 3;
            
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumber()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var nums = new int[] {6};
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}