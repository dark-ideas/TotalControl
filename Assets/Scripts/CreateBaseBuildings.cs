using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum baseBuildPrefab {HQ, Mine, AA_turret, Land_turret, Air_Hangar, Land_Hangar, Air_Factory, Land_Factory, RND_Center, Radar, Warehouse};
public class CreateBaseBuildings : MonoBehaviour
{
    public baseBuildPrefab selectedPrefab;
    public GameObject[] buildPrefabs;

    public void CreateBuildingDraft(int draftNr)
    {
        Instantiate(buildPrefabs[0], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        
    }
}
