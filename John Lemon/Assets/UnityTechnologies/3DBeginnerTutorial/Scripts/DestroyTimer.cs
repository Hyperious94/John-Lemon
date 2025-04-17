using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float destructionTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, destructionTime);
    }
}
