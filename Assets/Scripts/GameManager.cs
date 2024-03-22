using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Square;
    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 1.0f);
    }

    void Update()
    {

    }

    void MakeSquare()
    {
        Instantiate(Square);
    }
}
