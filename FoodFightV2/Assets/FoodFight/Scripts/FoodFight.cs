using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodFight : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreDisplay;

    private int score = 0;

    [SerializeField]
    private GameObject prefabTarget;
    [SerializeField]
    private Vector3 minSpawnArea;
    [SerializeField]
    private Vector3 maxSpawnArea;

    // Singleton Pattern - the FoodFight script references this instance
    // because there's only one instance. And because this variable is 
    // public/static we can access it from the FoodTarget script, which
    // in turn allows us to access the UpdateScore() method
    public static FoodFight instance;

    

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        Instantiate(prefabTarget, GetRandomTargetPos(), Quaternion.identity);

        // StartCoroutine(SpawningFood());
    }

    public void UpdateScore()
    {
        score++;

        scoreDisplay.text = "Score: " + score;
    }

    public void SpawnTarget()
    {
        Instantiate(prefabTarget, GetRandomTargetPos(), Quaternion.identity);
    }

    private Vector3 GetRandomTargetPos()
    {
        float x = Random.Range(minSpawnArea.x, maxSpawnArea.x);
        float y = Random.Range(minSpawnArea.y, maxSpawnArea.y);
        float z = Random.Range(minSpawnArea.z, maxSpawnArea.z);

        return new Vector3(x, y, z);
    }

    //IEnumerator SpawningFood()
    //{
    //    while(true)
    //    {
    //        // Instantiate

    //        yield return new WaitForSeconds(3);
    //    }
    //}
}
