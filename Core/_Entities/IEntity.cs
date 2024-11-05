namespace ECS.Core;

/// <summary>
///
/// </summary>
public interface IEntity
{
    /// <summary>
    ///     Gets the value of a component from the entity.
    /// </summary>
    /// <typeparam name="T">The type of the component to retrieve.</typeparam>
    /// <returns></returns>
    ref T Get<T>() where T : struct;

    /// <summary>
    ///     Sets the value of a component on the entity.
    /// </summary>
    /// <typeparam name="T">The type of the component to set.</typeparam>
    /// <returns>The <see cref="Entity"/> instance.</returns>
    Entity Set<T>() where T : struct;

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T">The type of the component to check.</typeparam>
    /// <returns><c>true</c> if the entity has the specified component; otherwise, <c>false</c></returns>
    bool Has<T>() where T : struct;

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T">The type of the component to remove.</typeparam>
    /// <returns><c>true</c> if the specified component was removed; otherwise, <c>false</c></returns>
    bool Remove<T>() where T : struct;
}
