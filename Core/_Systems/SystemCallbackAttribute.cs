using System;

namespace ECS.Core;

/// <summary>
///
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class SystemCallbackAttribute<T> : Attribute where T : Delegate;
