using MainGame.Scripts.FSM;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.MainGame.Scripts.Movement.States
{
    public abstract class MovementBase : FSMState
    {
        protected Rigidbody _rb;
        protected float _speed;
        protected InputSystem _inputSystem;
        protected float _jumpForce;

        #region Constructors
        public MovementBase(FSM fsm, float speed, InputSystem inputSystem, Rigidbody rb) : base(fsm)
        {
            _speed = speed;
            _inputSystem = inputSystem;
            _rb = rb;
        }
        public MovementBase(FSM fsm, InputSystem inputSystem, Rigidbody rb) : base(fsm)
        {
            _inputSystem = inputSystem;
            _rb = rb;
        }
        public MovementBase(FSM fsm, InputSystem inputSystem, Rigidbody rb, float jumpForce) : base(fsm)
        {
            _inputSystem = inputSystem;
            _rb = rb;
            _jumpForce = jumpForce;
        }

        #endregion
        protected void Move()
        {
            Vector3 direction = _inputSystem.Player.Move.ReadValue<Vector3>();
            _rb.linearVelocity = new Vector3(direction.x * _speed, _rb.linearVelocity.y, direction.z * _speed);
        }
        protected void Jump(InputAction.CallbackContext obj)
        {
            _rb.AddForce(Vector3.up*_jumpForce, ForceMode.Impulse);
            _fsm.SetState<AirState>();
        }

    }
}
