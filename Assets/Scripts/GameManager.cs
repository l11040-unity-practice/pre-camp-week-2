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
    public Text BestScore;
    public Animator Anime;

    string _bestScoreKey = "bestScore";
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
        Anime.SetBool("isDie", true);

        Invoke("TimeStop", 0.5f);
        NowScore.text = _time.ToString("N2");
        SetBestScore(_time);
        EndPanel.SetActive(true);
    }

    void SetBestScore(float score)
    {
        if (PlayerPrefs.HasKey(_bestScoreKey))
        {
            float best = PlayerPrefs.GetFloat(_bestScoreKey);
            if (best < score)
            {
                PlayerPrefs.SetFloat(_bestScoreKey, score);
                BestScore.text = score.ToString("N2");
            }
            else
            {
                BestScore.text = best.ToString("N2");
            }
        }
        else
        {
            PlayerPrefs.SetFloat(_bestScoreKey, score);
            BestScore.text = score.ToString("N2");
        }
    }

    void TimeStop()
    {
        Time.timeScale = 0f;
    }
}
