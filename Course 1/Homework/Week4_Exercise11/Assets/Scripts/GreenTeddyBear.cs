using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.y *= 4;
        transform.localScale = newScale;
    }
}
