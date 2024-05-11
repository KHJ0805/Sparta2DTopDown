using UnityEngine;
[CreateAssetMenu(fileName = "DefaultAttackS0", menuName = "TopDownController/Attacks/Default", order = 0)] 

public class AttackS0 : ScriptableObject
{
    [Header("Attack Info")]
    public float size;
    public float delay;
    public float power;
    public float speed;
    public LayerMask target;

    [Header("Knock_Back_Info")]
    public bool isOnKnockBack;
    public float KnockBackPower;
    public float KnockBackTime;

}
