public class Scoreboard {
    public static rScoreUpdate emptyUpdate() {
        return new rScoreUpdate { score = 0f, multiplier = 0f };
    }

    public float score {
        get { return _score; }
        protected set { }
    }
    public float multiplier {
        get { return _multiplier; }
        protected set { }
    }

    private float _score = 0;
    private float _multiplier = 1;

    public void Reset() {
        _score = 0;
        _multiplier = 1;
    }

    public void Update(rScoreUpdate update) {
        _score += update.score * _multiplier;
        _multiplier += update.multiplier;
    }
}