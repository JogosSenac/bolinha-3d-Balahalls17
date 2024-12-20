using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BolinhaMove : MonoBehaviour
{
private float moveH;
private float moveV;
private Rigidbody rb;
public int contcoin;
[SerializeField] private float velocidade;
[SerializeField] private float forcaPulo;
[SerializeField] private int countcoin = 0;
[Header ("Sons da Bolinha")]
    [SerializeField] private AudioClip morte;
    [SerializeField] private AudioClip pulo;
    [SerializeField] private AudioClip pegaCubo;
    [SerializeField] private AudioSource audioPlayer;


public GameObject coin;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contcoin = 0;
        audioPlayer = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, moveV * velocidade * Time.deltaTime);


        


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode.Impulse);
             audioPlayer.PlayOneShot(pulo);

        }
    }
    void Fase2()
    {
        if(countcoin == 8)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("agua"))
        {
            Destroy(this.gameObject);
            audioPlayer.PlayOneShot(morte);

            SceneManager.LoadScene("GameOver");
        }
    }

private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.CompareTag("coin"))
    {
        Destroy(other.gameObject);
         audioPlayer.PlayOneShot(pegaCubo);

        contcoin +=1;
    }
     


}






}
                          