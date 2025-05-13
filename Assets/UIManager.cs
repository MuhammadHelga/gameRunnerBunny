using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private TextMeshProUGUI lastScore;
    [SerializeField] private GameObject gameOverUI;

    GameManager gm;
    void Start()
    {
        gm = GameManager.Instance;
        gm.onGameOver.AddListener(ActivateGameOverUI);
    }

    public void PlayButtonHandler()
    {
        gm.StartGame();
    }

    public void ActivateGameOverUI()
    {
        gameOverUI.SetActive(true);
        lastScore.text = "Final Score : " + gm.PrettyScore();
    }

    public void OnGUI()
    {
        scoreUI.text = gm.PrettyScore();
    }
}
