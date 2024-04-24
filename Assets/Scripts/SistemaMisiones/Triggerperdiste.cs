using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerperdiste : MonoBehaviour
{
    public GameObject cancelarmision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cancelarmision.SetActive(true);
        }
    }

}
