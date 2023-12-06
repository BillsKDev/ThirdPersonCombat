
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    float _timer;

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        _stateMachine.InputReader.JumpEvent += OnJump;
    }

    public override void Tick(float deltaTime)
    {
        _timer += deltaTime;
        Debug.Log(_timer);
    }

    public override void Exit()
    {
        _stateMachine.InputReader.JumpEvent -= OnJump;
    }

    void OnJump()
    {
        _stateMachine.SwitchState(new PlayerTestState(_stateMachine));
    }
}
