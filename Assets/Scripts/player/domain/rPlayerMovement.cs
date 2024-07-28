public record rPlayerMovement {
    public bool keyPressed { get; init; }
    public float gravity { get; init; }
    public float strength { get; init; }
    public float deltaTime { get; init; }
}