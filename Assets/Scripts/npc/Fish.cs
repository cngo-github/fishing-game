using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    public virtual float liveliness { get; protected set; }
    public virtual float xSpeed { get; protected set; }
    public virtual float ySpeed { get; protected set; }
    public virtual string species { get; protected set; }
    public virtual rCatchResult catchResult { get; protected set; }
    
    [SerializeField]
    private WorldConfigScriptableObject worldConfig;
    [SerializeField]
    private FishConfigScriptableObject fishConfig;

    private float yBias = 0;
    private float top;
    private float bottom;
    private float left;

    void Awake() {
        if(Camera.main != null) {
            top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height + worldConfig.topYOffset, 0)).y;
            bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, worldConfig.bottomYOffset, 0)).y;
            left = Camera.main.ScreenToWorldPoint(new Vector3(worldConfig.leftXOffset, 0, 0)).x;
        }
    }

    void Update() {
        if(transform.position.x >= left) {
            Move();
        } else {
            Destroy(gameObject);
        }
    }

    void Move() {
        float elapsedTime = Time.deltaTime;

        Vector3 v = new Vector3(
            -1 * Random.Range(fishConfig.xMinMove, fishConfig.xMaxMove) * xSpeed * elapsedTime,
            Random.Range(fishConfig.yMinMove + yBias, fishConfig.yMaxMove + yBias) * liveliness * ySpeed + worldConfig.gravity * elapsedTime,
            0
        );
        Vector3 update = transform.position + v * elapsedTime;

        if(update.y >= top) {
            update.y = top;
            yBias -= fishConfig.moveBias;
        }

        if(update.y <= bottom) {
            update.y = bottom;
            yBias += fishConfig.moveBias;
        }

        transform.position = update;
    }
}
