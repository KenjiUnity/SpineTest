using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{

    public GameObject SpineCG;
    public GameObject SpineCG2;
    public GameObject SpineCG2_Gun;
    public SpriteRenderer SampleImage;
    public Image SampleImage2;

    public Material _Material;

    Slot _Slot;
    Slot _Slot2;

    void Start()
    {
        //モザイクの処理
        _Slot = SpineCG.GetComponent<SkeletonAnimation>().skeleton.FindSlot("gun");
        SpineCG.GetComponent<SkeletonAnimation>().CustomSlotMaterials[_Slot] = _Material;
        SampleImage.material = _Material;

        //モザイクの処理
        
        SampleImage2.material = _Material;
    }

}
