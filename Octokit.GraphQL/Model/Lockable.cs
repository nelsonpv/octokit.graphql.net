namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Model;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An object that can be locked.
    /// </summary>
    public interface ILockable : IQueryableValue<ILockable>
    {
        /// <summary>
        /// Reason that the conversation was locked.
        /// </summary>
        LockReason? ActiveLockReason { get; }

        /// <summary>
        /// `true` if the object is locked
        /// </summary>
        bool Locked { get; }
    }
}

namespace Octokit.GraphQL.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    internal class StubILockable : QueryableValue<StubILockable>, ILockable
    {
        public StubILockable(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        public LockReason? ActiveLockReason { get; }

        public bool Locked { get; }

        internal static StubILockable Create(IQueryProvider provider, Expression expression)
        {
            return new StubILockable(provider, expression);
        }
    }
}