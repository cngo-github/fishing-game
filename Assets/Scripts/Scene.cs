using UnityEngine;

public static class Scene {
    public static float top = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height - 70, 0)).y;
    public static float bottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 70, 0)).y;
}