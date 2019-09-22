using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Vuforia;

public class lang_btn : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject LangButton;
    public GameObject TitleOne, TextOne, TitleTwo, TextTwo, InfoBtnText, InfoPages, InfoPub, InfoGenre;
    private TextMesh Pub, Pages, Genre, Info;
    private TextMeshPro One, OneText, Two, TwoText;
    private bool IsSpanish = true;

    // Start is called before the first frame update
    void Start()
    {
        Pub = InfoPub.GetComponent<TextMesh>();
        Pages = InfoPages.GetComponent<TextMesh>();
        Genre = InfoGenre.GetComponent<TextMesh>();
        Info = InfoBtnText.GetComponent<TextMesh>();
        One = TitleOne.GetComponent<TextMeshPro>();
        Two = TitleTwo.GetComponent<TextMeshPro>();
        OneText = TextOne.GetComponent<TextMeshPro>();
        TwoText = TextTwo.GetComponent<TextMeshPro>();
        LangButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Redraw();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Lang pressed");
        IsSpanish = !IsSpanish;
        Redraw();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    private string
    title_1_spanish = "Novela clasica",
    title_1_english = "Classic Novel",
    text_1_spanish = "La historia contada por Bradbury en esta novela es increíble y la recomendaría encarecidamente al lector novato. ¡Te enseñará a cuestionar la razón detrás de todo lo que hace “Gran Hermano” y realmente pensar en el papel que juega la tecnología en nuestras vidas!",
    text_1_english = "The story told by Bradbury in this novel is incredible and I would highly recommend it to the novice reader. It will teach you to question the reason behind everything “Big Brother” does and really think about the role that technology plays in our lives!",
    title_2_spanish = "Prohibir este libro",
    title_2_english = "Ban This Book",
    text_2_spanish = "Desde que mi hijo leyó este libro, ha estado encogido en su habitación por miedo a salir. Él dice que \"los bomberos vienen a lastimarlo\". ¡Este libro hace que los niños desconfíen de la autoridad y debería ser prohibido permanentemente en todas las librerías!",
    text_2_english = "Ever since my child read this book, he has been cowering in his room afraid of going outside. He says the “firemen are coming to hurt him.” This book makes children distrust authority and should be permanently banned from all bookstores!",
    info_spanish = "",
    info_english = "",
    info_btn_text_spanish = "info",
    info_btn_text_english = "info",
    info_pages_english = "253 Pages",
    info_pages_spanish = "253 Páginas",
    info_pub_english = "Pub: 1953",
    info_pub_spanish = "Pub: 1953",
    info_genre_english = "Science Fiction",
    info_genre_spanish = "Ciencia ficción"
    ;

    private void Redraw() {
        if (IsSpanish)
        {
            Debug.Log("HERE:" + Pub.text);
            Debug.Log("Spanish");
            Pub.text = info_pub_spanish;
            Pages.text = info_pages_spanish;
            Genre.text = info_genre_spanish;
            Info.text = info_btn_text_spanish;
            One.text = title_1_spanish;
            OneText.text = text_1_spanish;
            Two.text = title_2_spanish;
            TwoText.text = text_2_spanish;
        }
        else {
            Debug.Log("English");
            Pub.text = info_pub_english;
            Pages.text = info_pages_english;
            Genre.text = info_genre_english;
            Info.text = info_btn_text_english;
            One.text = title_1_english;
            OneText.text = text_1_english;
            Two.text = title_2_english;
            TwoText.text = text_2_english;
        }
    }

    
}
