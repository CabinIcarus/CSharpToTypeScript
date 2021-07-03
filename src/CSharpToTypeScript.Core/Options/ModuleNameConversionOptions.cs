namespace CSharpToTypeScript.Core.Options
{
    public class ModuleNameConversionOptions
    {
        public ModuleNameConversionOptions(KeywordType keyword,bool useKebabCase, bool appendModelSuffix, bool removeInterfacePrefix = true)
        {
            Keyword = keyword;

            UseKebabCase = useKebabCase;
            AppendModelSuffix = appendModelSuffix;
            RemoveInterfacePrefix = removeInterfacePrefix;
        }
        
        public KeywordType Keyword { get; set; }
        public bool UseKebabCase { get; set; }
        public bool AppendModelSuffix { get; set; }
        public bool RemoveInterfacePrefix { get; set; }
    }
}