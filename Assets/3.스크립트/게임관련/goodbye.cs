using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodbye : MonoBehaviour
{
    public GameObject GB;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(a());
    }
    public IEnumerator a()
    {
        for(int i=0;i<100;i++)
        {
            gameObject.transform.Translate(0.004f, 0, 0);
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1.5f);
        GB.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        GameMgr.StarNum = 1;
    }
}
