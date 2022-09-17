using System;

namespace CSharpToTypeScript.Core.Options
{
    public class CodeConversionOptions : ModuleNameConversionOptions
    {
        public CodeConversionOptions(KeywordType keyword, bool useTabs, int? tabSize = null,
            DateOutputType convertDatesTo = DateOutputType.String, NullableOutputType convertNullablesTo = NullableOutputType.Null,
            bool toCamelCase = true, bool removeInterfacePrefix = true, ImportGenerationMode importGenerationMode = ImportGenerationMode.None,
            bool useKebabCase = false, bool appendModelSuffix = false, QuotationMark quotationMark = QuotationMark.Double,
            bool appendNewLine = false, bool stringEnums = false, bool enumStringToCamelCase = false,
            OutputType outputType = OutputType.Interface,bool constEnum = false)
        : base(keyword,useKebabCase, appendModelSuffix, removeInterfacePrefix)
        {
            UseTabs               = useTabs;
            TabSize               = tabSize;
            ConvertDatesTo        = convertDatesTo;
            ConvertNullablesTo    = convertNullablesTo;
            ToCamelCase           = toCamelCase;
            ImportGenerationMode  = importGenerationMode;
            QuotationMark         = quotationMark;
            AppendNewLine         = appendNewLine;
            StringEnums           = stringEnums;
            EnumStringToCamelCase = enumStringToCamelCase;
            OutputType            = outputType;
            ConstEnum             = constEnum;
        }

        public bool                 UseTabs               { get; set; }
        public int?                 TabSize               { get; set; }
        public DateOutputType       ConvertDatesTo        { get; set; }
        public NullableOutputType   ConvertNullablesTo    { get; set; }
        public bool                 ToCamelCase           { get; set; }
        public ImportGenerationMode ImportGenerationMode  { get; set; }
        public QuotationMark        QuotationMark         { get; set; }
        public bool                 AppendNewLine         { get; set; }
        public bool                 StringEnums           { get; set; }
        public bool                 EnumStringToCamelCase { get; set; }
        public OutputType           OutputType            { get; set; }
        public bool           ConstEnum            { get; set; }

        public string GetKeyword()
        {
            string result;
            switch (Keyword)
            {
                case KeywordType.Private:
                    result = string.Empty; 
                    break;
                case KeywordType.Declare:
                case KeywordType.Export:
                    result = Keyword.ToString().ToLower();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }
    }
}