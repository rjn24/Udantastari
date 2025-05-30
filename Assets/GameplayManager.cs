using UnityEngine;
using UnityEngine.UI; 
public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;
    [SerializeField] GameObject targetPrefab;
    [SerializeField] GameObject winPanel;
    [SerializeField] Text scoreText;
    [SerializeField] int maxTargets = 30;

    private int count = 0;
    private int score = 0;
    private bool hasWon = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        winPanel.SetActive(false);
    }

    public void StartSpawningTargets()
    {
        if (!hasWon) InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    void Update()
    {
        if (hasWon) CancelInvoke("SpawnTarget");
    }

    void SpawnTarget()
    {
        if (count >= maxTargets) return;
        count++;
        float xpos = Random.Range(-7.5f, 7.5f);
        float ypos = Random.Range(-4f, 4f);
        Vector3 randomtargetPos = new Vector3(xpos, ypos, 0);
        Instantiate(targetPrefab, randomtargetPos, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score : " + score;
        if (score >= maxTargets)
        {
            winPanel.SetActive(true);
            hasWon = true;
        }
    }
}
