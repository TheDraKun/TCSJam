using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] gameobjs;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawn()
    {
        int randomIndex = Random.Range(0, gameobjs.Length);

        GameObject instantiatedObject = Instantiate(gameobjs[randomIndex], transform.position, Quaternion.identity) as GameObject;
    }
}
