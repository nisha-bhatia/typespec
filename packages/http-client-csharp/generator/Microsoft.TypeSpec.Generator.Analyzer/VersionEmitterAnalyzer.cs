// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Azure.ClientSdk.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public sealed class VersionEmitterAnalyzer : DiagnosticAnalyzer
    {
        private static readonly DiagnosticDescriptor s_mTG001 = new DiagnosticDescriptor(
            id: "MTG001",
            title: "Version Mismatch",
            messageFormat: "The version of Microsoft.TypeSpec.Generator.ClientModel ({0}) does not match the MGC version ({1})",
            category: "Versioning",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            customTags: new[] { WellKnownDiagnosticTags.CompilationEnd }
        );

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create(s_mTG001);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze);
            context.EnableConcurrentExecution();
            context.RegisterCompilationAction(AnalyzeCompilation);
            //System.Diagnostics.Debugger.Launch();
            //throw new Exception();
            //Console.Error.WriteLine("Initialize method called ERROR");
            //context.RegisterCompilationStartAction((CompilationStartAnalysisContext context)) -> { });
            //AnalyzeCompilation);
        }

        private void AnalyzeCompilation(CompilationAnalysisContext context)
        {
            //System.Diagnostics.Debugger.Launch();
            Console.WriteLine("AnalyzeCompilation method called");
            Console.Error.WriteLine("AnalyzeCompilation method called ERROR");

            // ClientModel version
            var clientModelVersion = context.Compilation.ReferencedAssemblyNames
            .FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.ClientModel", StringComparison.OrdinalIgnoreCase));

            // Emitter version
            // Get current directory
            var filePath = context.Compilation.SyntaxTrees.First().FilePath;
            // Find the first package.json in the tree above
            var packageJsonLocation = FindPackageJson(filePath);
            if (packageJsonLocation is null)
            {
                throw new NullReferenceException("Typespec/http-client-csharp version is missing");
            }

            // Extract json content from the package.json file
            var packageJsonPath = Path.Combine(packageJsonLocation, "package.json");
            AdditionalText? packageJsonFile = context.Options.AdditionalFiles
                .FirstOrDefault(file => file.Path.Equals(packageJsonPath, StringComparison.OrdinalIgnoreCase));
            var packageJsonContent = packageJsonFile!.GetText(context.CancellationToken)?.ToString();
            using var jsonDocument = JsonDocument.Parse(packageJsonContent!);
            var rootElement = jsonDocument.RootElement;

            // Extract the version of the http-client-csharp dependency
            string? emitterVersion = null;
            if (rootElement.TryGetProperty("dependencies", out var dependencies) &&
                dependencies.TryGetProperty("http-client-csharp", out var httpClientVersionElement))
            {
                emitterVersion = httpClientVersionElement.GetString();
            }

            if (emitterVersion == null)
            {
                throw new NullReferenceException("Typespec/http-client-csharp version is missing in package.json.");
            }

            if (clientModelVersion!.Version.ToString() != emitterVersion)
            {
                var diagnostic = Diagnostic.Create(s_mTG001, Location.None);
                context.ReportDiagnostic(diagnostic);
            }
        }

        // Recursive helper function to search upwards for first package.json file
        private static string? FindPackageJson(string startDirectory)
        {
            var dir = new DirectoryInfo(startDirectory);
            while (dir != null)
            {
                if (dir.Name == "package.json")
                {
                    return dir.Parent?.FullName;
                }

                dir = dir.Parent;
            }
            return null;
        }

        //public void Analyze(SymbolAnalysisContext context)
        //{
        //    // var expected = //comes from package.json, get location of csproj that you're built from then do relative directory to package.json
        //    // // look for http-client-csharp dependency and get version from there
        //    // //var actual comes from package reference in this context
        //    // var actual = context.Compilation.ReferencedAssemblyNames.FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.ClientModel", StringComparison.OrdinalIgnoreCase)).Version;
        //    Console.WriteLine("Analyze method called");
        //    Console.Error.WriteLine("Analyze method called ERROR");
        //    var clientModelVersion = context.Compilation.ReferencedAssemblyNames
        //        .FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.ClientModel", StringComparison.OrdinalIgnoreCase));
        //    var emitterVersion = context.Compilation.ReferencedAssemblyNames
        //        .FirstOrDefault(a => a.Name.Equals("Microsoft.TypeSpec.Generator.Emitter", StringComparison.OrdinalIgnoreCase));

        //    //if (clientModelVersion != emitterVersion)
        //    //{
        //    //    var diagnostic = Diagnostic.Create(VersionMismatchRule, Location.None, clientModelVersion, mgcVersion);
        //    //    context.RegisterCompilationEndAction(compilationContext => compilationContext.ReportDiagnostic(diagnostic));
        //    //}
        //}
    }
}
