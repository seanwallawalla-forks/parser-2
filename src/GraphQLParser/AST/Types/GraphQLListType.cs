namespace GraphQLParser.AST;

/// <summary>
/// AST node for <see cref="ASTNodeKind.ListType"/>.
/// </summary>
public class GraphQLListType : GraphQLType
{
    /// <inheritdoc/>
    public override ASTNodeKind Kind => ASTNodeKind.ListType;

    /// <summary>
    /// Nested <see cref="GraphQLType"/> AST node with wrapped type.
    /// </summary>
    public GraphQLType Type { get; set; } = null!;
}

internal sealed class GraphQLListTypeWithLocation : GraphQLListType
{
    private GraphQLLocation _location;

    public override GraphQLLocation Location
    {
        get => _location;
        set => _location = value;
    }
}

internal sealed class GraphQLListTypeWithComment : GraphQLListType
{
    private GraphQLComment? _comment;

    public override GraphQLComment? Comment
    {
        get => _comment;
        set => _comment = value;
    }
}

internal sealed class GraphQLListTypeFull : GraphQLListType
{
    private GraphQLLocation _location;
    private GraphQLComment? _comment;

    public override GraphQLLocation Location
    {
        get => _location;
        set => _location = value;
    }

    public override GraphQLComment? Comment
    {
        get => _comment;
        set => _comment = value;
    }
}