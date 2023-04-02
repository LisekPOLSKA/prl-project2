using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class controler : MonoBehaviour
{
    public int pole = 1;
    public int maxPole = 15;
    public cube_controler cube;
    public int wynik;
    public int punkty = 3;
    public GameObject plansza1, plansza2, plansza3, plansza4, plansza5, plansza6, plansza7, plansza8, plansza9, plansza10, plansza11, plansza12, plansza13, plansza14;
    public Image I_1, I_2, I_3;
    public Image II_1, II_2, II_3;
    public Image III_1, III_2;
    public Image IV_1, IV_2, IV_3;
    public Image V_1, V_2, V_3;
    public Image VI_1, VI_2, VI_3;
    public Image VII_1, VII_2, VII_3;
    public Image VIII_1, VIII_2;
    public Image IX_1,IX_2;
    public Image X_1, X_2;
    public Image XI_1, XI_2, XI_3;
    public Image XII_1, XII_2;
    public Image XIII_1, XIII_2, XIII_3;
    public Image XIV_1, XIV_2;
    public bool gotoweOff = false;
    public AudioClip najpierwOdpowiedz, start;
    public AudioSource audioSource;
    public AudioSource gameController;
    public int click = 0;
    public GameObject cube1, cube2, cube3;
    public TMPro.TextMeshProUGUI point;
    public GameObject ponty;
    public GameObject przegrana;
    public GameObject wygrana;
    public AudioClip A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14;
    public AudioClip przegranaKlip, wygranaKlip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(start);
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        point.text = "Punkty: " + punkty;
        if(punkty <= 0)
        {
            przegrana.SetActive(true);
            PokaPlansze();
            gameController.PlayOneShot(przegranaKlip);
        }
    }

    public async void Ktos()
    {
        if(pole == 1 && click == 0)
        {
            PokaPlansze();
            plansza1.SetActive(true);
            gameController.PlayOneShot(A1);
        }
        else 
        {
        cube.Rzut();
        await Task.Delay(2000);
            if (pole + wynik <= maxPole)
            {
                pole += wynik;
                switch (pole)
                {
                    case 2:
                        ChangePostion((float)-6.6, (float)3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza2.SetActive(true);
                        gameController.PlayOneShot(A2);
                        break;
                    case 3:
                        ChangePostion((float)-2.2, (float)3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza3.SetActive(true);
                        gameController.PlayOneShot(A3);
                        break;
                    case 4:
                        ChangePostion((float)2.4, (float)3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza4.SetActive(true);
                        gameController.PlayOneShot(A4);
                        break;
                    case 5:
                        ChangePostion((float)6.2, (float)3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza5.SetActive(true);
                        gameController.PlayOneShot(A5);
                        break;
                    case 6:
                        ChangePostion((float)10, (float)3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza6.SetActive(true);
                        gameController.PlayOneShot(A6);
                        break;
                    case 7:
                        ChangePostion((float)10, (float)0);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza7.SetActive(true);
                        gameController.PlayOneShot(A7);
                        break;
                    case 8:
                        ChangePostion((float)10, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza8.SetActive(true);
                        gameController.PlayOneShot(A8);
                        break;
                    case 9:
                        ChangePostion((float)6.6, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza9.SetActive(true);
                        gameController.PlayOneShot(A9);
                        break;
                    case 10:
                        ChangePostion((float)2.4, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza10.SetActive(true);
                        gameController.PlayOneShot(A10);
                        break;
                    case 11:
                        ChangePostion((float)-2.2, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza11.SetActive(true);
                        gameController.PlayOneShot(A11);
                        break;
                    case 12:
                        ChangePostion((float)-6, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza12.SetActive(true);
                        gameController.PlayOneShot(A12);
                        break;
                    case 13:
                        ChangePostion((float)-10, (float)-3.4);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza13.SetActive(true);
                        gameController.PlayOneShot(A13);
                        break;
                    case 14:
                        ChangePostion((float)-10, (float)0);
                        await Task.Delay(500);
                        PokaPlansze();
                        plansza14.SetActive(true);
                        gameController.PlayOneShot(A14);
                        break;
                    case 15:
                        ChangePostion((float)-10, (float)3.54);
                        await Task.Delay(500);
                        wygrana.SetActive(true);
                        gameController.PlayOneShot(wygranaKlip);
                        PokaPlansze();
                        break;
                }
            }
        }
        click += 1;
    }
    public void ChangePostion(float x, float y)
    {
        transform.position = new Vector2(x, y);
    }

    public void PokaPlansze()
    {
        gameObject.SetActive(false);
        cube.gameObject.SetActive(false);
        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        ponty.SetActive(false);
        gotoweOff = false;
    }
    public void UkryjPlansze()
    {
        gameObject.SetActive(true);
        cube.gameObject.SetActive(true);
        ponty.SetActive(true);
        gameController.Stop();
    }

    public void Odpowiedz3(bool czyDobra)
    {
        I_3.color = Color.green;
        I_1.color = Color.red;
        I_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz4(bool czyDobra)
    {
        II_2.color = Color.green;
        II_1.color = Color.red;
        II_3.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }

    public void Odpowiedz5(bool czyDobra)
    {
        III_1.color = Color.green;
        III_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz6(bool czyDobra)
    {
        IV_1.color = Color.green;
        IV_2.color = Color.red;
        IV_3.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz7(bool czyDobra)
    {
        V_3.color = Color.green;
        V_1.color = Color.red;
        V_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz8(bool czyDobra)
    {
        VI_2.color = Color.green;
        VI_1.color = Color.red;
        VI_3.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz9(bool czyDobra)
    {
        VII_1.color = Color.green;
        VII_2.color = Color.red;
        VII_3.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz10(bool czyDobra)
    {
        VIII_1.color = Color.green;
        VIII_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz11(bool czyDobra)
    {
        IX_1.color = Color.green;
        IX_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz12(bool czyDobra)
    {
        X_2.color = Color.green;
        X_1.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz13(bool czyDobra)
    {
        XI_3.color = Color.green;
        XI_1.color = Color.red;
        XI_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz14(bool czyDobra)
    {
        XII_2.color = Color.green;
        XII_1.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz15(bool czyDobra)
    {
        XIII_3.color = Color.green;
        XIII_1.color = Color.red;
        XIII_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void Odpowiedz16(bool czyDobra)
    {
        XIV_1.color = Color.green;
        XIV_2.color = Color.red;
        if (czyDobra)
        {
            punkty += 1;
        }
        else
        {
            punkty -= 1;
        }
        gotoweOff = true;
    }
    public void PlanszaPaPa(GameObject plansza)
{
        if (gotoweOff)
        {
            plansza.SetActive(false);
            UkryjPlansze();
        }
        else
        {
            gameController.PlayOneShot(najpierwOdpowiedz);
        }
}
}
