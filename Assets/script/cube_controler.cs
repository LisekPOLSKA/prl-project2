using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class cube_controler : MonoBehaviour
{
    public Animation animation;
    public AudioSource audioSource;
    public AudioClip soundEffect;
    public GameObject trana;
    public GameObject tranb;
    public GameObject tranc;
    public controler player;
    int wynik;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void Rzut()
    {
        gameObject.SetActive(true);
        trana.gameObject.SetActive(false);
        tranb.gameObject.SetActive(false);
        tranc.gameObject.SetActive(false);
        animation.Play();
        audioSource.PlayOneShot(soundEffect);
        await Task.Delay(1000);
       System.Random generator = new System.Random();
        wynik = generator.Next(1,3);
        if(wynik == 1)
        {
            gameObject.SetActive(false);
            trana.gameObject.SetActive(true);
        }
        else if(wynik == 2)
        {
            gameObject.SetActive(false);
            tranb.gameObject.SetActive(true);
        }
        else if (wynik == 3)
        {
            gameObject.SetActive(false);
            tranc.gameObject.SetActive(true);
        }
        player.wynik = wynik;
        //Rotate(wynik);
    }

    public void Rotate(int a)
    {
        transform.rotation = Quaternion.Euler(180, 0, 180);
    }
}
