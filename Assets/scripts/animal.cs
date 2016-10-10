using UnityEngine;
using System.Collections;

public class animal : MonoBehaviour {

    float timer;
    float delayTime = 4f;
    float maxx;
    float maxy;
    float minx;
    float miny;
    GameManager gm;


	// Use this for initialization
	void Start () {
        gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            Vector3 pos = new Vector3(Random.Range(minx, maxx), Random.Range(miny, maxy), 0);
            transform.position = pos;
            if (delayTime > 0.5f)
            {
                delayTime -= 0.1f;
            }

            timer = delayTime - 0.1f;

        }

        if (Input.touchCount == 1)
        {
            Touch playerTouch = Input.touches[0];
            if (playerTouch.phase == TouchPhase.Began)
            {
                //قام اللاعب للتو بوضع إصبعه على الشاشة
                //هل تم وضع الإصبع على هذا الكائن تحديدا؟
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(playerTouch.position);

                //اجلب مكوّن التصادم الخاص بهذا الكائن
                Collider2D myCollider = GetComponent<Collider2D>();

                //قم بتوليد شعاع قصير جدا ابتداء من موقع اللمس وباتجاه الأعلى واليمين
                //ومن ثم تحقق من كون هذا الشعاع قد اصطدم بمكوّن التصادم الخاص بهذا الكائن
                RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.one, 0.1f);
                if (hit.collider == myCollider)
                {
                    //نعم لقد قام اللاعب بلمس هذا الكائن بإصبع واحد
                    //mang.IncScore();
                    //mang.killAnimal();
                    Debug.Log("Destroy");
                    gm.SendMessage("box",SendMessageOptions.DontRequireReceiver);
                   // Destroy(gameObject);
                }
            }

        }
        
	}

    public void setRange(float maxx,float maxy,float minx,float miny)
    {
        this.maxx = maxx;
        this.maxy = maxy;
        this.minx = minx;
        this.miny = miny;
    }
}
