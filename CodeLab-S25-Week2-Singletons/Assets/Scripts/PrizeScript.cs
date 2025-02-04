using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        GameManager.instance.score++;
        
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
    }
}
