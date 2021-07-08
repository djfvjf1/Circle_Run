using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform SpawnPos; // Позиция генератора объектов (кароче, тот самый 3D Object, который будет спавнить врагов)

    [SerializeField] Vector2 range; // В каком промежутке будет допустимо создание объектов

    [SerializeField] GameObject enemy; // Тот объект, который мы будем спавнить

    [SerializeField] GameObject point; 

    private void Start()
    {

        StartCoroutine(Spawn());

    }


    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(1); // С какой периодичностью будут генерироваться объекты(враги)
        
        // При каждой итерации будем создавать новую точку, в которой будет спавниться объект
        Vector2 pos = SpawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Vector2 pos1 = SpawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));

        // Создаем сам объект
        Instantiate(enemy, pos, Quaternion.identity);
        Instantiate(point, pos1, Quaternion.identity);

        Repeat();


        

    }


    void Repeat()
    {

        StartCoroutine(Spawn());

    }

}
