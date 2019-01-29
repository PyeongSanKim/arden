using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseUI : MonoBehaviour
{
    public void Rise(int num, float height)
    {
        StartCoroutine(CoRise(num, height));
    }
    IEnumerator CoRise(int num, float height)
    {
        yield return null;
        for(int i=0; i< num; i++)
        {
            yield return new WaitForSeconds(0.02f);
            gameObject.transform.position += new Vector3(0, height, 0);
        }
    }
}
