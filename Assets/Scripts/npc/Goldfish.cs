using UnityEngine;

public class Goldfish : Fish {
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

    private float _liveliness = 0.5f;
    private float _ySpeed = 8f;
    private float _xSpeed = 65f;
    private rCatchResult _catchResult = new rCatchResult {
        isGameOver = false,
        scoreUpdate = new rScoreUpdate { score = 0f, multiplier = 0.1f },
        message = "You caught a goldfish! You can feel yourself getting luckier!"
    };
}