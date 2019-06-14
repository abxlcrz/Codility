namespace NumberOfDiscIntersectionsTest
{
    using NumberOfDiscIntersections;
    using NUnit.Framework;

    public class NumberOfDiscIntersectionsTest
    {
        private Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new Solution();
        }

        [Test]
        public void WhenArrayIsEmpty_IntersectionsAreZero()
        {
            var result = _solution.solution(new int[] { });

            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenArrayHasOneElement_IntersectionsAreZero()
        {
            var result = _solution.solution(new[] {1});

            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenArrayHasTwoIntersectedElements_IntersectionsAreOne()
        {
            var result = _solution.solution(new[] {1, 5});

            Assert.AreEqual(1, result);
        }


        [Test]
        public void WhenArrayIsLikeCodilityExample_IntersectionsAreEleven()
        {
            var result = _solution.solution(new[] {1, 5, 2, 1, 4, 0});

            Assert.AreEqual(11, result);
        }
    }
}