using System;

namespace ModelGenerator
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class HasViewModelAttribute: Attribute
    {
        
    }
}