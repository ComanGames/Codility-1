﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L1TimeComplexity
{
    [TestClass]
    public class TestPermMissingElem
    {
        [TestMethod]
        public void TestPermMissingElemMethod1()
        {
            SolutionPermMissingElem s = new SolutionPermMissingElem();
            int[] A = {3, 1, 2, 4, 6};
            var result = s.solution(A);
            Assert.AreEqual(5, result);
        }
    }

    /// <summary>
    /// <para>A zero-indexed array A consisting of N different integers is given.</para>
    /// <para>The array contains integers in the range [1..(N + 1)], which means that</para>
    /// <para>exactly one element is missing.</para>
    /// <para>Your goal is to find that missing element.</para>
    /// </summary>
    class SolutionPermMissingElem
    {
        /// <summary>
        /// <para>Given a zero-indexed array A, returns the value of the missing</para>
        /// <para>element.</para>
        /// </summary>
        /// <param name="A">arrray of elements.</param>
        /// <returns>value of missing element.</returns>
        public int solution(int[] A)
        {
            int[] B = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
                B[A[i] - 1] = 1;
            for (int i = 0; i < A.Length; i++)
                if (B[i] == 0)
                    return i + 1;
            return A.Length + 1;
        }
    }
}
