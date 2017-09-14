using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //消息传递者
    public void BeginCount(int num, ModelData.CountNumComplete callback)
    {
        ModelData.GetInstance.CountNum(num, callback); //将显示层传入的数据和回调方法直接
    }
}
