using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI_mianleve : MonoBehaviour
{
    public int whichlevel = 1;

    bool ananniu = true;
    
    public void TipButton()
    {
        Instantiate(Resources.Load<GameObject>("UIvoice/UIananniu"));
        print(whichlevel);
        if (ananniu)
        {
            if (whichlevel >= 100)
            {
                transform.root.GetComponent<UI_main>().UIloading.SetActive(true);
                Invoke("WaitTime", 3f);
            }
            else
            {
                Invoke("WaitTime2", 1f);
            }

            ananniu = false;
        }
    }

    private void WaitTime()
    {
        ananniu = true;
        transform.root.GetComponent<UI_main>().UIloading.SetActive(false);
    }

    private void WaitTime2()
    {
        Plane_Gameclass.playerDUNmount = 2; //初始换盾牌数量
        Plane_Gameclass.playerPower = 2;    //大招的数量
        ananniu = true;
        Plane_Gameclass.gamelevel = whichlevel;
        SceneManager.LoadScene("1");
    }
}