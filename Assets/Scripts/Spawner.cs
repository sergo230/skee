using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

//main class "spawner"
public class Spawner : MonoBehaviour
{
    public GameObject Obj;
    [Header("size array have to = 2 and first element = minimum value , second element = maximum value")]
    public float[] X_Min_And_Max_Position = new float[2];
    [Header("size array have to = 2 and first element = minimum value , second element = maximum value")]
    public float[] Y_Min_And_Max_Position = new float[2];

    protected GameObject spawningObj;
    [HideInInspector]
    public virtual void spawn()
    {
        //find position
        float xRandomPosition = Random.Range(X_Min_And_Max_Position[0], X_Min_And_Max_Position[1]);
        float yRandomPosition = Random.Range(Y_Min_And_Max_Position[0], Y_Min_And_Max_Position[1]);
        
        Vector3 spawnPosition = new Vector3(xRandomPosition,yRandomPosition,0);

        //spawn object
        spawningObj = Instantiate(Obj, spawnPosition, Quaternion.identity);
    }
}
