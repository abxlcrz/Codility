using NUnit.Framework;

namespace Tests
{
    using Brackets;

    public class Tests
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void CodilityValidExample()
        {
            Assert.AreEqual(1, _solution.solution("{[()()]}"));
        }

        [Test]
        public void CodilityInvalidExample()
        {
            Assert.AreEqual(0, _solution.solution("([)()]"));
        }
    }
}