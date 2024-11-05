using System;

namespace ECS.Core;

/// <summary>
/// </summary>
public readonly struct Entity : IEquatable<Entity>, IEntity
{
    /// <summary>
    ///     The unique identifier of this entity.
    /// </summary>
    public readonly int Id;

    /// <summary>
    ///     Whether this entity is active or not.
    /// </summary>
    public bool Active {
        get => EntitySystem.GetActive(Id);
        internal set => EntitySystem.SetActive(Id, value);
    }

    internal Entity(int id)
        => Id = id;

    public static bool operator ==(Entity left, Entity right)
        => left.Equals(right);

    public static bool operator !=(Entity left, Entity right)
        => !left.Equals(right);

    public bool Equals(Entity other)
        => other.Id == Id;

    public override bool Equals(object obj)
        => obj is Entity entity && Equals(entity);

    public override int GetHashCode()
        => Id;

    public override string ToString()
        => "Id: " + Id;

    public ref T Get<T>() where T : struct
        => throw new NotImplementedException();

    public Entity Set<T>() where T : struct
        => throw new NotImplementedException();

    public bool Has<T>() where T : struct
        => throw new NotImplementedException();

    public bool Remove<T>() where T : struct
        => throw new NotImplementedException();

    public void Destroy()
        => EntitySystem.Destroy(Id);
}
