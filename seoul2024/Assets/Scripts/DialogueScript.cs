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
    IEnumerator PrologueSceneMove(){
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
            Scene1Dialogue = 4;

        }
        else if (Scene1Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);
            Scene1Dialogue = 5;


            //굉음 울리기

        }
        else if (Scene1Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("phone").gameObject.SetActive(true);

            Scene1Dialogue = 6;

            //브금 바
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

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);


            Scene2Dialogue = 1;
        }
        else if (Scene2Dialogue == 1)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_1").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);

            Scene2Dialogue = 2;
        }
        else if (Scene2Dialogue == 2)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_2").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene2Dialogue = 3;
        }
        else if (Scene2Dialogue == 3)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_3").gameObject.SetActive(false);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);

            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(true);
            Scene2Dialogue = 4;

        }
        else if (Scene2Dialogue == 4)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_4").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(true);
            Scene2Dialogue = 5;
        }
        else if (Scene2Dialogue == 5)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_5").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(true);


            Scene2Dialogue = 6;

            //브금 바
        }
        else if (Scene2Dialogue == 6)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_6").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(true);
            Scene2Dialogue = 7;

        }
        else if (Scene2Dialogue == 7)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_7").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(true);


            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(true);
            Scene2Dialogue = 8;

        }
        else if (Scene2Dialogue == 8)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_8").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(true);

            GameObject.Find("Character").transform.Find("eunyoung").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("eunyoung").gameObject.SetActive(false);
            Scene2Dialogue = 9;
        }
        else if (Scene2Dialogue == 9)
        {
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_9").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("dialog").transform.Find("context_10").gameObject.SetActive(true);
        }
        else if (Scene2Dialogue == 10)
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

}
