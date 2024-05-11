using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TopDownShooting : MonoBehaviour
{
    private TopDownController controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 aimDirection = Vector2.right;

    public GameObject TestPrefab;
    
    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnAttackEvent += OnShoot;
        controller.OnLookEvent += OnAim;
    }

    private void OnShoot(AttackS0 attackS0)
    {
        RangedAttackS0 rangedAttackS0 = attackS0 as RangedAttackS0;
        if (rangedAttackS0 == null) return;

        float projectilesAngleSpace = rangedAttackS0.MultipleProjectilesAngle;
        int numberOfProjectilesPerShot = rangedAttackS0.numberOfProjectilesPerShot;

        float minAngle = -(numberOfProjectilesPerShot / 2f) * projectilesAngleSpace + 0.5f * rangedAttackS0.MultipleProjectilesAngle;
        for (int i = 0; i < numberOfProjectilesPerShot; i++)
        {
            float angle = minAngle + i * projectilesAngleSpace;
            float randomSpread = Random.Range(-rangedAttackS0.spread , rangedAttackS0.spread);
            angle += randomSpread;
            CreateProjectile(rangedAttackS0, angle);
        }
    }

    private void CreateProjectile(RangedAttackS0 rangedAttackS0, float angle)
    {
        GameObject obj = Instantiate(TestPrefab);
        obj.transform.position = projectileSpawnPosition.position;
        ProjectileController attackController = obj.GetComponent<ProjectileController>();
        attackController.InitializeAttack(RotateVector2(aimDirection, angle), rangedAttackS0);
    }

    private void OnAim(Vector2 direction)
    {
        aimDirection = direction;
    }

    private static Vector2 RotateVector2(Vector2 v, float angle)
    {
        return Quaternion.Euler(0f, 0f, angle) * v;
            
    }
}

