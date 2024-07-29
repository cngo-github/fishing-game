using UnityEngine;

[CreateAssetMenu(fileName = "GameConfigScriptableObject", menuName = "ScriptableObjects/GameConfig")]
public class GameConfigScriptableObject : ScriptableObject
{
    [SerializeField]
    public float roundTime = 60f;
}
