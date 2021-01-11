using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object_Script : MonoBehaviour
{
    public GameObject RedText;
    public GameObject YellowText;
    public GameObject OrangeText;
    public GameObject PurpleText;

    private int yellowCounter;
    private int redCounter;
    private int orangeCounter;
    private int purpleCounter;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Red"))
        {
            if (collision.collider.gameObject.CompareTag("Player"))
            {
                redCounter++;

                RedText.GetComponent<Text>().text = "Red: " + redCounter;
                audioSource.Play();
            }
        }

        if (gameObject.CompareTag("Yellow"))
        {
            if (collision.collider.gameObject.CompareTag("Player"))
            {
                yellowCounter++;

                YellowText.GetComponent<Text>().text = "Yellow: " + yellowCounter;
                audioSource.Play();
            }
        }

        if (gameObject.CompareTag("Orange"))
        {
            if (collision.collider.gameObject.CompareTag("Player"))
            {
                orangeCounter++;

                OrangeText.GetComponent<Text>().text = "Orange: " + orangeCounter;
                audioSource.Play();
            }
        }

        if (gameObject.CompareTag("Purple"))
        {
            if (collision.collider.gameObject.CompareTag("Player"))
            {
                purpleCounter++;

                PurpleText.GetComponent<Text>().text = "Purple: " + purpleCounter;
                audioSource.Play();
            }
        }
    }
}
