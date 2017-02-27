﻿using System;
using System.Linq;
using System.Linq.Expressions;
using LinqToGraphQL.Builders;

namespace LinqToGraphQL.UnitTests.Models
{
    class NestedQuery : QueryEntity
    {
        public NestedQuery(IQueryProvider provider, Expression expression)
            : base(provider, expression)
        {
        }

        public IQueryable<Simple> Simple(string arg1)
        {
            return this.CreateMethodCall(x => x.Simple(arg1));
        }

        internal static NestedQuery Create(IQueryProvider provider, Expression expression)
        {
            return new NestedQuery(provider, expression);
        }
    }
}
