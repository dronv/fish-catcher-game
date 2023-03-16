using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDestroy : MonoBehaviour
{
    public float life_timer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life_timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
