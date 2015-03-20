﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L1TimeComplexity
{
    [TestClass]
    public class TestTapeEquilibrium
    {
        [TestMethod]
        public void TestTapeEquilibriumMethod1()
        {
            SolutionTapeEquilibrium s = new SolutionTapeEquilibrium();
            int[] A = {3, 1, 2, 4, 3};
            var result = s.solution(A);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestTapeEquilibriumMethod2()
        {
            SolutionTapeEquilibrium s = new SolutionTapeEquilibrium();
            int[] A = { -10, 10 };
            var result = s.solution(A);
            Assert.AreEqual(20, result);
        }
    }
    /// <summary>
    /// A non-empty zero-indexed array A consisting of N integers is given.
    /// Array A represents numbers on a tape.
    /// Any integer P, such that 0 &lt; P &lt; N, splits this tape into two
    /// non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1]
    /// , ..., A[N − 1].
    /// The difference between the two parts is the value of:
    /// |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
    /// In other words, it is the absolute difference between the sum of the
    /// first part and the sum of the second part.
    /// </summary>
    class SolutionTapeEquilibrium
    {
        /// <summary>
        /// Given a non-empty zero-indexed array A of N integers,
        /// returns the minimal difference that can be achieved.
        /// </summary>
        /// <param name="A">A non-empty zero-indexed array A consisting of N integers</param>
        /// <returns>minimal difference</returns>
        public int solution(int[] A)
        {
            int min = int.MaxValue;
            var l = 0;
            var p = 0;
            for (int i = 0; i < A.Length; i++)
                p += A[i];
            for (int i = 0; i < A.Length - 1; i++)  // N-1 splits
            {
                l += A[i];
                p -= A[i];
                min = Math.Min(min, Math.Abs(l - p));
            }
            return min;
        }
    }
}
