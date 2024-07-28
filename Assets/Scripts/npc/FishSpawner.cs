using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishes;


    private GameConfig gameConfig;
    private float lastSpawnTime = 0;

    void Awake() {
        gameConfig = new GameConfig();
    }

    void Update() {
        float currentTime = Time.time;
        
        if(currentTime - lastSpawnTime < gameConfig.fishSpawnerConfig.interval) {
            return;
        }

        int idx = Random.Range(0, fishes.Length);
        Vector3 spawnPoint = new Vector3(
            gameConfig.fishSpawnerConfig.right,
            Random.Range(gameConfig.fishSpawnerConfig.bottom, gameConfig.fishSpawnerConfig.top),
            0
        );
        
        lastSpawnTime = currentTime;
        Instantiate(fishes[idx], spawnPoint, Quaternion.identity);
    }
}