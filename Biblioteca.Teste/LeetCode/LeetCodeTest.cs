using Biblioteca.LeetCode;
using NUnit.Framework;

namespace Biblioteca.Teste.LeetCode
{
    internal class LeetCodeTest
    {

        [Test]
        public void LeetCode1Test()
        {
            Assert.That(LeetCode1.TwoSum(new int[4] { 2, 7, 11, 15 }, 9), Is.EqualTo(new int[2] { 0, 1 }));
            Assert.That(LeetCode1.TwoSum(new int[3] { 3, 2, 4 }, 6), Is.EqualTo(new int[2] { 1, 2 }));
            Assert.That(LeetCode1.TwoSum(new int[2] { 3, 3 }, 6), Is.EqualTo(new int[2] { 0, 1 }));
        }
    }
}
