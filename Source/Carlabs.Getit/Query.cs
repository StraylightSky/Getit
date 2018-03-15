﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Carlabs.Getit
{
    public class Query
    {
        public List<string> SelectList { get; } = new List<string>();
        public List<Query> WithList { get; } = new List<Query>();
        public Dictionary<string, object> WhereMap { get; } = new Dictionary<string, object>();

        public Query Select(IEnumerable<string> stringList)
        {
            SelectList.AddRange(stringList);

            return this;
        }

        public Query Select(params string[] selects)
        {
            SelectList.AddRange(selects);

            return this;
        }

        public Query Where(string key, object where)
        {
            WhereMap.Add(key, where);

            return this;
        }

        public Query With(IEnumerable<Query> query)
        {
            WithList.AddRange(query);

            return this;
        }

        public Query With(params Query[] query)
        {
            WithList.AddRange(query);

            return this;
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
