using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATypicalSpawn : MonoBehaviour
{
    [SerializeField] private GameObject mainObject;
    [SerializeField] private GameObject effect;
    [SerializeField] private float effectTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        mainObject.SetActive(true);
        effect.SetActive(false);

        StartCoroutine(FirstWait());

    }

    IEnumerator FirstWait()
    {
        //simulate destroy object
        yield return new WaitForSeconds(3);

        mainObject.SetActive(false);
        effect.SetActive(true);

        StartCoroutine(EffectWait());
    }

    IEnumerator EffectWait()
    {
        yield return new WaitForSeconds(effectTime);

        Destroy(gameObject);

    }
}
