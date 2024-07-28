using UnityEngine;
using static Scene;
using static FishMovement;

public abstract class Fish : MonoBehaviour
{
    public virtual float liveliness { get; protected set; }
    public virtual float xSpeed { get; protected set; }
    public virtual float ySpeed { get; protected set; }
    public virtual string species { get; protected set; }
    public virtual rCatchResult catchResult { get; protected set; }

    private float yMin;
    private float yMax;
    private GameConfig config;
    private FishMovement fishMovement;

    void Awake() {
        config = new GameConfig();

        yMin = config.fishConfig.yMinMove;
        yMax = config.fishConfig.yMaxMove;

        fishMovement = new FishMovement(config.fishConfig.moveBias);
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.x >= config.worldConfig.left) {
            rNpcMovement movement = new rNpcMovement {
                xMin = config.fishConfig.xMinMove,
                xMax = config.fishConfig.xMaxMove,
                yMin = yMin,
                yMax = yMax,
                xSpeed = xSpeed,
                ySpeed = ySpeed,
                liveliness = liveliness,
                gravity = config.worldConfig.gravity,
                top = config.worldConfig.top,
                bottom = config.worldConfig.bottom,
                deltaTime = Time.deltaTime,
                position = transform.position
            };

            transform.position = fishMovement.calculate(movement);
        } else {
            Destroy(gameObject);
        }
    }
}
