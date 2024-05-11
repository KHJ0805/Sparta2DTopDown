using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override
}


// 데이터 폴더 처럼 만들어주는 어트리뷰트
[System.Serializable]

public class CharacterStat
{
    public StatsChangeType statsChangeType;
    [Range(1, 100)] public int maxHealth;
    [Range(1f, 20f)] public float speed;
    public AttackS0 attackS0;

}
