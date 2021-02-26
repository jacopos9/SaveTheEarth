using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public GameObject shot;


    public void Shoot()
    {
        Instantiate(shot, transform.position, transform.rotation);
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(h, 0, 0) * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0)) Shoot();
    }

}
