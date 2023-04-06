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

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] {};
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] {2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);

            var expected = 6000000000;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageTwoPositiveNumber()
        {
            var nums = new double[] { 2, 2 };
            var actual = Summator.Avarage(nums);

            var expected = 2;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageTreePositiveNumber()
        {
            var nums = new double[] { 3, 9, 21};
            var actual = Summator.Avarage(nums);

            var expected = 11;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageTreeNegativeNumber()
        {
            var nums = new double[] { -3, -9, -21 };
            var actual = Summator.Avarage(nums);

            var expected = -11;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageNullNumbers()
        {
            var nums = new double[] {0,0,0};
            var actual = Summator.Avarage(nums);

            var expected = 0.0;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageBigNumbers()
        {
            var nums = new double[] { 3000000000.0, 3000000000.0, 3000000000.0 };
            var actual = Summator.Avarage(nums);

            var expected = 3000000000.0;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AvarageOneNumber()
        {
            var nums = new double[] {9.0};
            var actual = Summator.Avarage(nums);

            var expected = 9.0;

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}