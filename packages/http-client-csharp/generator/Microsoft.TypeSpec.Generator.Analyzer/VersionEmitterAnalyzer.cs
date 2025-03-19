// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Azure.ClientSdk.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class VersionEmitterAnalyzer : DiagnosticAnalyzer
    {
        private static readonly DiagnosticDescriptor VersionMismatchRule = new DiagnosticDescriptor(
            id: "MGC001",
            title: "Version Mismatch",
            messageFormat: "The version of Microsoft.TypeSpec.Generator.ClientModel ({0}) does not match the MGC version ({1}).",
            category: "Versioning",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create(VersionMismatchRule);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();
            context.RegisterCompilationStartAction(AnalyzeCompilation);
        }

        public void Analyze(SymbolAnalysisContext context)
        {
            // var expected = //comes from package.json, get location of csproj that you're built from then do relative directory to package.json
            // // look for http-client-csharp dependency and get version from there
            // //var actual comes from package reference in this context
            // var actual = context.Compilation.ReferencedAssemblyNames.FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.ClientModel", StringComparison.OrdinalIgnoreCase)).Version;
            Console.WriteLine("Analyze method called");
            // var clientModelVersion = context.Compilation.ReferencedAssemblyNames
            //     .FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.ClientModel", StringComparison.OrdinalIgnoreCase));
            // var emitterVersion = context.Compilation.ReferencedAssemblyNames
            //     .FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.Emitter", StringComparison.OrdinalIgnoreCase));

            // if (clientModelReference != null && mgcReference != null)
            // {
            //     var clientModelVersion = clientModelReference.Version;
            //     var mgcVersion = mgcReference.Version;

            //     if (clientModelVersion != mgcVersion)
            //     {
            //         var diagnostic = Diagnostic.Create(VersionMismatchRule, Location.None, clientModelVersion, mgcVersion);
            //         context.RegisterCompilationEndAction(compilationContext => compilationContext.ReportDiagnostic(diagnostic));
            //     }
            // }
        }
    }
}
