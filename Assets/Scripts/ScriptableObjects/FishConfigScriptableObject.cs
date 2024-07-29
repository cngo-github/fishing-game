using UnityEngine;

[CreateAssetMenu(fileName = "FishConfigScriptableObject", menuName = "ScriptableObjects/FishConfig")]
public class FishConfigScriptableObject : ScriptableObject
{
    [SerializeField]
    public float xMaxMove = 1f;
    [SerializeField]
    public float xMinMove = 0f;
    [SerializeField]
    public float yMaxMove = 1f;
    [SerializeField]
    public float yMinMove = -1f;
    [SerializeField]
    public float moveBias = 0.1f;
}
