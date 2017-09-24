using System;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld.Tests.TestAttributes
{
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Event | AttributeTargets.Delegate)]
    public sealed class UnitTestAttribute : TestLabelBaseAttribute
    {
        public UnitTestAttribute()
            : base("Unit")
        {
        }
    }
}
