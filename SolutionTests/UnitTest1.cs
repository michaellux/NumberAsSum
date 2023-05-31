using NUnit.Framework;
using static Solution.Library.Program;
using Assert = NUnit.Framework.Assert;

namespace Solution.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CanSumToNumber_Returns_CorrectResult()
        {
            Assert.That(CanSum(new[] { 3, 1, 8, 5, 4 }, 10), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 3, 1, 8, 5, 4 }, 2), Is.EqualTo(false));

            Assert.That(CanSum(new[] { 2, 3 }, 5), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 1, 2, 3, 4 }, 5), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 1 }, 1), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 1, 2, 3 }, 7), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 1, 2, 3 }, 8), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 8, 9 }, 7), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 8, 9 }, 8), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 7, 14 }, 21), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 7, 14 }, 7), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 7, 14 }, 14), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 7, 14 }, 4), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 7, 14, 15 }, 29), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 7, 14, 15 }, 30), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 100), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 200), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 300), Is.EqualTo(false));
            Assert.That(CanSum(new[] { 1, 1, 2, 3, 5, 8, 13, 21 }, 34), Is.EqualTo(true));
            Assert.That(CanSum(new[] { 1, 1, 2, 3, 5, 8, 13, 21 }, 100), Is.EqualTo(false));
        }
    }
}