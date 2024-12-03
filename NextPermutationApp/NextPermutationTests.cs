using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextPermutationApp;

namespace NextPermutationTests
{
    [TestClass]
    public class NextPermutationTests
    {
        [TestMethod]
        public void TestNextPermutation()
        {
            int[] nums = { 1, 2, 3 };
            Program.NextPermutation(nums);
            CollectionAssert.AreEqual(new int[] { 1, 3, 2 }, nums);
        }

        [TestMethod]
        public void TestNextPermutationLast()
        {
            int[] nums = { 3, 2, 1 };
            Program.NextPermutation(nums);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, nums);
        }

        [TestMethod]
        public void TestNextPermutationMiddle()
        {
            int[] nums = { 1, 3, 2 };
            Program.NextPermutation(nums);
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, nums);
        }
    }
}