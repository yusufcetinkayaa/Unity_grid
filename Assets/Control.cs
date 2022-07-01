using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]private int count = 0;
    [SerializeField] private SpriteRenderer _tile;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Control")
        {
            count += 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Control")
        {
            count -= 1;
        }
    }
    private void Update()
    {
        if (count >= 2)
        {
            _tile.color = Color.white;
            this.gameObject.SetActive(false);
        }
    }
}
