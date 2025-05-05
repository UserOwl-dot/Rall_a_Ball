using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI countTextMenuLose;
    private int count;
    private float sizeX = 1;
    private float sizeY = 1;
    private float sizeZ = 1;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public GameObject panelWin;
    public GameObject panelLose;
    public GameObject pause;


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            sizeX += 0.15f; sizeY += 0.15f; sizeZ += 0.15f;
            transform.localScale = new Vector3(sizeX, sizeY, sizeZ);
            SetCountText();
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 18)
        {
            pause.SetActive(false);
            countText.SetText("");
            panelWin.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            pause.SetActive(false);
            // Destroy the current object
            Destroy(gameObject);
            countText.SetText("");
            // Update the winText to display "You Lose!"
            loseTextObject.gameObject.SetActive(true);
            loseTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            countTextMenuLose.text = "Вы набрали: " + count.ToString() + " очков";
            panelLose.SetActive(true);
        }
    }
}
