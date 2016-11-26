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
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NUnit.Framework;

namespace Heleonix.Build.Tests.Targets
{
    /// <summary>
    /// Tests the Hxb-NugetDeploy target.
    /// </summary>
    public class NugetDeployTests : TargetTests
    {
        #region Tests

        /// <summary>
        /// Tests the Hxb-NugetDeploy target.
        /// </summary>
        [Test]
        public void Execute()
        {
            var tempSource = Path.Combine(PathHelper.CurrentDir, Path.GetRandomFileName());

            try
            {
                Directory.CreateDirectory(tempSource);

                var result = ExeHelper.Execute(PathHelper.NugetExe, $"init \"{tempSource}\"");

                Assert.That(result.ExitCode, Is.Zero);

                var testCases = new TargetTestCase
                {
                    Items = new Dictionary<string, ITaskItem[]>
                    {
                        { "Hxb-NugetDeploy-In-Source", new ITaskItem[] { new TaskItem(tempSource) } }
                    },
                    Result = true
                };

                ExecuteTest(CIType.Jenkins, testCases);

                Assert.That(Directory.Exists(LibSimulatorHelper.NugetDeploymentDir), Is.True);
                Assert.That(Directory.GetFiles(LibSimulatorHelper.NugetDeploymentDir), Has.Length.EqualTo(1));
                Assert.That(Directory.Exists(tempSource));
                Assert.That(Directory.GetFiles(tempSource), Has.Length.EqualTo(1));
            }
            finally
            {
                Directory.Delete(LibSimulatorHelper.NugetDeploymentDir, true);
                Directory.Delete(tempSource, true);
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
        protected override string TargetName => "Hxb-NugetDeploy";

        #endregion
    }
}