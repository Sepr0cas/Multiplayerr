using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : NetworkBehaviour
{
    [Networked, OnChangedRender(nameof(HealthChanged))]
    public float NetworkedHealth { get; set; } = 100;

    void HealthChanged()
    {
        Debug.Log("Health changed to Networked version");
    }

    [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
    public void DealDamageRpc(float damage)
    {
        Debug.Log($"Health minus {damage} is {NetworkedHealth}");
        NetworkedHealth -= damage;
    }
}
