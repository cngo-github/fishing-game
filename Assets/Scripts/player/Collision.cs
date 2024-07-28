using UnityEngine;

using static Scoreboard;

public static class Collision
{
    public static rCatchResult process(string tag) {
        rCatchResult result;

        switch (tag)
        {
            case "Ground":
                result = new rCatchResult { isGameOver = true, scoreUpdate = Scoreboard.emptyUpdate(), message = "Oow!" };
                break;
            case "Shark":
                result = Object.FindObjectOfType<Shark>().catchResult;
                break;
            case "Goldfish":
                result = Object.FindObjectOfType<Goldfish>().catchResult;
                break;
            case "Zombie":
                result = Object.FindObjectOfType<Zombie>().catchResult;
                break;
            case "Octopus":
                result = Object.FindObjectOfType<Octopus>().catchResult;
                break;
            case "Tuna":
                result = Object.FindObjectOfType<Tuna>().catchResult;
                break;
            default:
                result = new rCatchResult { isGameOver = false, scoreUpdate = Scoreboard.emptyUpdate(), message = "Shouldn't happen." };
                break;
        }

        return result;
    }
}