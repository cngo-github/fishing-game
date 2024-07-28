using UnityEngine;

public record rPlayerConfig {
    public float gravity { get; init; }
    public float strength { get; init; }
    public Vector3 startPosition { get; init; }
}