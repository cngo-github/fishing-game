using UnityEngine;
using System;

public class WorldUtilities : MonoBehaviour
{
    public static WorldUtilities instance {
        get { return _instance; }
        private set { }
    }

    private static WorldUtilities _instance;

    public float top { get; private set; }
    public float bottom { get; private set; }
    public float left { get; private set; }

    [SerializeField]
    private WorldConfigScriptableObject worldConfig;

    void Awake() {
        this.top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height + worldConfig.topYOffset, 0)).y;
        this.bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, worldConfig.bottomYOffset, 0)).y;
        this.left = Camera.main.ScreenToWorldPoint(new Vector3(worldConfig.leftXOffset, 0, 0)).x;

        if(_instance != null && _instance != this) {
            throw new Exception("Creating another instance of a singleton.");
        } else {
            _instance = this;
        }
    }
}