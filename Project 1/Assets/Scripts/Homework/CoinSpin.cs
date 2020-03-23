using UnityEngine;

public class CoinSpin : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(2, 0, 0 * Time.deltaTime);
    }
}
