using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class ViewUI : MonoBehaviour {

    public InputField inputField;
    public Button btn;
    public Text resultTxt;

    public InputController controller;

	// Use this for initialization
	void Start () {
        btn.onClick.AddListener(OnBtnClick); //注册按钮的点击事件
	}

    private void OnBtnClick()
    {
        string content = inputField.text; //获取input中的玩家输入 已经限制好了 必须是整形
        if (!string.IsNullOrEmpty(content))
        {
            int num = int.Parse(content);  //将string转换成int
            controller.BeginCount(num, OnComplete); //通过控制器对象传入玩家输入的数字和回调方法
        }
    }

    //经过层层传递和数据层的计算，将结果通知给我这个显示层，最后显示层在输入到UI界面上。
    void OnComplete(int reslut)
    {
        resultTxt.text = reslut.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
