﻿namespace Character.Animation.AnimationStates
{
    public class AnimationTrigger : IAnimationTrigger
    {
        private string _triggerName;

        public AnimationTrigger(string triggerName)
        {
            _triggerName = triggerName;
        }

        public string TriggerName => _triggerName;
    }
}