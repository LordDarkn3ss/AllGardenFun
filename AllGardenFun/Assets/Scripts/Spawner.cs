using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float a1,a2,a3,timer;
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SPAWNAR(timer,a1,a2,a3));
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
    }

    IEnumerator SPAWNAR(float waitTime,float x,float z,float y)
    {
        while(true)
        {
        yield return new WaitForSeconds(waitTime);
        x = Random.Range(4f, -4f);
        y = Random.Range(4f, -4f);
        Instantiate(box, new Vector3(x,z,y), Quaternion.identity);
        }
    }
}
