using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 stepPosition;
    private GameObject player;
    [SerializeField] private float speed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        Physics.gravity = new Vector3(0, -20.0F, 0);
    }

    private void Update()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            StepUp(other);
        }
    }

    private void StepUp(Collider other)
    {
        stepPosition = player.transform.position;
        player.transform.position += new Vector3(0, .1f, 0);
        other.gameObject.transform.position = stepPosition;
        other.GetComponent<CubeController>().enabled = true;
        other.GetComponent<PlayerController>().enabled = true;
        other.tag = "Step";
        other.GetComponent<BoxCollider>().isTrigger = false;
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
