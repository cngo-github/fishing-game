using UnityEngine;

public class Octopus : Fish {
    public override float liveliness {
        get { return _liveliness; }
        protected set { }
    }
    public override float xSpeed {
        get { return _xSpeed; }
        protected set { }
    }
    public override float ySpeed {
        get { return _ySpeed; }
        protected set { }
    }
    public override rCatchResult catchResult {
        get { return _catchResult; }
        protected set { }
    }

    private float _liveliness = 0.7f;
    private float _ySpeed = 10f;
    private float _xSpeed = 48f;
    private rCatchResult _catchResult = new rCatchResult {
        isGameOver = false,
        scoreUpdate = new rScoreUpdate { score = 1f, multiplier = 0f },
        message = "You caught an octopus. It's better than nothing."
    };
}