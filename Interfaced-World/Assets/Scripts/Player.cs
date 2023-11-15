using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 10;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // player health
    [SerializeField] private Slider playerHealthBar;
    [SerializeField] private float maxHealth = 100;
    private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        currentHealth = maxHealth;
        if (playerHealthBar == null)
        {
            playerHealthBar = GameObject.Find("HealthBar").GetComponent<Slider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Code for Physics
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    public void ChangeHealth(float amount)
    {
        currentHealth += amount;
        if (currentHealth <= 0)
        {
            PlayerDeath();
        }

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }

        playerHealthBar.value = currentHealth / maxHealth;
        Debug.Log(playerHealthBar.value);
    }

    public void PlayerDeath()
    {
        // Show game over menu
        gameObject.SetActive(false);
        WorldSingleton.main.menuManager.GameOver();
    }

    public void Reset()
    {
        gameObject.SetActive(true);
        gameObject.transform.position = new Vector3(0, 1, 0);
        ChangeHealth(maxHealth);
    }

    public void PausePlayer(bool value)
    {
        rb.isKinematic = value;
    }
}
