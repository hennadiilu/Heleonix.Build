﻿/*
The MIT License (MIT)

Copyright (c) 2015-2016 Heleonix - Hennadii Lutsyshyn

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

using System.Collections.Generic;
using System.IO;
using Heleonix.Build.Tests.Common;
using NUnit.Framework;

namespace Heleonix.Build.Tests.Targets
{
    /// <summary>
    /// Tests the Hxb-ReportGenerator target.
    /// </summary>
    public class ReportGeneratorTests : TargetTests
    {
        #region Tests

        /// <summary>
        /// The test case source.
        /// </summary>
        /// <returns>Test cases.</returns>
        public static IEnumerable<TargetTestCase> ExecuteTestCasesValueSource()
        {
            yield return new TargetTestCase { DependsOnTargets = "Hxb-OpenCover", Result = true };
        }

        /// <summary>
        /// Tests the Hxb-ReportGenerator target.
        /// </summary>
        /// <param name="testCases">The test cases.</param>
        [Test]
        public void Execute([ValueSource(nameof(ExecuteTestCasesValueSource))] TargetTestCase testCases)
        {
            try
            {
                ExecuteTest(CIType.Jenkins, testCases);
            }
            finally
            {
                Directory.Delete(LibSimulatorHelper.ReportsDir, true);
            }
        }

        #endregion

        #region TargetTests Members

        /// <summary>
        /// Gets the type of the simulator.
        /// </summary>
        protected override SimulatorType SimulatorType => SimulatorType.Library;

        /// <summary>
        /// Gets or sets the name of the target.
        /// </summary>
        protected override string TargetName => "Hxb-ReportGenerator";

        #endregion
    }
}