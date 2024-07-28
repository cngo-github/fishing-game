using UnityEngine;

public class Tuna : Fish {
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


    private float _liveliness = 0.4f;
    private float _ySpeed = 6f;
    private float _xSpeed = 57f;
    private rCatchResult _catchResult = new rCatchResult {
        isGameOver = false,
        scoreUpdate = new rScoreUpdate { score = 5f, multiplier = 0f },
        message = "Chaching! You caught a Bluefin tuna!"
    };
}