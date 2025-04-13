using Assets.MainGame.Scripts.Movement.States;
using MainGame.Scripts.FSM;
using UnityEngine;

public class RunState : MovementBase
{
    public RunState(FSM fsm, float runspeed, InputSystem inputSystem, Rigidbody rb) : base(fsm, runspeed, inputSystem, rb)
    {
    }
    public override void Update()
    {
        Move();
        if (!_inputSystem.Player.Sprint.IsPressed())
        {
            _fsm.SetState<WalkState>();
        }
    }
}
