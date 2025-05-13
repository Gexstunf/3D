using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intantiator : MonoBehaviour
{
    public GameObject cuboPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Spawn()
    {
        Instantiate(cuboPrefab);
    }
}
