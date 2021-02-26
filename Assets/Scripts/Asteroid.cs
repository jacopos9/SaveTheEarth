using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = 5f;

    private void Start()
    {
       
    }
    void Movement()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Earth")
        {
            Time.timeScale = 0;
        }
    }

    private void Update()
    {
        Movement();
    }

}
