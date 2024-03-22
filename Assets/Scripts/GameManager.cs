using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Square;
    public GameObject EndPanel;
    public Text TimeText;
    public Text NowScore;


    float _time = 0.0f;
    bool _isPlay = true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        Time.timeScale = 1f;
        InvokeRepeating("MakeSquare", 0f, 1.0f);
    }

    void Update()
    {
        if (_isPlay)
        {
            _time += Time.deltaTime;
            TimeText.text = _time.ToString("N2");
        }
    }

    void MakeSquare()
    {
        Instantiate(Square);
    }

    public void GameOver()
    {
        _isPlay = false;
        Time.timeScale = 0f;
        NowScore.text = _time.ToString("N2");
        EndPanel.SetActive(true);
    }
}
