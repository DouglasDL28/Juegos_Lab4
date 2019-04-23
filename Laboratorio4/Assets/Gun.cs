using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public int enemyCount = 0;
    public Text countText;
    public Camera fpsCam;

    private void Start()
    {
        countText = GameObject.Find("Count").GetComponent<Text>();
        CountUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

    public void CountUpdate()
    {
        countText.text = "Kill Count: " + enemyCount.ToString();
    }
}
