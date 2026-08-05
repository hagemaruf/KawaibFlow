namespace KawaibFlow.Application.Configuration;

public sealed class DatabaseOptions
{
    public const string SectionName = "ConnectionStrings";

    public string DefaultConnection { get; init; } = string.Empty;
}
