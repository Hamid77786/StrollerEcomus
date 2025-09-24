

namespace StrollerEcomus.BLL.ViewModels;

public class LanguageViewModel
{
    public int Id { get; set; }
    public string? LanguageName { get; set; }
}

public class CreateLanguageViewModel
{
    public string LanguageName { get; set; } = null!;
}

public class UpdateLanguageViewModel
{
    public int Id { get; set; }
    public string LanguageName { get; set; }= null!;
}

