using UnityEngine;

public static class PlayerMovement {
    public static Vector3 calculate(rPlayerMovement movement) {
        Vector3 direction = movement.keyPressed ? Vector3.up * movement.strength : Vector3.zero;
        direction.y += movement.gravity * movement.deltaTime;

        return direction * movement.deltaTime;
    }
}