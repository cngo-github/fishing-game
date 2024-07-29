using UnityEngine;

[CreateAssetMenu(fileName = "FishSpawnerConfigScriptableObject", menuName = "ScriptableObjects/FishSpawnerConfig")]
public class FishSpawnerConfigScriptableObject : ScriptableObject
{
    [SerializeField]
    public int topYOffset = -150;
    [SerializeField]
    public int bottomYOffset = 150;
    [SerializeField]
    public int rightXOffset = 20;
    [SerializeField]
    public float interval = 7f;
}
