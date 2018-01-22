namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents the language of a repository.
    /// </summary>
    public class LanguageEdge : QueryableValue<LanguageEdge>
    {
        public LanguageEdge(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public string Cursor { get; }

        public Language Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Model.Language.Create);

        /// <summary>
        /// The number of bytes of code written in the language.
        /// </summary>
        public int Size { get; }

        internal static LanguageEdge Create(IQueryProvider provider, Expression expression)
        {
            return new LanguageEdge(provider, expression);
        }
    }
}