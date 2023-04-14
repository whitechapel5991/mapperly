using Microsoft.CodeAnalysis;
using Riok.Mapperly.Abstractions;
using Riok.Mapperly.Descriptors.Mappings;

namespace Riok.Mapperly.Descriptors.MappingBodyBuilders.BuilderContext;

/// <summary>
/// Context to build member mappings.
/// </summary>
/// <typeparam name="T">The type of the mapping.</typeparam>
public interface IMembersBuilderContext<out T>
    where T : IMapping
{
    T Mapping { get; }

    void AddDiagnostics();

    MappingBuilderContext BuilderContext { get; }

    IReadOnlyCollection<string> IgnoredSourceMemberNames { get; }

    Dictionary<string, IPropertySymbol> TargetMembers { get; }

    Dictionary<string, List<MapPropertyAttribute>> MemberConfigsByRootTargetName { get; }
}