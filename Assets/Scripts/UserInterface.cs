using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    public Text scoreText;
    public Text multiplierText;
    public Text clockText;
    public GameObject gameOver;
    public GameObject playButton;
    public GameManager manager;

    private float endTime;
    private GameConfig config;

    void Awake() {
        config = new GameConfig();
    }

    public void UpdateScore(float score, float multiplier) {
        scoreText.text = $"Score: {score}";
        multiplierText.text = $"Multiplier: {multiplier}";
    }

    public void UpdateClock(float now) {
        if(endTime - now <= 0) {
            manager.GameOver();
            return;
        }

        clockText.text = $"{endTime - now}";
    }

    public void SetClock(float time) {
        endTime = time + config.roundTime;
    }

    public void StartGame() {
        gameOver.SetActive(false);
        playButton.SetActive(false);
    }

    public void EndGame() {
        gameOver.SetActive(true);
        playButton.SetActive(true);
    }
}