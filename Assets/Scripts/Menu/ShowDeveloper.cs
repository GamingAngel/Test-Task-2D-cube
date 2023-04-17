using UnityEngine;
public class ShowDeveloper : MonoBehaviour
{
    [SerializeField] private GameObject developer_Text;
    public void OnShow() => developer_Text.SetActive(!developer_Text.activeSelf);

}
