using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public Image healthBar;
    public GameObject player;

    private void Start()
    {
        healthBar = GetComponent<Image>();
    }
}