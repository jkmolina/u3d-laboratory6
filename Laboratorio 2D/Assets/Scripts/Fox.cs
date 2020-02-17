using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fox : MonoBehaviour
{
    public GameObject fox;
    public AudioSource fair;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resetLevel()
    {
        SceneManager.LoadScene("SampleScene");
        Movement.guapo = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Randy")&&(!Movement.guapo))
        {
            Debug.Log("mario dies");
            Destroy(other.gameObject);
        } 

        else
        {
            Destroy(gameObject);
            fair.Play();
        }
    }
}
