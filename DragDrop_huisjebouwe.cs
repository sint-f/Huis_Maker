using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragDrop_huisjebouwe : MonoBehaviour
{
    bool inside;
    public GameObject dak;
    public GameObject hand;
    public AudioSource source;
    public AudioClip AudioClip;
    public Animator animator;

    private Rigidbody2D dakRb;

    private void Start()
    {
        dakRb = dak.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Hand")
        {
            inside = true;
            Debug.Log("inside = " + inside);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hand")
        {
            inside = false;
            Debug.Log("inside = " + inside);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pak();
            animator.SetBool("grab", true);
        }
        if (inside && Input.GetKey(KeyCode.Space))
        {
            Grab();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Release();
            animator.SetBool("grab", false);
        }

    }

    private void Grab()
    {
        dak.transform.parent = hand.transform;
        dakRb.isKinematic = true;
    }

    private void Release()
    {
        dak.transform.parent = null;
        dakRb.isKinematic = false;
    }
    private void pak()
    {
        source.clip = AudioClip;
        source.Play();
    }
}

