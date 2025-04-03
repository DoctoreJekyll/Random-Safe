using UnityEngine;

namespace GamePlay.Enemies
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField] Rigidbody2D rb2D;
        public Vector2 enemyMovement;

        public bool canRun;
        

        private void FixedUpdate()
        {
            if (canRun && PlayerBeginGame.playerBeginGameInstance.gamePlayStart)
            {
                float velocity = enemyMovement.x;
                rb2D.velocity = new Vector2(velocity * Time.deltaTime, rb2D.velocity.y);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 6 || collision.gameObject.layer == 9 && PlayerBeginGame.playerBeginGameInstance.gamePlayStart)
            {
                canRun = true;
            }
        }
    }
}
