using UnityEngine;

[CreateAssetMenu(fileName = "WorldConfigScriptableObject", menuName = "ScriptableObjects/WorldConfig")]
public class WorldConfigScriptableObject : ScriptableObject
{
    [SerializeField]
    public int topYOffset = -100;
    [SerializeField]
    public int bottomYOffset = 100;
    [SerializeField]
    public int leftXOffset = -20;
    [SerializeField]
    public float gravity = -6f;
}
