using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Default Destuction Time")]
    public float timeToDestruction;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", timeToDestruction);
    }

    // Update is called once per frame
    void DestroyMe()
    {
        Destroy (gameObject);
    }
}

