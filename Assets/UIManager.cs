using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreUI;
    [SerializeField] private GameObject startMenuUI;
    [SerializeField] private GameObject gameOverUI;

    GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameManager.Instance;
        gm.onGameOver.AddListener(ActivateGameOverUI);
    }

    public void PlayButtonHandler() {
        gm.StartGame();
    }

    public void ActivateGameOverUI() {
        gameOverUI.SetActive(true);
    }

    public void OnGUI()
    {
        scoreUI.text = gm.PrettyScore();
    }
}
