﻿namespace MoleMole.Config
{
    using MoleMole;
    using System;

    [GeneratePartialHash(CombineGeneratedFile=true)]
    public class AttachIsGhost : ConfigAbilityAction, IHashable
    {
        public bool IsGhost;

        public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseAbilityActor target, BaseEvent evt)
        {
            abilityPlugin.AttachDisableHitboxHandler(actionConfig, instancedAbility, instancedModifier, target, evt);
        }

        public void ObjectContentHashOnto(ref int lastHash)
        {
            HashUtils.ContentHashOnto(this.IsGhost, ref lastHash);
            HashUtils.ContentHashOnto((int) base.Target, ref lastHash);
            if ((base.TargetOption != null) && (base.TargetOption.Range != null))
            {
                HashUtils.ContentHashOnto(base.TargetOption.Range.isDynamic, ref lastHash);
                HashUtils.ContentHashOnto(base.TargetOption.Range.fixedValue, ref lastHash);
                HashUtils.ContentHashOnto(base.TargetOption.Range.dynamicKey, ref lastHash);
            }
            if (base.Predicates != null)
            {
                foreach (ConfigAbilityPredicate predicate in base.Predicates)
                {
                    if (predicate is IHashable)
                    {
                        HashUtils.ContentHashOnto((IHashable) predicate, ref lastHash);
                    }
                }
            }
        }
    }
}

