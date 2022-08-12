using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cw : MonoBehaviour
{
    public int scoor = 0;
    public Text scooretext;
    public int inc = 1;
    public Text inct;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void scoorup()
    {
        scoor += inc ;
        scooretext.text = scoor.ToString();
    }

    public void shop()
    {
        if (scoor >= 5)
        {
            scoor -= 5;
            inc += 1;
            scooretext.text = scoor.ToString();
            inct.text ="inc: "+ inc;
        }
    }
}
