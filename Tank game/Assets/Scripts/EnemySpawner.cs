using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
	public GameObject Enemy;
	public Transform[] SpawnPositions;

	private float timePassed;
	private int numberOfEnemies = 1;

	void Update()
	{
		timePassed += Time.deltaTime;

		if (timePassed > 30f)
		{
			for (int i = 0; i < numberOfEnemies; i++)
			{
				int index = Random.Range (0, SpawnPositions.Length);
				SpawnEnemy (SpawnPositions [index].position);
			}
			numberOfEnemies++;
			timePassed = 0f;
		}
	}
	private void SpawnEnemy(Vector3 position)
	{
		Instantiate(Enemy, position, Quaternion.identity);
	}
}