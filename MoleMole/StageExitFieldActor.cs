﻿namespace MoleMole
{
    using System;

    public class StageExitFieldActor : TriggerFieldActor
    {
        protected MonoTriggerField _triggerField;

        public override void Init(BaseMonoEntity entity)
        {
            this._triggerField = (MonoTriggerField) entity;
            base.runtimeID = this._triggerField.GetRuntimeID();
            Singleton<EventManager>.Instance.FireEvent(new EvtStageTriggerCreated(base.runtimeID), MPEventDispatchMode.Normal);
        }

        public override void Kill()
        {
            this._triggerField.SetDied();
            base.Kill();
        }

        public override bool OnFieldEnter(EvtFieldEnter evt)
        {
            base.OnFieldEnter(evt);
            if (Singleton<AvatarManager>.Instance.IsLocalAvatar(evt.otherID))
            {
                this.Kill();
            }
            return true;
        }
    }
}

