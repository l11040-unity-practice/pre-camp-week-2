using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    void Start()
    {
        float poX = Random.Range(-2.4f, 2.4f);
        float poY = Random.Range(3.0f, 4.5f);
        this.transform.position = new Vector2(poX, poY);

        float size = Random.Range(0.5f, 1.5f);
        this.transform.localScale = new Vector2(size, size);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
