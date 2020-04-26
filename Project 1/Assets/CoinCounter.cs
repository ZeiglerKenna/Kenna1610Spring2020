using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public IntData coins;
    public Text coinCounter;

    private void Update()
    {
        coinCounter.text = coins.value.ToString();
    }
}
