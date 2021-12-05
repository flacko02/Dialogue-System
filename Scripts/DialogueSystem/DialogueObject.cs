using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")] // automatiski Unity, kad vēlies sataisīt dialogu objektu, uz labas peles pogas vinam atveras opcija
public class DialogueObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue; // iekšā Unity var pievienot vairākus dialogus, un izveleties tos
    [SerializeField] private Response[] responses; // Atbildes dialogam

    public string[] Dialogue => dialogue;

    public bool HasResponses => Responses != null && Responses.Length > 0;

    public Response[] Responses => responses;
}
