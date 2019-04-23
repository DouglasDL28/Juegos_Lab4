using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    Gun player;
    public float health = 30f;

    private void Start()
    {
        player = GameObject.Find("Gun").GetComponent<Gun>();
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            player.enemyCount++;
            player.CountUpdate();
            Debug.Log(player.enemyCount);
            Destroy(this.gameObject);
        }
    }

  
}
