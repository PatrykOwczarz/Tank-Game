using UnityEngine;
using UnityEngine.AI;

namespace TanksMP
{
	public class EnemyController : MonoBehaviour {

		public float lookRadius = 20f;
		public float shootRadius = 15f;
		public float followRadius = 5f;
	 
		Transform target;
		NavMeshAgent agent; 

		public AudioClip shotClip;
		public GameObject shotFX;
		public Transform turret;
		public Transform shotPos;

		/// Bullet object for shooting.
		public GameObject bullet;
		private float fireRate = 1.5f;
		private float nextFire;

		// Use this for initialization
		void Start () {

		target = PlayerManager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
	}
	
		// Update is called once per frame
		void Update () {
		
			float distance = Vector3.Distance (target.position, transform.position);

			if (distance <= lookRadius) 
			{
				if (distance >= followRadius) 
				{
					agent.SetDestination (target.position);
				}
				if (distance <= shootRadius) 
				{
					FaceTarget ();
					Shoot ();
				}
			}
		}

		void FaceTarget()
		{
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
			transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);
			
		}
		
		void Shoot(Vector2 direction = default(Vector2))
		{
			if (Time.time > nextFire) 
			{
				nextFire = Time.time + fireRate;

				GameObject obj = PoolManager.Spawn (bullet, shotPos.position, transform.rotation);
				Bullet blt = obj.GetComponent<Bullet> ();

				if (shotFX)
					PoolManager.Spawn (shotFX, shotPos.position, Quaternion.identity);

				if (shotClip)
					AudioManager.Play3D (shotClip, shotPos.position, 0.1f);
			}
		}

		void OnDrawGizmosSelected()
		{
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere (transform.position, lookRadius);
		}

	}
}