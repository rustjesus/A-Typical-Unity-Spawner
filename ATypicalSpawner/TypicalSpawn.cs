using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypicalSpawn : MonoBehaviour
{
    [SerializeField] private GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //destroy object
        yield return new WaitForSeconds(3);
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
