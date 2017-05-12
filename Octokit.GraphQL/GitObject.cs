namespace Octokit.GraphQL
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a Git object.
    /// </summary>
    public interface IGitObject : IQueryEntity
    {
        string Id { get; }

        /// <summary>
        /// The Git object ID
        /// </summary>
        string Oid { get; }

        /// <summary>
        /// The Repository the Git object belongs to
        /// </summary>
        Repository Repository { get; }
    }
}

namespace Octokit.GraphQL.Internal
{
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    internal class StubIGitObject : QueryEntity, IGitObject
    {
        public StubIGitObject(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public string Id { get; }

        public string Oid { get; }

        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Repository.Create);

        internal static StubIGitObject Create(IQueryProvider provider, Expression expression)
        {
            return new StubIGitObject(provider, expression);
        }
    }
}