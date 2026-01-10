using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5;
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        PlantCountUI _targetscript = _plantCountUI;
        _targetscript.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _numSeeds > 0)
        {
            PlantSeed();
            _numSeedsLeft = _numSeeds;
            _numSeedsPlanted += 1;
            PlantCountUI _targetscript = _plantCountUI;
            _targetscript.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }

        _playerTransform.Translate(Input.GetAxis("Horizontal") * _speed, 0f, 0f);
        _playerTransform.Translate(0f, Input.GetAxis("Vertical") * _speed, 0f);
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _numSeeds -= 1;
    }
}
