using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScreen : MonoBehaviour
{
    public GameObject FinishScreenPanel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI LiveScore;
    public Transform Player;
    public float Radius = 3f;
    public int MarkedEnemies = 0;
    private bool _finished = false;
    
    void Update()
    {
        if (_finished) return;
        
        float distance = (transform.position - Player.position).magnitude;

        if (distance <= Radius)
        {
            _finished = true;
            print("Finished!!!");
            ScoreLabel.text = $"You marked {MarkedEnemies} out of 2 enemies";
            FinishScreenPanel.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
