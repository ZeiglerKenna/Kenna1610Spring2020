using UnityEngine;

public class SpriteCostumePowerup : MonoBehaviour
{
  public GameObject purplePowerUp;
  public SpriteRenderer fireSprite;
  public Sprite mushroomFireSprite;

  private void Start()
  {
    fireSprite.GetComponent<SpriteRenderer>();
  }

  void OnTriggerEnter(Collider other)
  {
    if (purplePowerUp)
    {
      fireSprite.sprite = mushroomFireSprite;
      print("Powerup!");
    }
  }
}
