﻿// <copyright file="OpenCoverTests.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Build.Tests.Targets;

/// <summary>
/// Tests the OpenCover target.
/// </summary>
[ComponentTest(Type = typeof(OpenCoverTests))]
public static class OpenCoverTests
{
    /// <summary>
    /// Tests the <see cref="OpenCoverTests"/>.
    /// </summary>
    [MemberTest(Name = nameof(OpenCoverTests))]
    public static void Execute()
    {
        var succeeded = false;
        NetSimulatorHelper simulator = null;
        IDictionary<string, string> properties = null;

        Arrange(() =>
        {
            simulator = new NetSimulatorHelper();

            MSBuildHelper.RunTestTarget("Hx_NetBuild", simulator.SolutionDir);
        });

        Act(() =>
        {
            succeeded = MSBuildHelper.RunTestTarget("Hx_OpenCover", simulator.SolutionDir, properties);
        });

        Teardown(() =>
        {
            simulator.Clear();
        });

        When("target is executed", () =>
        {
            And("Minimum coverage is satisfied", () =>
            {
                properties = new Dictionary<string, string>
                {
                    { "Hx_OpenCover_MinClassCoverage", "57" },
                    { "Hx_OpenCover_MinBranchCoverage", "53" },
                    { "Hx_OpenCover_MinMethodCoverage", "54" },
                    { "Hx_OpenCover_MinLineCoverage", "40" },
                };

                Should("succeed", () =>
                {
                    var artifactsDir = simulator.GetArtifactsDir("Hx_OpenCover");
                    var nunitArtifactsDir = simulator.GetArtifactsDir("Hx_NUnit");

                    Assert.That(succeeded, Is.True);
                    Assert.That(File.Exists(Path.Combine(artifactsDir, "OpenCover.xml")), Is.True);
                    Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "NUnit.xml")), Is.True);
                    Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "Output.txt")), Is.True);
                });
            });

            And("Minimum coverage is not satisfied", () =>
            {
                properties = new Dictionary<string, string>
                {
                    { "Hx_OpenCover_MinClassCoverage", "100" },
                    { "Hx_OpenCover_MinBranchCoverage", "100" },
                    { "Hx_OpenCover_MinMethodCoverage", "100" },
                    { "Hx_OpenCover_MinLineCoverage", "100" },
                };

                Should("fail", () =>
                {
                    var artifactsDir = simulator.GetArtifactsDir("Hx_OpenCover");
                    var nunitArtifactsDir = simulator.GetArtifactsDir("Hx_NUnit");

                    Assert.That(succeeded, Is.False);
                    Assert.That(File.Exists(Path.Combine(artifactsDir, "OpenCover.xml")), Is.True);
                    Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "NUnit.xml")), Is.True);
                    Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "Output.txt")), Is.True);
                });

                And("should continue on error", () =>
                {
                    properties.Add("Hx_OpenCover_ContinueOnError", "true");

                    Should("succeed", () =>
                    {
                        var artifactsDir = simulator.GetArtifactsDir("Hx_OpenCover");
                        var nunitArtifactsDir = simulator.GetArtifactsDir("Hx_NUnit");

                        Assert.That(succeeded, Is.True);
                        Assert.That(File.Exists(Path.Combine(artifactsDir, "OpenCover.xml")), Is.True);
                        Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "NUnit.xml")), Is.True);
                        Assert.That(File.Exists(Path.Combine(nunitArtifactsDir, "Output.txt")), Is.True);
                    });
                });
            });
        });
    }
}