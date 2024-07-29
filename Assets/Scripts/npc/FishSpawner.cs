using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject[] fishes;


    [SerializeField]
    private FishSpawnerConfigScriptableObject fishSpawnerConfig;

    private float lastSpawnTime = 0;
    private float top;
    private float bottom;
    private float right;

    void Awake() {
        if(Camera.main != null) {
            top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height + fishSpawnerConfig.topYOffset, 0)).y;
            bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, fishSpawnerConfig.bottomYOffset, 0)).y;
            right = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + fishSpawnerConfig.rightXOffset, 0, 0)).x;
        }
    }

    void Update() {
        float currentTime = Time.time;
        
        if(currentTime - lastSpawnTime >= fishSpawnerConfig.interval) {
            SpawnFish();
            lastSpawnTime = currentTime;
        }
    }

    void SpawnFish() {
        int idx = Random.Range(0, fishes.Length);
        Vector3 spawnPoint = new Vector3(right, Random.Range(bottom, top), 0);
        
        Instantiate(fishes[idx], spawnPoint, Quaternion.identity);
    }
}