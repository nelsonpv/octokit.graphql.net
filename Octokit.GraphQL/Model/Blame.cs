namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a Git blame.
    /// </summary>
    public class Blame : QueryableValue<Blame>
    {
        public Blame(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// The list of ranges from a Git blame.
        /// </summary>
        public IQueryableList<BlameRange> Ranges => this.CreateProperty(x => x.Ranges);

        internal static Blame Create(IQueryProvider provider, Expression expression)
        {
            return new Blame(provider, expression);
        }
    }
}