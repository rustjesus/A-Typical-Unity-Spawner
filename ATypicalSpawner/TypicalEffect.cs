using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypicalEffect : MonoBehaviour
{
    [SerializeField] private float effectTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //destroy object
        yield return new WaitForSeconds(effectTime);
        Destroy(gameObject);

    }
}
