using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Square;
    public Text TimeText;

    float time = 0.0f;

    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1.0f);
    }

    void Update()
    {
        time += Time.deltaTime;
        TimeText.text = time.ToString("N2");
    }

    void MakeSquare()
    {
        Instantiate(Square);
    }
}
