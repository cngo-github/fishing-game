using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public UserInterface ui;

    private Scoreboard scoreboard;
    private bool gamePaused = true;

    void Awake() {
        Application.targetFrameRate = 60;

        ui.EndGame();
        Pause();

        scoreboard = new Scoreboard();
    }

    void Update() {
        if(gamePaused) {
            return;
        }

        ui.UpdateClock(Time.time);
    }

    public void Play() {
        Fish[] fishes = FindObjectsOfType<Fish>();

        foreach (var fish in fishes)
        {
            Destroy(fish.gameObject);
        }

        scoreboard.Reset();

        ui.UpdateScore(scoreboard.score, scoreboard.multiplier);
        ui.SetClock(Time.time);
        ui.StartGame();

        Unpause();
    }

    public void GameOver() {
        ui.EndGame();

        Pause();
    }

    public void processCatch(rCatchResult result) {
        if(result.isGameOver) {
            GameOver();
            return;
        }

        scoreboard.Update(result.scoreUpdate);
        ui.UpdateScore(scoreboard.score, scoreboard.multiplier);
    }

    private void Pause() {
        Time.timeScale = 0f;
        gamePaused = true;
        player.enabled = false;
    }

    public void Unpause() {
        Time.timeScale = 1f;
        gamePaused = false;
        player.enabled = true;
    }
}