using UnityEngine;

using static Collision;

public class Player : MonoBehaviour
{
    [SerializeField]
    private WorldConfigScriptableObject worldConfig;
    [SerializeField]
    private PlayerConfigScriptableObject playerConfig;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            MoveUp();
        }

        DropDown();
    }

    void OnEnable() {
        Vector3 position = transform.position;
        position.y = 0f;

        transform.position = position;
    }

    void MoveUp() {
        Vector3 v = new Vector3(0, playerConfig.strength, 0);

        transform.position += v * Time.deltaTime;
    }

    void DropDown() {
        Vector3 v = new Vector3(0, worldConfig.gravity * Time.deltaTime, 0);

        transform.position += v * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        rCatchResult catchResult = Collision.process(other.gameObject.tag);
        FindObjectOfType<GameManager>().processCatch(catchResult);

        if(other.gameObject.tag != "Ground") {
            Destroy(other.gameObject);
        }
    }
}