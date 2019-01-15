using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearNext : MonoBehaviour
{
    public GameObject Guide;

    private void Start()
    {
        StartCoroutine(CN());
    }

    IEnumerator CN()
    {
        yield return new WaitForSeconds(3f);
        Guide.SetActive(true);
    }
}
