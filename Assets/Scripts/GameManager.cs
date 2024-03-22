using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Square;
    public Text TimeText;

    float _time = 0.0f;

    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1.0f);
    }

    void Update()
    {
        _time += Time.deltaTime;
        TimeText.text = _time.ToString("N2");
    }

    void MakeSquare()
    {
        Instantiate(Square);
    }
}
