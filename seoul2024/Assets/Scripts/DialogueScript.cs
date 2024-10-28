using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueScript : MonoBehaviour
{
    public GameObject fadeController;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSceneMain()
    {
        SceneManager.LoadScene("SampleScene");
    }


    int prologueDialogue = 0;
    public void ProgressPrologueDialogue()
    {
        if (prologueDialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);
            prologueDialogue = 1;
        }
        else if (prologueDialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);
            prologueDialogue = 2;
        }
        else if (prologueDialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);
            prologueDialogue = 3;


        }
        else if (prologueDialogue == 3)
        {
            // move scene
            fadeController.GetComponent<FadeController>().FadeOut();
            StartCoroutine(PrologueSceneMove());

        }
    }
    IEnumerator PrologueSceneMove() {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_1");

    }


    //-------------------------은영 집앞 씬--------------------------
    int Scene1Dialogue = 0;
    public void ProgressScene1Dialogue()
    {
        if (Scene1Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);


            Scene1Dialogue = 1;
        }
        else if (Scene1Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene1Dialogue = 2;
        }
        else if (Scene1Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene1Dialogue = 3;
        }
        else if (Scene1Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("bgm_op").GetComponent<AudioSource>().Stop();

            Scene1Dialogue = 4;

        }
        else if (Scene1Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);
            Scene1Dialogue = 5;

            GameObject.Find("bgm_op").GetComponent<AudioSource>().Stop();
            GameObject.Find("sfx_bomb").GetComponent<AudioSource>().Play();
            //굉음 울리기

        }
        else if (Scene1Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("phone").gameObject.SetActive(true);

            GameObject.Find("bgm_afterboom").GetComponent<AudioSource>().Play();
            Scene1Dialogue = 6;
        }
        else if (Scene1Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);
            Scene1Dialogue = 7;

        }
        else if (Scene1Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("phone").gameObject.SetActive(false);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            Scene1Dialogue = 8;

        }
        else if (Scene1Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene1Dialogue = 9;
        }
        else if (Scene1Dialogue == 9)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
            StartCoroutine(Scene1Move());
        }
    }
    IEnumerator Scene1Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_2");

    }



    //----------------------회사 난간 씬 -------------------------
    int Scene2Dialogue = 0;
    public void ProgressScene2Dialogue()
    {
        if (Scene2Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);


            Scene2Dialogue = 1;
        }
        else if (Scene2Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene2Dialogue = 2;
        }
        else if (Scene2Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("KIM_GM").gameObject.SetActive(true);

            Scene2Dialogue = 3;
        }
        else if (Scene2Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("KIM_GM").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene2Dialogue = 4;
        }
        else if (Scene2Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene2Dialogue = 5;
        }
        else if (Scene2Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            Scene2Dialogue = 6;
        }
        else if (Scene2Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("KIM_GM").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("KIM_GM").gameObject.SetActive(true);

            Scene2Dialogue = 7;

        }
        else if (Scene2Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("KIM_GM").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("KIM_GM").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            Scene2Dialogue = 8;
        }
        else if (Scene2Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene2Dialogue = 9;
        }
        else if (Scene2Dialogue == 9)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_10").gameObject.SetActive(true);


            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("sfx_door").GetComponent<AudioSource>().Play();
            Scene2Dialogue = 10;
        }

        //-=-------------------사무실 이동----------------------------------------------------------------

        else if (Scene2Dialogue == 10)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
            StartCoroutine(FadeInScene());

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_10").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_11").gameObject.SetActive(true);


            GameObject.Find("Background").transform.Find("bg_stairs").gameObject.SetActive(false);
            GameObject.Find("Background").transform.Find("bg_office").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("KIM_GM").gameObject.SetActive(false);

            GameObject.Find("Character").transform.Find("staff_A").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("staff_A").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);

            GameObject.Find("Character").transform.Find("staff_B").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("staff_B").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);

            Scene2Dialogue = 11;
        }
        else if (Scene2Dialogue == 11)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_11").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_12").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("staff_A").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_A").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("staff_A").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            Scene2Dialogue = 12;
        }
        else if (Scene2Dialogue == 12)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_12").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_13").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_A").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("staff_A").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_B").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("staff_B").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            Scene2Dialogue = 13;
        }
        else if (Scene2Dialogue == 13)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_13").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_14").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_A").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("staff_A").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_B").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("staff_B").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            Scene2Dialogue = 14;
        }
        else if (Scene2Dialogue == 14)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_14").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_15").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("staff_A").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("staff_A").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            Scene2Dialogue = 15;
        }

        else if (Scene2Dialogue == 15)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_15").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_16").gameObject.SetActive(true);

            Scene2Dialogue = 16;
        }
        else if (Scene2Dialogue == 16)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_16").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_17").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);

            Scene2Dialogue = 17;
        }
        else if (Scene2Dialogue == 17)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_17").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_18").gameObject.SetActive(true);
            Scene2Dialogue = 18;
        }
        else if (Scene2Dialogue == 18)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
            StartCoroutine(Scene2Move());
        }
    }
    IEnumerator Scene2Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_3");

    }
    IEnumerator FadeInScene()
    {
        yield return new WaitForSeconds(0.5f);
        fadeController.GetComponent<FadeController>().FadeIn();

    }


    //--------------------------다시 현재 ------=----------------
    int Scene3Dialogue = 0;
    public void ProgressScene3Dialogue()
    {
        if (Scene3Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            Scene3Dialogue = 1;
        }
        else if (Scene3Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene3Dialogue = 2;
        }
        else if (Scene3Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene3Dialogue = 3;
        }
        else if (Scene3Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene3Dialogue = 4;
        }
        else if (Scene3Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene3Dialogue = 5;
        }
        else if (Scene3Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("choices").gameObject.SetActive(true);
        }
    }

    public void ChoicePickTicket()
    {
        StartCoroutine(Scene4Move());
    }
    public void ChoiceIgnoreTicket()
    {
        StartCoroutine(Scene4_1Move());
    }
    IEnumerator Scene4Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_4");

    }
    IEnumerator Scene4_1Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_4_1");

    }

    //------------------------------줍지 않는다 ---------------------------------
    int Scene41Dialogue = 0;
    public void ProgressScene41Dialogue()
    {
        if (Scene41Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene41Dialogue = 1;
        }
        else if (Scene41Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene41Dialogue = 2;
        }
        else if (Scene41Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            Scene41Dialogue = 3;
        }
        else if (Scene41Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);


            Scene41Dialogue = 4;
        }
        else if (Scene41Dialogue == 4)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
        }

    }

    // -------------------------------줍는다------=-------------------------------
    int Scene4Dialogue = 0;
    public void ProgressScene4Dialogue()
    {
        if (Scene4Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene4Dialogue = 1;
        }
        else if (Scene4Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene4Dialogue = 2;
        }
        else if (Scene4Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            Scene4Dialogue = 3;
        }
        else if (Scene4Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            Scene4Dialogue = 4;
        }
        else if (Scene4Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene4Dialogue = 5;
        }
        else if (Scene4Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene4Dialogue = 6;
        }
        else if (Scene4Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);
            Scene4Dialogue = 7;
        }
        else if (Scene4Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);
            Scene4Dialogue = 8;
        }
        else if (Scene4Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);
            Scene4Dialogue = 9;
        }
        else if (Scene4Dialogue == 9)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
            StartCoroutine(Scene5Move());

        }

    }
    IEnumerator Scene5Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_5");

    }



    // -------------------------------벙커 입구---------------------------------
    int Scene5Dialogue = 0;
    public void ProgressScene5Dialogue()
    {
        if (Scene5Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            Scene5Dialogue = 1;
        }
        else if (Scene5Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene5Dialogue = 2;
        }
        else if (Scene5Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);

            Scene5Dialogue = 3;
        }
        else if (Scene5Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene5Dialogue = 4;
        }
        else if (Scene5Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene5Dialogue = 5;
        }
        else if (Scene5Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(false);

            Scene5Dialogue = 6;
        }
        else if (Scene5Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene5Dialogue = 7;
        }
        else if (Scene5Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);


            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(false);

            Scene5Dialogue = 8;
        }
        else if (Scene5Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene5Dialogue = 9;
        }
        else if (Scene5Dialogue == 9)
        {
            GameObject.Find("Canvas").transform.Find("dialog").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("choices").gameObject.SetActive(true);

        }

    }
    public void ChoiceBunker()
    {
        StartCoroutine(Scene6_1Move());
    }
    public void ChoiceMIA()
    {
        StartCoroutine(Scene6Move());
    }

    IEnumerator Scene6Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_6");

    }
    IEnumerator Scene6_1Move()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene_6_1");

    }


    //------------------------------ 자신이 들어감 ---------------------------------
    int Scene61Dialogue = 0;
    public void ProgressScene61Dialogue()
    {
        if (Scene61Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("guard").gameObject.SetActive(true);


            Scene61Dialogue = 1;
        }
        else if (Scene61Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);



            Scene61Dialogue = 2;
        }
        else if (Scene61Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("guard").gameObject.SetActive(true);


            Scene61Dialogue = 3;
        }
        else if (Scene61Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);


            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("guard").gameObject.SetActive(false);


            Scene61Dialogue = 4;
        }
        else if (Scene61Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);

            Scene61Dialogue = 5;
        }
        else if (Scene61Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene61Dialogue = 6;
        }
        else if (Scene61Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);

            Scene61Dialogue = 7;
        }
        else if (Scene41Dialogue == 7)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
        }

    }


    //------------------------------아이에게 양보 ---------------------------------------

    int Scene6Dialogue = 0;
    public void ProgressScene6Dialogue()
    {
        if (Scene6Dialogue == 0)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Character").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);


            Scene6Dialogue = 1;
        }
        else if (Scene6Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);
            Scene6Dialogue = 2;

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

        }
        else if (Scene6Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene6Dialogue = 3;
        }
        else if (Scene6Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene6Dialogue = 4;
        }
        else if (Scene6Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);


            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(false);

            Scene6Dialogue = 5;
        }
        else if (Scene6Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene6Dialogue = 6;
        }
        else if (Scene6Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);

            Scene6Dialogue = 7;
        }
        else if (Scene6Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);


            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(false);

            Scene6Dialogue = 8;
        }
        else if (Scene6Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene6Dialogue = 9;
        }
        else if (Scene6Dialogue == 9)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_10").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("MIA").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene6Dialogue = 10;
        }
        else if (Scene6Dialogue == 10)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_10").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_11").gameObject.SetActive(true);


            GameObject.Find("Character").transform.Find("MIA").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("MIA").gameObject.SetActive(false);

            Scene6Dialogue = 11;
        }
        else if (Scene6Dialogue == 11)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_11").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_12").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);

            Scene6Dialogue = 12;
        }
        else if (Scene6Dialogue == 12)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_12").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_13").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").GetComponent<Renderer>().material.color = new Color32(150, 150, 150, 255);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            Scene6Dialogue = 13;
        }
        else if (Scene6Dialogue == 13)
        {
            fadeController.GetComponent<FadeController>().FadeOut();
            //StartCoroutine(EpilogueSceneMove());
        }

    }
    IEnumerator EpilogueSceneMove()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("EpilogueScene");

    }
}
  
