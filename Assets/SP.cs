using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class SP : MonoBehaviour
{
    //äÓëbìÆçÏÇÃAnimation
    public SkeletonAnimation Anim;

    void Start()
    {
        Anim.state.SetAnimation(10,"Idle",true);
    }

    // Update is called once per frame
    public int SkinCheck=1;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            switch (SkinCheck)
            {
                case 1:
                    Anim.skeleton.SetSkin("tuujou");
                    SkinCheck++;

                    break;
                case 2:
                    Anim.skeleton.SetSkin("yabure");
                    SkinCheck++;
                    break;
                case 3:
                    Anim.Skeleton.Skin = null;
                    Anim.ClearState();
                    Anim.Initialize(true);

                    SkinCheck =1;
                    break;

            }

            Debug.Log(Anim.skeleton.Skin.ToString());

        }
    }
}
