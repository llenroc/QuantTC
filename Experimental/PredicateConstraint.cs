﻿using System;

namespace QuantTC.Experimental
{
    public class PredicateConstraint : IConstraint
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Func<object, bool> Predicate { get; set; }

        public bool Test(object obj) => Predicate(obj);
        public IModel Model { get; set; }
    }
}