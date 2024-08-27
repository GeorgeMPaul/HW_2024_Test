using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //public DestroyAfterRandomTime randTimeDestroy;
    public string tagToSearch = "Respawn";
    public GameObject PulpitPrefab;
    float x_cord = 0;
    float z_cord = 0;
    float y_cord = 0;

    void FixedUpdate()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToSearch);
        int count = objectsWithTag.Length;
        Debug.Log("Number of objects with tag '" + tagToSearch + "': " + count);
        //Debug.Log("Random Time: "+randTimeDestroy.randomTime);
        if (count<2)
        {
            SpawnNewPulpit();
            //Debug.Log("Random Time: " + randTimeDestroy.randomTime);
        }    
    }

    void SpawnNewPulpit()
    {
        Instantiate(PulpitPrefab, new Vector3(x_cord, y_cord, z_cord), Quaternion.identity);
        var randomSpawnPosition = Random.Range(0, 3);
        switch (randomSpawnPosition)
        {
            case 0:
                z_cord += 9;
                break;
            case 1:
                x_cord += 9;
                break;
            case 2:
                z_cord -= 9;
                break;
            case 3:
                x_cord -= 9;
                break;
            default:
                break;
        }
    }
}
