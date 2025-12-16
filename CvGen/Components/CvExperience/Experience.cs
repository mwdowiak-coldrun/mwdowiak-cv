using System.Collections.Immutable;

namespace CvGen.Components.CvExperience;

public record Experience(
    string Company,
    string Position,
    string Description,
    DateOnly From,
    DateOnly? To,
    ImmutableArray<string> Keywords,
    ImmutableArray<Project> Projects
)
{
    private string FromDateString => $"{From.ToString("yyyy-MM")}";
    private string ToDateString => $"{To?.ToString("yyyy-MM") ?? "Present"}";
    public string DatesRangeToString => $"{FromDateString} - {ToDateString}";

    public ImmutableArray<string> AllKeywords => [
        ..Keywords
            .AddRange(Projects.SelectMany(p => p.Keywords))
            .Distinct()
    ];

    public static Experience Create(
        string company,
        string position,
        string description,
        DateOnly from, DateOnly? to = null
    ) => new(
        company,
        position,
        description,
        from,
        to,
        ImmutableArray<string>.Empty,
        ImmutableArray<Project>.Empty
    );

    public static Experience Default => Create(
        "Company",
        "Position",
        "Description",
        DateOnly.FromDateTime(DateTime.Now),
        DateOnly.FromDateTime(DateTime.Now.AddYears(-2))
    );
}
