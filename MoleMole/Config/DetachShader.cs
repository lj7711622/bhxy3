﻿namespace MoleMole.Config
{
    using MoleMole;
    using System;

    [GeneratePartialHash(CombineGeneratedFile=true)]
    public class DetachShader : ConfigAbilityAction, IHashable
    {
        public float Duration;
        public E_ShaderData ShaderType;
        public bool UsePrefabDisableDurtion;

        public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseAbilityActor target, BaseEvent evt)
        {
            abilityPlugin.DetachShaderHandler(actionConfig, instancedAbility, instancedModifier, target, evt);
        }

        public void ObjectContentHashOnto(ref int lastHash)
        {
            HashUtils.ContentHashOnto((int) this.ShaderType, ref lastHash);
            HashUtils.ContentHashOnto(this.UsePrefabDisableDurtion, ref lastHash);
            HashUtils.ContentHashOnto(this.Duration, ref lastHash);
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

