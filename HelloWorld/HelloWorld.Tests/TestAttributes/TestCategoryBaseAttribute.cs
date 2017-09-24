using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld.Tests.TestAttributes
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public abstract class TestCategoryBaseAttribute : Attribute
    {
        public abstract IList<string> TestCategories { get; }
    }
}
