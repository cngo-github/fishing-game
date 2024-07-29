using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerFunctionalSuite
{
    [Test]
    public void PlayerMovesUp() {
        GameObject player = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Player"));

        float y1 = player.transform.position.y;
        player.SendMessage("MoveUp");

        float y2 = player.transform.position.y;
        Assert.AreNotEqual(y1, y2);
    }

    [Test]
    public void PlayerDropsDown() {
        GameObject player = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Player"));

        float y1 = player.transform.position.y;
        player.SendMessage("DropDown");

        float y2 = player.transform.position.y;
        Assert.AreNotEqual(y1, y2);
    }
}
