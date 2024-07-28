using UnityEngine;

public class Shark : Fish {
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
    public override string species {
        get { return _species; }
        protected set { }
    }
    public override rCatchResult catchResult {
        get { return _catchResult; }
        protected set { }
    }

    private float _liveliness = 0.1f;
    private float _ySpeed = 8f;
    private float _xSpeed = 90f;
    private string _species = "Shark";
    private rCatchResult _catchResult = new rCatchResult {
        isGameOver = true,
        scoreUpdate = Scoreboard.emptyUpdate(),
        message = "Yikes! You caught a shark! That's enough fishing for today!"
    };
}