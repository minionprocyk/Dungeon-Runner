using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float xRotationSpeed = 2.0f;
    [SerializeField]
    private float yRotationSpeed = 0.1f;
    [SerializeField]
    private float maxHeadRotation = 35.0f;
    [SerializeField]
    private float minHeadRotation = -30.0f;
    [SerializeField]
    private float jumpSpeed = 15f;
    [SerializeField]
    private float gravity = 30.0f;
        
    private float currentHeadRotation = 0;
    private float yVelocity = 0;
    private bool canJump = true;
    private CharacterController controller;
    private Vector3 moveVelocity = Vector3.zero;

    public Transform head;
    // Use this for initialization
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
       // Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        if (controller.isGrounded)
        {
            moveVelocity = transform.TransformDirection(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed);
        }
        else
        {
            //Lesser Air control
            //This is not right, currently gaining massive movement control
            moveVelocity = moveVelocity * 0.9f + transform.TransformDirection(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * 0.1f);
        }
        Vector3 velocity = moveVelocity + yVelocity * Vector3.up;
        controller.Move(velocity * Time.deltaTime);

        transform.Rotate(Vector3.up, mouseInput.x * xRotationSpeed);
        
        currentHeadRotation = Mathf.Clamp(currentHeadRotation + mouseInput.y * yRotationSpeed, minHeadRotation, maxHeadRotation);
        head.localRotation = Quaternion.identity;
        
        head.Rotate(Vector3.left, currentHeadRotation);

        if (Input.GetButtonDown("Jump") && canJump)
        {
            yVelocity = jumpSpeed;
            canJump = false;
        }
        else if (controller.isGrounded)
        {
            yVelocity = 0;
            canJump = true;
        }
        else
        {
            yVelocity -= gravity * Time.deltaTime;

        }
    }

    private void LateUpdate()
    {

    }
}
