using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelData{

    public delegate void CountNumComplete(int reslut);

    private static ModelData _instance;
    public static ModelData GetInstance
    {
        get
        {
            if (_instance == null)
                _instance = new ModelData();
            return _instance;
        }
    }


    public void CountNum(int num, CountNumComplete callback) //CountNumComplete callback = OnComplete;
	{
        int reslut = num * 2;
        callback(reslut); //将计算的结果通过回调(委托)返回给显示层
    }

}
