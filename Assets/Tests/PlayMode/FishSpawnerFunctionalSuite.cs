using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FishSpawnerFunctionalSuite
{
    [Test]
    public void FishSpawns() {
        GameObject fish = MonoBehaviour.Instantiate(Resources.Load<GameObject>("FishSpawner"));

        GameObject[] o1 = MonoBehaviour.FindObjectsOfType<GameObject>();
        fish.SendMessage("SpawnFish");

        GameObject[] o2 = MonoBehaviour.FindObjectsOfType<GameObject>();
        Assert.AreNotEqual(o1.Length, o2.Length);
    }
}
