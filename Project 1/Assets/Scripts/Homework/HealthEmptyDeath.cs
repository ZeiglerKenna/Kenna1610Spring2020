using UnityEngine;
using UnityEngine.UI;

public class HealthEmptyDeath : MonoBehaviour
{
    public Image healthBar;
    public GameManager gameManager;
    
    private void Start()
    {
        GetComponent<Image>();
        if (healthBar.fillAmount <= 0)
        {
            Debug.Log("Game Over");
            gameManager.EndGame();
        }
    }
}