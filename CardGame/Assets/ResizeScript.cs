using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeScript : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
    }
}
