﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Heleonix.Build.Properties; 
using System;


/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class Resources {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Heleonix.Build.Properties.Resources", typeof(Resources).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cleaning directory &apos;{0}&apos; started..
    /// </summary>
    internal static string DirectoryClean_CleaningDirectoryStarted {
        get {
            return ResourceManager.GetString("DirectoryClean_CleaningDirectoryStarted", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The directory &apos;{0}&apos; not found. Skipping..
    /// </summary>
    internal static string DirectoryClean_DirectoryNotFound {
        get {
            return ResourceManager.GetString("DirectoryClean_DirectoryNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Copying file: from &apos;{0}&apos; to &apos;{1}&apos;..
    /// </summary>
    internal static string FileCopy_CopyingFile {
        get {
            return ResourceManager.GetString("FileCopy_CopyingFile", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The file to copy &apos;{0}&apos; not found..
    /// </summary>
    internal static string FileCopy_FileNotFound {
        get {
            return ResourceManager.GetString("FileCopy_FileNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A directory &apos;{0}&apos; to cory from was specified, but it does not belong to the file &apos;{1}&apos;. Skipping..
    /// </summary>
    internal static string FileCopy_WithSubDirsFromIsInvalid {
        get {
            return ResourceManager.GetString("FileCopy_WithSubDirsFromIsInvalid", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The file &apos;{0}&apos; is not found..
    /// </summary>
    internal static string FileRead_FileNotFound {
        get {
            return ResourceManager.GetString("FileRead_FileNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Found {0}..
    /// </summary>
    internal static string FileSystemSearch_FoundItem {
        get {
            return ResourceManager.GetString("FileSystemSearch_FoundItem", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The starting directory &apos;{0}&apos; not found. Stopping..
    /// </summary>
    internal static string FileSystemSearch_StartingDirectoryNotFound {
        get {
            return ResourceManager.GetString("FileSystemSearch_StartingDirectoryNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Start searching in &apos;{0}&apos;; Type: {1}; Direction: {2}; PathRegExp: {3}; ContentRegExp: {4}..
    /// </summary>
    internal static string FileSystemSearch_StartSearching {
        get {
            return ResourceManager.GetString("FileSystemSearch_StartSearching", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to File generation failed: {0}.
    /// </summary>
    internal static string FileT4Generate_GeneratorFailed {
        get {
            return ResourceManager.GetString("FileT4Generate_GeneratorFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The template file &apos;{0}&apos; not found..
    /// </summary>
    internal static string FileT4Generate_TemplateNotFound {
        get {
            return ResourceManager.GetString("FileT4Generate_TemplateNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The file &apos;{0}&apos; not found. Stopping..
    /// </summary>
    internal static string FileUpdate_FileNotFound {
        get {
            return ResourceManager.GetString("FileUpdate_FileNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Updating file &apos;{0}&apos;..
    /// </summary>
    internal static string FileUpdate_UpdatingFile {
        get {
            return ResourceManager.GetString("FileUpdate_UpdatingFile", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A file &apos;{0}&apos; to validate not found..
    /// </summary>
    internal static string FileValidate_FileNotFound {
        get {
            return ResourceManager.GetString("FileValidate_FileNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The file &apos;{0}&apos; violates the rule &apos;{1}={2}&apos;..
    /// </summary>
    internal static string FileValidate_RuleViolated {
        get {
            return ResourceManager.GetString("FileValidate_RuleViolated", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Validating file &apos;{0}&apos; with patterns: {1}..
    /// </summary>
    internal static string FileValidate_ValidatingFile {
        get {
            return ResourceManager.GetString("FileValidate_ValidatingFile", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Collecting changes. Since: {0}..
    /// </summary>
    internal static string GithubCommitChangeLog_CollectChanges {
        get {
            return ResourceManager.GetString("GithubCommitChangeLog_CollectChanges", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Getting the latest release..
    /// </summary>
    internal static string GitHubCommitChangeLog_GettingLatestRelease {
        get {
            return ResourceManager.GetString("GitHubCommitChangeLog_GettingLatestRelease", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No release found to collect changes and calculate version from..
    /// </summary>
    internal static string GitHubCommitChangeLog_NoReleaseFound {
        get {
            return ResourceManager.GetString("GitHubCommitChangeLog_NoReleaseFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Creating a release: {0}..
    /// </summary>
    internal static string GitHubRelease_CreatingRelease {
        get {
            return ResourceManager.GetString("GitHubRelease_CreatingRelease", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Creating release failed with HTTP response: {0} - {1}..
    /// </summary>
    internal static string GitHubRelease_Failed {
        get {
            return ResourceManager.GetString("GitHubRelease_Failed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failed pushing &apos;{0}&apos;. Exit code: {1}..
    /// </summary>
    internal static string NugetPush_Failed {
        get {
            return ResourceManager.GetString("NugetPush_Failed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Pushing &apos;{0}&apos;..
    /// </summary>
    internal static string NugetPush_Started {
        get {
            return ResourceManager.GetString("NugetPush_Started", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Asserts: {0}..
    /// </summary>
    internal static string NUnit_Asserts {
        get {
            return ResourceManager.GetString("NUnit_Asserts", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Duration: {0}..
    /// </summary>
    internal static string NUnit_Duration {
        get {
            return ResourceManager.GetString("NUnit_Duration", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to End time: {0}..
    /// </summary>
    internal static string NUnit_EndTime {
        get {
            return ResourceManager.GetString("NUnit_EndTime", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Failed: {0}..
    /// </summary>
    internal static string NUnit_Failed {
        get {
            return ResourceManager.GetString("NUnit_Failed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} finished with failed tests. Exit code: {1}..
    /// </summary>
    internal static string NUnit_FinishedWithFailedTests {
        get {
            return ResourceManager.GetString("NUnit_FinishedWithFailedTests", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Inconclusive: {0}..
    /// </summary>
    internal static string NUnit_Inconclusive {
        get {
            return ResourceManager.GetString("NUnit_Inconclusive", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Passed: {0}..
    /// </summary>
    internal static string NUnit_Passed {
        get {
            return ResourceManager.GetString("NUnit_Passed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Skipped: {0}..
    /// </summary>
    internal static string NUnit_Skipped {
        get {
            return ResourceManager.GetString("NUnit_Skipped", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Start time: {0}..
    /// </summary>
    internal static string NUnit_StartTime {
        get {
            return ResourceManager.GetString("NUnit_StartTime", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Test cases: {0}..
    /// </summary>
    internal static string NUnit_TestCases {
        get {
            return ResourceManager.GetString("NUnit_TestCases", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Total: {0}..
    /// </summary>
    internal static string NUnit_Total {
        get {
            return ResourceManager.GetString("NUnit_Total", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Branch coverage: {0}..
    /// </summary>
    internal static string OpenCover_BranchCoverage {
        get {
            return ResourceManager.GetString("OpenCover_BranchCoverage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Class coverage: {0}..
    /// </summary>
    internal static string OpenCover_ClassCoverage {
        get {
            return ResourceManager.GetString("OpenCover_ClassCoverage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Line coverage: {0}..
    /// </summary>
    internal static string OpenCover_LineCoverage {
        get {
            return ResourceManager.GetString("OpenCover_LineCoverage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Maximum cyclomatic complexity: {0}..
    /// </summary>
    internal static string OpenCover_MaxCyclomaticComplexity {
        get {
            return ResourceManager.GetString("OpenCover_MaxCyclomaticComplexity", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Method coverage: {0}..
    /// </summary>
    internal static string OpenCover_MethodCoverage {
        get {
            return ResourceManager.GetString("OpenCover_MethodCoverage", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Minimum branch coverage failed..
    /// </summary>
    internal static string OpenCover_MinBranchCoverageFailed {
        get {
            return ResourceManager.GetString("OpenCover_MinBranchCoverageFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Minimum class coverage failed..
    /// </summary>
    internal static string OpenCover_MinClassCoverageFailed {
        get {
            return ResourceManager.GetString("OpenCover_MinClassCoverageFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Minimum cyclomatic complexity: {0}..
    /// </summary>
    internal static string OpenCover_MinCyclomaticComplexity {
        get {
            return ResourceManager.GetString("OpenCover_MinCyclomaticComplexity", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Minimum line coverage failed..
    /// </summary>
    internal static string OpenCover_MinLineCoverageFailed {
        get {
            return ResourceManager.GetString("OpenCover_MinLineCoverageFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Minimum method coverage failed..
    /// </summary>
    internal static string OpenCover_MinMethodCoverageFailed {
        get {
            return ResourceManager.GetString("OpenCover_MinMethodCoverageFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Target failed. Target&apos;s exit code: {0}..
    /// </summary>
    internal static string OpenCover_TargetFailed {
        get {
            return ResourceManager.GetString("OpenCover_TargetFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The target type is not recognized: &apos;{0}&apos;..
    /// </summary>
    internal static string OpenCover_TargetTypeIsNotRecognized {
        get {
            return ResourceManager.GetString("OpenCover_TargetTypeIsNotRecognized", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Total branches: {0}..
    /// </summary>
    internal static string OpenCover_TotalBranches {
        get {
            return ResourceManager.GetString("OpenCover_TotalBranches", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Total classes: {0}..
    /// </summary>
    internal static string OpenCover_TotalClasses {
        get {
            return ResourceManager.GetString("OpenCover_TotalClasses", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Total lines: {0}..
    /// </summary>
    internal static string OpenCover_TotalLines {
        get {
            return ResourceManager.GetString("OpenCover_TotalLines", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Total methods: {0}..
    /// </summary>
    internal static string OpenCover_TotalMethods {
        get {
            return ResourceManager.GetString("OpenCover_TotalMethods", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Visited branches: {0}..
    /// </summary>
    internal static string OpenCover_VisitedBranches {
        get {
            return ResourceManager.GetString("OpenCover_VisitedBranches", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Visited classes: {0}..
    /// </summary>
    internal static string OpenCover_VisitedClasses {
        get {
            return ResourceManager.GetString("OpenCover_VisitedClasses", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Visited lines: {0}..
    /// </summary>
    internal static string OpenCover_VisitedLines {
        get {
            return ResourceManager.GetString("OpenCover_VisitedLines", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Visited methods: {0}..
    /// </summary>
    internal static string OpenCover_VisitedMethods {
        get {
            return ResourceManager.GetString("OpenCover_VisitedMethods", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} failed for &apos;{1}&apos;. Exit code: {2}..
    /// </summary>
    internal static string ReportGenerator_Failed {
        get {
            return ResourceManager.GetString("ReportGenerator_Failed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to There are no commits yet..
    /// </summary>
    internal static string SvnLog_ThereAreNoCommitsYet {
        get {
            return ResourceManager.GetString("SvnLog_ThereAreNoCommitsYet", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Task failed: &apos;{0}&apos;..
    /// </summary>
    internal static string TaskFailed {
        get {
            return ResourceManager.GetString("TaskFailed", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} failed. Exit code: {1}..
    /// </summary>
    internal static string TaskFailedWithExitCode {
        get {
            return ResourceManager.GetString("TaskFailedWithExitCode", resourceCulture);
        }
    }
}