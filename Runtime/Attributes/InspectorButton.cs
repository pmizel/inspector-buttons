using System;

[AttributeUsage (AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public sealed class InspectorButton : Attribute { }