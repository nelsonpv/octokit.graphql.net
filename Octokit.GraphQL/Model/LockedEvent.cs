namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents a 'locked' event on a given issue or pull request.
    /// </summary>
    public class LockedEvent : QueryableValue<LockedEvent>
    {
        public LockedEvent(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset? CreatedAt { get; }

        public string Id { get; }

        /// <summary>
        /// Object that was locked.
        /// </summary>
        public ILockable Lockable => this.CreateProperty(x => x.Lockable, Octokit.GraphQL.Model.Internal.StubILockable.Create);

        internal static LockedEvent Create(IQueryProvider provider, Expression expression)
        {
            return new LockedEvent(provider, expression);
        }
    }
}