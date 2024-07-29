using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfigScriptableObject", menuName = "ScriptableObjects/PlayerConfig")]
public class PlayerConfigScriptableObject : ScriptableObject
{
    [SerializeField]
    public float strength = 20f;
}
