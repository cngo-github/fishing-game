using UnityEngine;

public class Zombie : Fish {
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

    private float _liveliness = 0.1f;
    private float _ySpeed = 1f;
    private float _xSpeed = 46f;
    private rCatchResult _catchResult = new rCatchResult {
        isGameOver = false,
        scoreUpdate = new rScoreUpdate { score = -10f, multiplier = -0.3f },
        message = "Ick! You caught a zombie fish!"
    };
}