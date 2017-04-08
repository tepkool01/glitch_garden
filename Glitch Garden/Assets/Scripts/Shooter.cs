using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, gun;
    private GameObject projectileParent;
    private Animator animator;
    private Spawner myLaneSpawner;

    void Start()
    {
        //animator = GameObject.FindObjectOfType<Animator>(); // this would search the whole scene 4:00
        animator = this.GetComponent<Animator>();

        // Creates a parent if necessary
        projectileParent = GameObject.Find("Projectiles");
        if (projectileParent == null)
        {
            projectileParent = new GameObject("Projectiles");

        }

        SetMyLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerAheadInLane())
        {
            animator.SetBool("isAttacking", true);
        } else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    void SetMyLaneSpawner()
    {
        Spawner[] allLanes = GameObject.FindObjectsOfType<Spawner>();

        foreach (Spawner lane in allLanes)
        {
            if (lane.transform.position.y == this.transform.position.y)
            {
                myLaneSpawner = lane;
                return;
            }
        }

        Debug.LogError(name + " can't find spawner in lane");
    }

    bool IsAttackerAheadInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }

        foreach (Transform attacker in myLaneSpawner.transform)
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        // Attackers in lane, but behind us
        return false;
    }

    private void Fire()
    {
        GameObject newProjectile = Instantiate (projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
