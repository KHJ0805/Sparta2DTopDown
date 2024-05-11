using UnityEngine;

[CreateAssetMenu(fileName = "RangedAttackS0", menuName = "TopDownController/Attacks/Ranged", order = 1)]
public class RangedAttackS0 : AttackS0
{
    [Header("Ranged Attack Info")]
    public string bulletNameTag;
    public float duration;
    public float spread;
    public int numberOfProjectilesPerShot;
    public float MultipleProjectilesAngle;
    public Color projectileColor;

}