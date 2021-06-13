using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTarget : GrabbableObject
{
    [SerializeField]
    private GameObject target;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Food" && target.tag == "RandomTarget")
        {
            // Random Target: Destroy self upon impact + UpdateScore() + SpawnTarget()
            // Singleton pattern
            FoodFight.instance.UpdateScore();
            FoodFight.instance.SpawnTarget();
            Destroy(gameObject);
        }
        else if (collision.collider.tag == "Food" && target.tag == "StationaryTarget") 
        {
            // Stationary Target: UpdateScore()            
            FoodFight.instance.UpdateScore();
        }
    }

}
// add comment for git commit
