using UnityEngine;
using UnityEngine.UI;

public class UpperInfoPanel : MonoBehaviour
{
    [SerializeField]
    private Text _rank;
    [SerializeField]
    private Text _playerName;
    [SerializeField]
    private Text _bp;
    [SerializeField]
    private Text _winRatio;
    [SerializeField]
    private Text _wlRatio;
    [SerializeField]
    private Text _exp;
    [SerializeField]
    private Text _brickPoints;

    private void Start()
    {
        DisableAllUpperInfoPanel();
        EnableBP();
    }

    public void DisableAllUpperInfoPanel()
    {
        _bp.gameObject.SetActive(false);
        _winRatio.gameObject.SetActive(false);
        _wlRatio.gameObject.SetActive(false);
        _exp.gameObject.SetActive(false);
        _brickPoints.gameObject.SetActive(false);
    }
    public void EnableBP()
    {
        _bp.gameObject.SetActive(true);
    }
    public void EnableWLRatio()
    {
        _winRatio.gameObject.SetActive(true);
        _wlRatio.gameObject.SetActive(true);
    }
    public void EnableExp()
    {
        _exp.gameObject.SetActive(true);
    }
    public void EnableBrickPoints()
    {
        _brickPoints.gameObject.SetActive(true);
    }
}
