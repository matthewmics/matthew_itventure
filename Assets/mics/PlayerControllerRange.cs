using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;
using UnityEngine.SceneManagement;

public class PlayerControllerRange : MonoBehaviour
{

    public static bool isTalking = false;

    public float moveSpeed;
    private Animator anim;
    private bool playerMoving = false;
    private Vector2 lastmove;
    private Rigidbody2D playerrigidbody;
    private static bool playerExists;
    private bool attacking;
    public float attackTime;
    private float attackTimeC;
    public GameObject weapon;
    public string startPoint;

    public float diagonalMoveModifier;
    private float currentMoveSpeed;
    public bool canMove;

    public GameObject[] RangeWeapon;

    public static bool[] characterDirection;

    public static void setCharacterDirectionsFalse()
    {
        for(int i = 0; i < characterDirection.Length; i++)
        {
            characterDirection[i] = false;
        }
    }

    // Use this for initialization
    void Start()
    {
        characterDirection = new bool[4];
        Time.timeScale = 1.0f;
        anim = GetComponent<Animator>();
        playerrigidbody = GetComponent<Rigidbody2D>();
        if (!playerExists)
        {
            playerExists = true;
            //DontDestroyOnLoad (transform.gameObject);
        }
        else
        {

            //Destroy (gameObject);
        }
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerMoving = false;
        if (!canMove)
        {
            playerrigidbody.velocity = Vector2.zero;
            return;

        }
        if (!attacking)
        {
            if (CnInputManager.GetAxisRaw("Horizontal") > 0.5f || CnInputManager.GetAxisRaw("Horizontal") < -0.5f)
            {
                playerMoving = true;
                //transform.Translate (new Vector3 (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
                playerrigidbody.velocity = new Vector2(CnInputManager.GetAxisRaw("Horizontal") * currentMoveSpeed, playerrigidbody.velocity.y);
                lastmove = new Vector2(CnInputManager.GetAxisRaw("Horizontal"), 0);
                if(CnInputManager.GetAxisRaw("Horizontal") > 0.5f)
                {
                    setCharacterDirectionsFalse();
                    characterDirection[1] = true;
                }
                else
                {
                    setCharacterDirectionsFalse();
                    characterDirection[3] = true;
                }
            }

            if (CnInputManager.GetAxisRaw("Vertical") > 0.5f || CnInputManager.GetAxisRaw("Vertical") < -0.5f)
            {
                playerMoving = true;
                //transform.Translate (new Vector3 (0f,Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,0f));
                playerrigidbody.velocity = new Vector2(playerrigidbody.velocity.x, CnInputManager.GetAxisRaw("Vertical") * currentMoveSpeed);
                lastmove = new Vector2(0, CnInputManager.GetAxisRaw("Vertical"));
                if (CnInputManager.GetAxisRaw("Vertical") > 0.5f)
                {
                    setCharacterDirectionsFalse();
                    characterDirection[0] = true;
                }

                else
                {
                    setCharacterDirectionsFalse();
                    characterDirection[2] = true;
                }
            }

            if (CnInputManager.GetAxisRaw("Horizontal") < 0.5f && CnInputManager.GetAxisRaw("Horizontal") > -0.5f)
            {
                playerrigidbody.velocity = new Vector2(0f, playerrigidbody.velocity.y);
            }
            if (CnInputManager.GetAxisRaw("Vertical") < 0.5f && CnInputManager.GetAxisRaw("Vertical") > -0.5f)
            {
                playerrigidbody.velocity = new Vector2(playerrigidbody.velocity.x, 0f);
            }
            if (!PlayerController.isTalking)
                if (CnInputManager.GetButtonDown("Jump"))
                {
                    attackTimeC = attackTime;
                    attacking = true;
                    //playerrigidbody.velocity = Vector2.zero;
                    anim.SetBool("Attacking", true);
                    //weapon.SetActive(true);

				GameObject cpuWithDirection = RangeWeapon[0];

                    

                    for (int i = 0; i < characterDirection.Length; i++)
                    {
                        if (characterDirection[i])
                        {
                            cpuWithDirection = RangeWeapon  [i];
                            break;
                        }
                    }

                    GameObject rangeWeapon = GameObject.Instantiate(cpuWithDirection,this.gameObject.transform);
                   // rangeWeapon.transform.parent = null;

                }
            if (CnInputManager.GetButtonDown("Cancel"))
            {
                //Application.Quit ();
            }
            if (Mathf.Abs(CnInputManager.GetAxisRaw("Horizontal")) > 0.5f && Mathf.Abs(CnInputManager.GetAxisRaw("Vertical")) > 0.5f)
            {
                currentMoveSpeed = moveSpeed / 2 * diagonalMoveModifier;
            }
            else
            {
                currentMoveSpeed = moveSpeed;
            }
			float knockBackSpeed = 15.0f;
			if (isKnockBack) {
				if (characterDirection [0]) {
					playerrigidbody.velocity = new Vector2 (0.0f, -knockBackSpeed);
				}
				if (characterDirection [1]) {
					playerrigidbody.velocity = new Vector2 (-knockBackSpeed, 0.0f);
				}
				if (characterDirection [2]) {
					playerrigidbody.velocity = new Vector2 (0.0f, knockBackSpeed);
				}
				if (characterDirection [3]) {
					playerrigidbody.velocity = new Vector2 (knockBackSpeed, 0.0f);
				}

				Invoke ("FinishKnockBack",0.05f);
			}
        }
        if (attackTimeC > 0)
        {
            attackTimeC -= Time.deltaTime;
        }
        if (attackTimeC <= 0)
        {
            attacking = false;
            anim.SetBool("Attacking", false);
            weapon.SetActive(false);
        }
        anim.SetFloat("MoveX", CnInputManager.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", CnInputManager.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastmove.x);
        anim.SetFloat("LastMoveY", lastmove.y);
    }

	bool isKnockBack = false;
	public void FinishKnockBack(){
		isKnockBack = false;
	}

	public void StartKnockBack(){
		isKnockBack = true;
	}
}
