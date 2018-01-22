namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class MilestoneEdge : QueryableValue<MilestoneEdge>
    {
        public MilestoneEdge(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public Milestone Node => this.CreateProperty(x => x.Node, Octokit.GraphQL.Model.Milestone.Create);

        internal static MilestoneEdge Create(IQueryProvider provider, Expression expression)
        {
            return new MilestoneEdge(provider, expression);
        }
    }
}