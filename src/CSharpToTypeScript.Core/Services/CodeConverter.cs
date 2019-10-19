using CSharpToTypeScript.Core.Options;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpToTypeScript.Core.Services
{
    internal class CodeConverter : ICodeConverter
    {
        private readonly SyntaxTreeConverter _syntaxTreeConverter;

        public CodeConverter(SyntaxTreeConverter syntaxTreeConverter)
        {
            _syntaxTreeConverter = syntaxTreeConverter;
        }

        public string ConvertToTypeScript(string code, CodeConversionOptions options)
        {
            var root = CSharpSyntaxTree.ParseText(code).GetCompilationUnitRoot();

            var converted = _syntaxTreeConverter.Convert(root);

            return converted.WriteTypeScript(options);
        }
    }
}