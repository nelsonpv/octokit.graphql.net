namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of MoveProjectCard
    /// </summary>
    public class MoveProjectCardPayload : QueryableValue<MoveProjectCardPayload>
    {
        public MoveProjectCardPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// The new edge of the moved card.
        /// </summary>
        public ProjectCardEdge CardEdge => this.CreateProperty(x => x.CardEdge, Octokit.GraphQL.Model.ProjectCardEdge.Create);

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        internal static MoveProjectCardPayload Create(IQueryProvider provider, Expression expression)
        {
            return new MoveProjectCardPayload(provider, expression);
        }
    }
}