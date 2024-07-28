using UnityEngine;

public class FishMovement {
    private float yBias = 0;
    private float yBiasStep;

    public FishMovement(float yBiasStep) {
        this.yBiasStep = yBiasStep;
    }
    
    public Vector3 calculate(rNpcMovement movement) {
        Vector3 direction = Vector3.left * Random.Range(movement.xMin, movement.xMax) * movement.xSpeed * movement.deltaTime;
        direction += Vector3.up * Random.Range(movement.yMin + yBias, movement.yMax + yBias) * movement.liveliness * movement.ySpeed;
        direction.y += movement.gravity * movement.deltaTime;
        Vector3 position = movement.position + direction * movement.deltaTime;

        if(position.y >= movement.top) {
            position.y = movement.top;
            yBias -= yBiasStep;
        }

        if(position.y <= movement.bottom) {
            position.y = movement.bottom;
            yBias += yBiasStep;
        }

        return position;
    }
}