using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CreatePoolDictionary))]    
public class CreateGameObjectsPool : MonoBehaviour
{
    #region Unity Fileds
    [SerializeField] private List<Pool> poolGameObjects;
    #endregion
    private CreatePoolDictionary poolDic;
    private Transform destinationParentTransform;
    private void Awake()
    {
      StartPooling();

    }

    public void StartPooling()
    {
        destinationParentTransform=this.transform;
        poolDic = GetComponent<CreatePoolDictionary>();
        poolDic.ResetPool();
        poolDic.SetPool(poolGameObjects, destinationParentTransform);
    }

    public GameObject CreateGameObject(string prefabName,Vector3 pos, Transform parent=null)
    {
       
        return poolDic.SpawnFromPool(prefabName, pos, parent);
    }















}
