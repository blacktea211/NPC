using UnityEngine;

public class NPC : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {
       

    }
    /// <summary>
    /// 對話
    /// </summary>
    private void dialogue() 
    {
        print("對話的內容");

    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    public bool openshop = true;

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="props"></param>
    /// <param name="price"道具單價100元></param>
    /// <returns></returns>
    public int buyprops(int props) 
    {
        return props * 100;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="number">任務編號</param>
    public void GetQuest( string number ="任務編號") 
    {
        print("取得任務" + number);
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="props">道具數量</param>
    /// <returns></returns>
    private int UpdateQuest(int props) 
    {
        return props+1;
    
    }

    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private bool DownQuest(string number = "任務編號") 
    {
        
    }




}
