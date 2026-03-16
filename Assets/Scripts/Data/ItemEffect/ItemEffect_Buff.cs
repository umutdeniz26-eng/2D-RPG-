using System;

using UnityEngine;

public class ItemEffect_Buff : ItemEffect_DataSO
{

    [SerializeField] private BuffEffectData[] buffsToApply;
    [SerializeField] private float duration;
    [SerializeField] private string source=Guid.NewGuid().ToString();

    public override void ExecuteEffect()
    {
        base.ExecuteEffect();
    }
}
