using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject gamePanel;

    void ShowPanel(GameObject panel)
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(false);
        panel.SetActive(true);
    }

    public void OnClickStartButton()
    {
        ShowPanel(gamePanel);
        GameplayManager.instance.StartSpawningTargets();
    }
}
