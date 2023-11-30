using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour
{
    private Weapon weapon;
    private Animator animator;
    private Rigidbody2D rigidbody2D;
    private Material originMaterial;
    private SpriteRenderer spriteRenderer;

    [SerializeField] int weaponCount;
    [SerializeField] Vector2 direction;
    [SerializeField] float speed = 250;
    [SerializeField] float health = 100;
    
    [SerializeField] Material flashMaterial;
    [SerializeField] List<Weapon> weaponList;

    private WaitForSeconds waitForSeconds = new WaitForSeconds(0.125f);

    void Start()
    {
        animator = GetComponent<Animator>();    
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        originMaterial = spriteRenderer.material;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        // ���� ��ü �Լ�
        ChangeWeapon();
    }

    private void FixedUpdate()
    {
        // �̵� ���� �Լ�
        Move();
        
        // ���� ��ȯ �Լ�
        State();
    }

    public void ChangeWeapon()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (weaponCount == weaponList.Count - 1)
            {
                weaponCount = 0;
            }

            weapon = weaponList[++weaponCount];

            weapon.Attack();
        }        
    }

    public void OnHit(float damage)
    {
        health -= damage;

        StartCoroutine(Flash());

        if (health < 0 ) 
        {
            Debug.Log("Death");
        }
    }

    public void Move()
    {
        rigidbody2D.velocity = direction.normalized * speed * Time.fixedDeltaTime; 
    }

    public void State()
    {
        if(rigidbody2D.velocity == Vector2.zero)
        {
            animator.SetBool("Walk", false);
        }
        else
        {
            InvertImage();

            animator.SetBool("Walk", true);
        }
    }

    public void InvertImage()
    {
        if(direction.x > 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(direction.x < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    // �ڷ�ƾ �Լ� Flash
    public IEnumerator Flash()
    {
        spriteRenderer.material = flashMaterial;

        yield return waitForSeconds;

        spriteRenderer.material = originMaterial;
    }
}
