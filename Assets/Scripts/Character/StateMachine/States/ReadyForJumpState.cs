﻿using Common;

namespace Character.StateMachine.States
{
    public class ReadyForJumpState : ICharacterState, IPointerDown
    {
        public const string ClassName = "ReadyForJumpState";
        
        private readonly IStateMachineEnter _stateMachine;
        private readonly CharacterController _controller;

        public ReadyForJumpState(IStateMachineEnter stateMachine, CharacterController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public void OnEnter()
        { }

        public void OnPointerDown()
        {
            _stateMachine.Enter(JumpState.ClassName);
        }

        public override string ToString() => 
            ClassName;
    }
}