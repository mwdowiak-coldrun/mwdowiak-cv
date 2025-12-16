using System.Collections.Immutable;

namespace CvGen.Components.CvExperience;

public record Project(
    string Name,
    string Description,
    ImmutableArray<string> Keywords
)
{
    public static Project Create(
        string name,
        string description,
        ImmutableArray<string> keywords
    ) => new(name, description, keywords);

    public static Project Default => Create(
        "Project",
        "Description",
        ImmutableArray<string>.Empty
    );
}
