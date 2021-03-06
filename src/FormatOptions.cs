﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Tools.Utilities;
using Microsoft.Extensions.Logging;

namespace Microsoft.CodeAnalysis.Tools
{
    internal class FormatOptions
    {
        public string WorkspaceFilePath { get; }
        public WorkspaceType WorkspaceType { get; }
        public LogLevel LogLevel { get; }
        public bool FixCodeStyle { get; }
        public DiagnosticSeverity CodeStyleSeverity { get; }
        public bool FixAnalyzers { get; }
        public DiagnosticSeverity AnalyzerSeverity { get; }
        public bool SaveFormattedFiles { get; }
        public bool ChangesAreErrors { get; }
        public SourceFileMatcher FileMatcher { get; }
        public string? ReportPath { get; }
        public bool IncludeGeneratedFiles { get; }

        public FormatOptions(
            string workspaceFilePath,
            WorkspaceType workspaceType,
            LogLevel logLevel,
            bool fixCodeStyle,
            DiagnosticSeverity codeStyleSeverity,
            bool fixAnalyzers,
            DiagnosticSeverity analyzerSeverity,
            bool saveFormattedFiles,
            bool changesAreErrors,
            SourceFileMatcher fileMatcher,
            string? reportPath,
            bool includeGeneratedFiles)
        {
            WorkspaceFilePath = workspaceFilePath;
            WorkspaceType = workspaceType;
            LogLevel = logLevel;
            FixCodeStyle = fixCodeStyle;
            CodeStyleSeverity = codeStyleSeverity;
            FixAnalyzers = fixAnalyzers;
            AnalyzerSeverity = analyzerSeverity;
            SaveFormattedFiles = saveFormattedFiles;
            ChangesAreErrors = changesAreErrors;
            FileMatcher = fileMatcher;
            ReportPath = reportPath;
            IncludeGeneratedFiles = includeGeneratedFiles;
        }

        public void Deconstruct(
            out string workspaceFilePath,
            out WorkspaceType workspaceType,
            out LogLevel logLevel,
            out bool fixCodeStyle,
            out DiagnosticSeverity codeStyleSeverity,
            out bool fixAnalyzers,
            out DiagnosticSeverity analyzerSeverity,
            out bool saveFormattedFiles,
            out bool changesAreErrors,
            out SourceFileMatcher fileMatcher,
            out string? reportPath,
            out bool includeGeneratedFiles)
        {
            workspaceFilePath = WorkspaceFilePath;
            workspaceType = WorkspaceType;
            logLevel = LogLevel;
            fixCodeStyle = FixCodeStyle;
            codeStyleSeverity = CodeStyleSeverity;
            fixAnalyzers = FixAnalyzers;
            analyzerSeverity = AnalyzerSeverity;
            saveFormattedFiles = SaveFormattedFiles;
            changesAreErrors = ChangesAreErrors;
            fileMatcher = FileMatcher;
            reportPath = ReportPath;
            includeGeneratedFiles = IncludeGeneratedFiles;
        }
    }
}
