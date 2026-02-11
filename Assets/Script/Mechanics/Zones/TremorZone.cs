using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;


public class TremorZone : Zone
{
    private CinemachineImpulseSource source;

    private void Awake()
    {
        source = GetComponent<CinemachineImpulseSource>();
    }
    protected override void ApplyZoneEffect(Player player)
    {
        InvokeRepeating("Shake", 3f, 4f);
    }
    public void Shake()
    {
        source.GenerateImpulse();
    }
}
