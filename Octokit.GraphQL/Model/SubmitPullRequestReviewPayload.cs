namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of SubmitPullRequestReview
    /// </summary>
    public class SubmitPullRequestReviewPayload : QueryableValue<SubmitPullRequestReviewPayload>
    {
        public SubmitPullRequestReviewPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The submitted pull request review.
        /// </summary>
        public PullRequestReview PullRequestReview => this.CreateProperty(x => x.PullRequestReview, Octokit.GraphQL.Model.PullRequestReview.Create);

        internal static SubmitPullRequestReviewPayload Create(IQueryProvider provider, Expression expression)
        {
            return new SubmitPullRequestReviewPayload(provider, expression);
        }
    }
}