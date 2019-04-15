using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject MyCat;
    public static int buf = 0;

    public void Spawn(Vector3 position)
    {
        buf++;
        Instantiate(MyCat).transform.position = position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
           
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, MyCat.transform.position.z);
            if(buf<7)
            Spawn(adjustZ);
        }
    }
}
