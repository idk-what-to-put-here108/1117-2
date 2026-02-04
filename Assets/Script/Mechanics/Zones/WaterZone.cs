using Unity.VisualScripting;
using UnityEngine;

public class WaterZone : Zone
{
    [Range(0f, 1f)]
    [SerializeField] private float speedModifier = 0.5f;
    // reduce player speed by 50%
    protected override void ApplyZoneEffect(Player player)
    {
        // check my player speed modifier value
        player.ApplySpeedModifier(speedModifier);
    }
}
