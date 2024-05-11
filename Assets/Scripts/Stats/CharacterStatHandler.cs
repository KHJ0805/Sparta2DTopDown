using UnityEngine;
using System;
using System.Collections.Generic;

public class CharacterStatHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStat;

    public CharacterStat CurrentStat { get; private set; }

    public List<CharacterStat> statModifiers = new List<CharacterStat>();

    private void Awake()
    {
        UpdateCharacterStat();
    }

    private void UpdateCharacterStat()
    {
        AttackS0 attackS0 = null;
        if(baseStat.attackS0 != null)
        {
            attackS0 = baseStat.attackS0;
        }

        CurrentStat = new CharacterStat { attackS0 = attackS0 };
        CurrentStat.statsChangeType = baseStat.statsChangeType;
        CurrentStat.maxHealth = baseStat.maxHealth;
        CurrentStat.speed = baseStat.speed;
    }
}