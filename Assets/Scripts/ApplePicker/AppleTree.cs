using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTree : MonoBehaviour
{
    [SerializeField] private GameObject ApplePrefab;
    [SerializeField] private GameObject AppleSpawnerLeft;
    [SerializeField] private GameObject AppleSpawnerRight;
    [SerializeField] private GameObject GoldenApplePrefab;
    [SerializeField] private GameObject DeadBirdPrefab;
    [SerializeField] private float _treeSpeedMin = 3f;
    [SerializeField] private float _treeMoveRandom = 0.02f;
    [SerializeField] private float _leftAndRignEdge = 8f;
    [SerializeField] private float _secondsBetweenAppleDrops = 1f;
    private bool _spavnerSelect = true;
    private Vector3 _appleSpawnerPosition;
    [SerializeField] private float _scoreDetector;
    [SerializeField] private float _treeSpeed;
    [SerializeField] private float _speedDelta = 40f;
    private int _startGoldenAppleDrop;
    private int _startDeadBirdDrop;
    

    void Start()
    {

        _startGoldenAppleDrop = Random.Range(10, 15); // поправить позже *10
        _startDeadBirdDrop = Random.Range(15, 20); // поправить позже *10
                
        Invoke(nameof(DropApple), 2f);
        Invoke(nameof(DropGoldenApple), _startGoldenAppleDrop);
        Invoke(nameof(DropDeadBird), _startDeadBirdDrop);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 scale = transform.localScale;
        pos.x += _treeSpeed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -_leftAndRignEdge)
        {
            _treeSpeed = Mathf.Abs(Random.Range(_treeSpeedMin, (_treeSpeedMin + Basket.AppleScore / _speedDelta)));            
        }
        else if (pos.x > _leftAndRignEdge)
        {
            _treeSpeed = -Mathf.Abs(Random.Range(_treeSpeedMin, (_treeSpeedMin + Basket.AppleScore / _speedDelta)));            
        }
        
        if (_treeSpeed < 0)
        {
            scale.x = -1;
            transform.localScale = scale;
        }
        else
        {
            scale.x = 1;
            transform.localScale = scale;
        }
        _spavnerSelect = Random.value > 0.5f; // —лучайный выбор спавнера €блок
        if (_spavnerSelect)
        {
            _appleSpawnerPosition = AppleSpawnerRight.transform.position;
        }
        else
        {
            _appleSpawnerPosition = AppleSpawnerLeft.transform.position;
        }

    }
    private void FixedUpdate()  // —лучайное изменение направлени€ движени€ дерева
    {
       
        if (_treeMoveRandom > Random.value) 
        {
            _treeSpeed = Random.Range(_treeSpeedMin, (_treeSpeedMin + Basket.AppleScore / _speedDelta)) * - 1;
        }


    }
    private void DropApple() // ‘ункци€ создани€ €блок
    {
        GameObject apple = Instantiate<GameObject>(ApplePrefab);
        apple.transform.position = _appleSpawnerPosition;
        float a = 1f;
        // ”величение скорости спавнв €блок
        _scoreDetector = Basket.AppleScore;
        if ((_secondsBetweenAppleDrops - _scoreDetector / 100) > 0.7f) {a = _secondsBetweenAppleDrops - _scoreDetector / 1000; }
        else { a = 0.3f; }
        Invoke(nameof(DropApple), Random.Range(_secondsBetweenAppleDrops, a)); 
    }

    private void DropGoldenApple() // ‘ункци€ создани€ золотых €блок
    {
        GameObject goldenApple = Instantiate<GameObject>(GoldenApplePrefab);
        goldenApple.transform.position = _appleSpawnerPosition;
        int a = Random.Range(10, 30);
        Invoke(nameof(DropGoldenApple), a);
    }

    private void DropDeadBird() // ‘ункци€ создани€ мертвых птиц
    {
        GameObject deadBird = Instantiate<GameObject>(DeadBirdPrefab);
        deadBird.transform.position = _appleSpawnerPosition;
        int a = Random.Range(10, 30);
        Invoke(nameof(DropDeadBird), a);
    }






}
