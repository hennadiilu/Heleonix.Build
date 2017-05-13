﻿/*
The MIT License (MIT)

Copyright (c) 2015-present Heleonix - Hennadii Lutsyshyn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using NUnit.Framework;

namespace LibSimulator.Tests
{
    /// <summary>
    /// Tests the <see cref="Calculator"/>
    /// </summary>
    public static class CalculatorTests
    {
        #region Tests

        /// <summary>
        /// Tests the <see cref="Calculator.Add"/>.
        /// </summary>
        /// <param name="left">The left value.</param>
        /// <param name="right">The right value.</param>
        /// <returns>The result.</returns>
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(3, 2, ExpectedResult = 10)]
        [TestCase(3, 2, ExpectedResult = 20)]
        public static int Add(int left, int right)
        {
            return Calculator.Add(left, right);
        }

        /// <summary>
        /// Tests ignorance.
        /// </summary>
        /// <param name="value">The value.</param>
        [Ignore("Tests ignorance")]
        public static void Add(int value)
        {
            Calculator.Add(value, value);
        }

        #endregion
    }
}