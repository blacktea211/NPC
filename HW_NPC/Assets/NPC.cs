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
    /// ���
    /// </summary>
    private void dialogue() 
    {
        print("��ܪ����e");

    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    public bool openshop = true;

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="props"></param>
    /// <param name="price"�D����100��></param>
    /// <returns></returns>
    public int buyprops(int props) 
    {
        return props * 100;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="number">���Ƚs��</param>
    public void GetQuest( string number ="���Ƚs��") 
    {
        print("���o����" + number);
    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="props">�D��ƶq</param>
    /// <returns></returns>
    private int UpdateQuest(int props) 
    {
        return props+1;
    
    }

    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    private bool DownQuest(string number = "���Ƚs��") 
    {
        
    }




}
