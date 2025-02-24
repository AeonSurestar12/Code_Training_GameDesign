//Updated to only move while in Playing game state
private void FixedUpdate()
{
    //REPLACE _rigidbody.velocity = _direction * 2; with:
    if (GameManager.Instance.State == GameState.Playing)
    {
        _rigidbody.velocity = _direction * 2;
    }
    else
    {
        _rigidbody.velocity = Vector2.zero;
    }
}
