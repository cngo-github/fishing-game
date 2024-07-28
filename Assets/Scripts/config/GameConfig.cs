using UnityEngine;

public class GameConfig {
    public rPlayerConfig playerConfig;
    public rWorldConfig worldConfig;
    public rFishConfig fishConfig;
    public rFishSpawnerConfig fishSpawnerConfig;
    public float roundTime = 60f;

    public GameConfig() {
        worldConfig = new rWorldConfig {
            top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height - 100, 0)).y,
            bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 100, 0)).y,
            left = Camera.main.ScreenToWorldPoint(new Vector3(-20, 0, 0)).x,
            gravity = -6f
        };
        playerConfig = new rPlayerConfig {
            gravity = worldConfig.gravity,
            strength = 20f,
            startPosition = Camera.main.ScreenToWorldPoint(new Vector3(100, Screen.height - 100, 0))
        };
        fishConfig = new rFishConfig { xMaxMove = 1f, xMinMove = 0f, yMaxMove = 1f, yMinMove = -1f, moveBias = 0.1f };
        fishSpawnerConfig = new rFishSpawnerConfig {
            top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height - 150, 0)).y,
            bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 150, 0)).y,
            right = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 20, 0, 0)).x,
            interval = 7f
        };
    }
}