using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public bool hasTheKey = false;

    [HideInInspector]
    public Chest currentChestToOpen;

    [SerializeField]
    private float speed = 5F;

    private float hVal;
    private float vVal;

    private Rigidbody2D myRigidbody;

    public void Launch()
    {
        myRigidbody.AddForce(Vector2.up * -10F, ForceMode2D.Impulse);
    }

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Handles horizontal movement
        hVal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * hVal * Time.deltaTime);

        //Handles vertical movement
        vVal = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * vVal * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && currentChestToOpen != null)
        {
            currentChestToOpen.Open();
            currentChestToOpen = null;
        }
    }
}