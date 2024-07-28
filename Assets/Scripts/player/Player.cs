using UnityEngine;

using static PlayerMovement;
using static Collision;

public class Player : MonoBehaviour
{
    private GameConfig config;

    void Awake() {
        config = new GameConfig();
    }

    void Update() {
        rPlayerMovement movement = new rPlayerMovement {
            keyPressed = Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0),
            gravity = config.worldConfig.gravity,
            strength = config.playerConfig.strength,
            deltaTime = Time.deltaTime
        };
        
        transform.position += PlayerMovement.calculate(movement);
    }

    void OnEnable() {
        Vector3 position = transform.position;
        position.y = 0f;

        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        rCatchResult catchResult = Collision.process(other.gameObject.tag);
        FindObjectOfType<GameManager>().processCatch(catchResult);

        if(other.gameObject.tag != "Ground") {
            Destroy(other.gameObject);
        }
    }
}