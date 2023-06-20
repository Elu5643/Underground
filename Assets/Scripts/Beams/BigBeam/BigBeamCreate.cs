using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBeamCreate : MonoBehaviour
{
    public GameObject RBigbeam;
    public GameObject LBigbeam;
    public GameObject DRBigbeam;
    public GameObject DLBigbeam;
    public GameObject HigthBigbeam;
    public GameObject LowBigbeam;
    public GameObject EndRBigbeam;
    public GameObject EndLBigbeam;
    public GameObject CRBigbeam;
    public GameObject CLBigbeam;
    public GameObject CHigthBigbeam;
    public GameObject CLowBigbeam;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RBigBeamCreate", 0f);
        Invoke("LBigBeamCreate", 0f);
        Invoke("DRBigBeamCreate", 2f);
        Invoke("DLBigBeamCreate", 2f);
        Invoke("HigthBigBeamCreate", 4f);
        Invoke("LowBigBeamCreate", 4f);
        Invoke("EndRBigBeamCreate", 6f);
        Invoke("EndLBigBeamCreate", 6f);
        Invoke("CRBigBeamCreate", 8f);
        Invoke("CLBigBeamCreate", 8f);
        Invoke("CHigthBigBeamCreate", 8f);
        Invoke("CLowBigBeamCreate", 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RBigBeamCreate()
    {
        RBigbeam = Instantiate(RBigbeam);
    }

    void LBigBeamCreate()
    {
        LBigbeam = Instantiate(LBigbeam);
    }
    
    void DRBigBeamCreate()
    {
        DRBigbeam = Instantiate(DRBigbeam);
    }
    
    void DLBigBeamCreate()
    {
        DLBigbeam = Instantiate(DLBigbeam);
    }
    
    void HigthBigBeamCreate()
    {
        HigthBigbeam = Instantiate(HigthBigbeam);
    }

    void LowBigBeamCreate()
    {
        LowBigbeam = Instantiate(LowBigbeam);
    }

    void EndRBigBeamCreate()
    {
        EndRBigbeam = Instantiate(EndRBigbeam);
    }

    void EndLBigBeamCreate()
    {
        EndLBigbeam = Instantiate(EndLBigbeam);
    }

    void CRBigBeamCreate()
    {
        CRBigbeam = Instantiate(CRBigbeam);
    }

    void CLBigBeamCreate()
    {
        CLBigbeam = Instantiate(CLBigbeam);
    }

    void CHigthBigBeamCreate()
    {
        CHigthBigbeam = Instantiate(CHigthBigbeam);
    }

    void CLowBigBeamCreate()
    {
        CLowBigbeam = Instantiate(CLowBigbeam);
    }
}
