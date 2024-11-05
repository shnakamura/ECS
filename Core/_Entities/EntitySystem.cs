using System;
using Terraria.ModLoader;

namespace ECS.Core;

/// <summary>
/// </summary>
public sealed class EntitySystem : ModSystem
{
    private static long flags;

    public static event Action<Entity> OnEntityCreated;
    public static event Action<Entity> OnEntityDestroyed;

    public static Entity Create()
        => new();

    public static bool Destroy(int id)
        => false;

    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <param name="value"></param>
    internal static void SetActive(int id, bool value) {
        var mask = 1 << id;

        if (value) {
            flags |= mask;
        }
        else {
            flags &= ~mask;
        }
    }

    /// <summary>
    /// </summary>
    /// <param name="id"></param>
    /// <returns><c>true</c> if the entity is active; otherwise, <c>false</c>.</returns>
    internal static bool GetActive(int id) {
        var mask = 1 << id;

        return (flags & mask) != 0;
    }
}
