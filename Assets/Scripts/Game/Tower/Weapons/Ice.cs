using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : FollowingProjectiles
{
    protected override void OnHitEnemy()
    {
        enemyToFollow.Freeze();
        Destroy(gameObject);
    }
}
