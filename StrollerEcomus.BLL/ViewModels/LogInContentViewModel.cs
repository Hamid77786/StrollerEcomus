

namespace StrollerEcomus.BLL.ViewModels;

public class LogInContentViewModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}

public class CreateLogInContentViewModel
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}

public class UpdateLogInContentViewModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
