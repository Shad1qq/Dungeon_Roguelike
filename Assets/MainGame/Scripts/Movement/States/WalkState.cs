using MainGame.Scripts.FSM;
using UnityEngine;

namespace Assets.MainGame.Scripts.Movement.States
{
    public class WalkState : MovementBase
    {
        public WalkState(FSM fsm, float speed, InputSystem inputSystem, Rigidbody rb, float jumpForce) 
            : base(fsm, speed, inputSystem, rb)
        {
            
        }
        public override void Enter()
        {
            Debug.Log("Enter [WALK]");
            _inputSystem.Player.Jump.performed += Jump;
        }
        public override void Update()
        {
            Move();
            if (!_inputSystem.Player.Move.IsPressed()) 
            {
                _fsm.SetState<IdleState>();
            }
            
        }
         
        public override void Exit() 
        {
            Debug.Log("Exit [WALK]");
            _inputSystem.Player.Jump.performed -= Jump;
        }
    }
}
