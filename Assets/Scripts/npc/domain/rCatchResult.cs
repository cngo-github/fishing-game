public record rCatchResult {
    public bool isGameOver { get; init; }
    public rScoreUpdate scoreUpdate { get; init; }
    public string message { get; init; }
}