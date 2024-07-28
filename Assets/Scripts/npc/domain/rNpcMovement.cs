using UnityEngine;

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit
    {

    }
}

public record rNpcMovement {
    public float xMin { get; init; }
    public float xMax { get; init; }
    public float yMin { get; init; }
    public float yMax { get; init; }
    public float xSpeed { get; init; }
    public float ySpeed { get; init; }
    public float liveliness { get; init; }
    public float gravity { get; init; }
    public float top { get; init; }
    public float bottom { get; init; }
    public float deltaTime { get; init; }
    public Vector3 position { get; init; }
}