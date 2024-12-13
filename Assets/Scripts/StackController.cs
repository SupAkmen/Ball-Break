using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [SerializeField]
    private StackPartController[] stackPartController = null;

    public int PartCount => stackPartController.Length;

    public void ShatterAllParts()
    {
        if(transform.parent != null)
        {
            transform.parent = null;
            FindObjectOfType<Ball>().IncreaseBrokenStacks();
        }

        foreach(StackPartController o in stackPartController)
        {
            o.Shatter();
        }
        StartCoroutine(RemoveParts());
    }

    IEnumerator RemoveParts()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
