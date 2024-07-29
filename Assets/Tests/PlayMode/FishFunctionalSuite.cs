using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FishFunctionalSuite
{
    [Test]
    public void FishMoves() {
        GameObject fish = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Goldfish"));

        float y1 = fish.transform.position.y;
        float x1 = fish.transform.position.x;
        fish.SendMessage("Move");

        float y2 = fish.transform.position.y;
        float x2 = fish.transform.position.x;

        Assert.AreNotEqual(y1, y2);
        Assert.AreNotEqual(x1, x2);
    }
}
