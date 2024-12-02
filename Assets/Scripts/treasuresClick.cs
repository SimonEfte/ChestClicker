using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class treasuresClick : MonoBehaviour
{
    public GameObject treasuresBar;
    public GameObject skullIcon;
    public GameObject swordIcon;
    public GameObject ringIcon;
    public GameObject throphyIcon;
    public GameObject starIcon;
    public GameObject cloverIcon;
    public GameObject crownIcon;
    public GameObject bookIcon;
    public GameObject guitarIcon;
    public GameObject talariaIcon;
    public GameObject runeIcon;
    public GameObject backPackIcon;
    public GameObject shieldIcon;
    public GameObject pillBottleIcon;
    public GameObject medalIcon;
    public GameObject cookieIcon;
    public GameObject presentIcon;
    public GameObject axeIcon;
    public GameObject coin100XIcon;
    public GameObject envelopeIcon;
    public GameObject potionIcon;
    public GameObject souldGemIcon;
    public GameObject scrollIcon;
    public GameObject brickIcon;
    public GameObject chickenIcon;
    public TextMeshProUGUI treasureText;

    public GameObject skullPopUp, swordPopUp, ringPopUp, trophyPopUp, starPopUp, cloverPopUp, crownPopUp, bookPopUp, guitarPopUp, talariaPopUp, runePopUp, backPackPopUp, shieldPopUp, pillBottlePopUp, medalPopUp, cookiePopUp, presentPopUp, axePopUp, coin100XPopUp, envelopePopUp, potionPopUp, soulGemPopUp, scrollPopUp, brickPopUp, chickenPopUp;

    public static float waitTime1, waittime2;

    public static bool clickedARareTreasure;

    private void Start()
    {
        waitTime1 = 2f; waittime2 = 0.65f;
        gameObject.GetComponent<Image>();
    }

    public void ClickOnTreasure()
    {
        if (gameObject != null && gameObject.name == "Skull")
        {
            StartCoroutine(ClickedSkull()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Trophy")
        {
            StartCoroutine(ClickedThrophy()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Sword")
        {
            StartCoroutine(ClickedSword()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Ring")
        {
            StartCoroutine(ClickedRing()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Star")
        {
            StartCoroutine(ClickedStar()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Clover")
        {
            StartCoroutine(ClickedClover()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Crown")
        {
            StartCoroutine(ClickedCrown()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Book")
        {
            StartCoroutine(ClickedBook()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Guitar")
        {
            StartCoroutine(ClickedGuitar()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Talarian")
        {
            StartCoroutine(ClickedTalarian()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Rune")
        {
            StartCoroutine(ClickedRune()); SetColor();
        }
        if (gameObject != null && gameObject.name == "BackPack")
        {
            StartCoroutine(ClickedBackPack()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Shield")
        {
            StartCoroutine(ClickedShield()); SetColor();
        }
        if (gameObject != null && gameObject.name == "PillBottle")
        {
            StartCoroutine(ClickedPillBottle()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Medal")
        {
            StartCoroutine(ClickedMedal()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Cookie")
        {
            StartCoroutine(ClickedCookie()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Present")
        {
            StartCoroutine(ClickedPresent()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Axe")
        {
            StartCoroutine(ClickedAxe()); SetColor();
        }
        if (gameObject != null && gameObject.name == "100XCoin")
        {
            StartCoroutine(ClickedCoin100X()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Envelope")
        {
            StartCoroutine(ClickedEnvelope()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Potion")
        {
            StartCoroutine(ClickedPotion()); SetColor();
        }
        if (gameObject != null && gameObject.name == "SoulGem")
        {
            StartCoroutine(ClickedSoulGem()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Scroll")
        {
            StartCoroutine(ClickedScroll()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Brick")
        {
            StartCoroutine(ClickedBrick()); SetColor();
        }
        if (gameObject != null && gameObject.name == "Chicken")
        {
            StartCoroutine(ClickedChicken()); SetColor();
        }
    }

    public void SetColor()
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        gameObject.GetComponent<Button>().interactable = false;
        Color newColor = gameObject.GetComponent<Image>().color; newColor.a = 0f;
        gameObject.GetComponent<Image>().color = newColor;
        gameObject.GetComponent<Image>().raycastTarget = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
    }

    #region skull
    IEnumerator ClickedSkull()
    {
        TreasureSoundEffect();
        skullIcon.transform.localPosition = new Vector2(0,-18f);
        skullIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        skullIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_SKULL;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if(PlaceMobileButtons.isMobile == false) { skullIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { skullIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }
        yield return new WaitForSeconds(waittime2);
        skullIcon.SetActive(false);
        gameObject.SetActive(false);

        skullPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotSkull = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region trophy
    IEnumerator ClickedThrophy()
    {
        TreasureSoundEffect();
        throphyIcon.transform.localPosition = new Vector2(0, -18f);
        throphyIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        throphyIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_TROPHY;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { throphyIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { throphyIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        throphyIcon.SetActive(false);
        gameObject.SetActive(false);

        trophyPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotTrophy = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region sword
    IEnumerator ClickedSword()
    {
        TreasureSoundEffect();
        swordIcon.transform.localPosition = new Vector2(0, -18f);
        swordIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        swordIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_DEMONIC_SWORD;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();
        if (PlaceMobileButtons.isMobile == false) { swordIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { swordIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }
        yield return new WaitForSeconds(waittime2);
        swordIcon.SetActive(false);
        gameObject.SetActive(false);

        swordPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotSword = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region ring
    IEnumerator ClickedRing()
    {
        TreasureSoundEffect();
        ringIcon.transform.localPosition = new Vector2(0, -18f);
        ringIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        ringIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_RING;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();
        if (PlaceMobileButtons.isMobile == false) { ringIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { ringIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }
        yield return new WaitForSeconds(waittime2);
        ringIcon.SetActive(false);
        gameObject.SetActive(false);

        ringPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotRing = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region star
    IEnumerator ClickedStar()
    {
        TreasureSoundEffect();
        starIcon.transform.localPosition = new Vector2(0, -18f);
        starIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        starIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_STAR;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { starIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { starIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        starIcon.SetActive(false);
        gameObject.SetActive(false);

        starPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotStar = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region clover
    IEnumerator ClickedClover()
    {
        TreasureSoundEffect();
        cloverIcon.transform.localPosition = new Vector2(0, -18f);
        cloverIcon.transform.localScale = new Vector2(2.072227f, 2.072227f);
        cloverIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_CLOVER;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { cloverIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { cloverIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        cloverIcon.SetActive(false);
        gameObject.SetActive(false);

        cloverPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotClover = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region crown
    IEnumerator ClickedCrown()
    {
        TreasureSoundEffect();
        crownIcon.transform.localPosition = new Vector2(0, -25f);
        crownIcon.transform.localScale = new Vector2(2.739123f, 2.739123f);
        crownIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_KINGS_CROWN;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { crownIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { crownIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        crownIcon.SetActive(false);
        gameObject.SetActive(false);

        crownPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotCrown = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region book
    IEnumerator ClickedBook()
    {
        TreasureSoundEffect();
        bookIcon.transform.localPosition = new Vector2(0, -17f);
        bookIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        bookIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_BOOK;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { bookIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { bookIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        bookIcon.SetActive(false);
        gameObject.SetActive(false);

        bookPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotBook = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region guitar
    IEnumerator ClickedGuitar()
    {
        TreasureSoundEffect();
        guitarIcon.transform.localPosition = new Vector2(0, -17f);
        guitarIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        guitarIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_GUITAR;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { guitarIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { guitarIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        guitarIcon.SetActive(false);
        gameObject.SetActive(false);

        guitarPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotGuitar = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region talarian
    IEnumerator ClickedTalarian()
    {
        TreasureSoundEffect();
        talariaIcon.transform.localPosition = new Vector2(0, -17f);
        talariaIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        talariaIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_TALARIAN;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { talariaIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { talariaIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        talariaIcon.SetActive(false);
        gameObject.SetActive(false);

        talariaPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotTalarian = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region rune
    IEnumerator ClickedRune()
    {
        TreasureSoundEffect();
        runeIcon.transform.localPosition = new Vector2(0, -17f);
        runeIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        runeIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_STRANGE_RUNE;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { runeIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { runeIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        runeIcon.SetActive(false);
        gameObject.SetActive(false);

        runePopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotRune = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region backpack
    IEnumerator ClickedBackPack()
    {
        TreasureSoundEffect();
        backPackIcon.transform.localPosition = new Vector2(0, -17f);
        backPackIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        backPackIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_BACKPACK;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { backPackIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { backPackIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        backPackIcon.SetActive(false);
        gameObject.SetActive(false);

        backPackPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotBackPack = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region shield
    IEnumerator ClickedShield()
    {
        TreasureSoundEffect();
        shieldIcon.transform.localPosition = new Vector2(0, -17f);
        shieldIcon.transform.localScale = new Vector2(2.061217f, 2.061217f);
        shieldIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_SHIELD;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { shieldIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { shieldIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        shieldIcon.SetActive(false);
        gameObject.SetActive(false);

        shieldPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotShield = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region pills
    IEnumerator ClickedPillBottle()
    {
        TreasureSoundEffect();
        pillBottleIcon.transform.localPosition = new Vector2(0, -17f);
        pillBottleIcon.transform.localScale = new Vector2(1.814087f, 1.814087f);
        pillBottleIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_PILL_BOTTLE;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { pillBottleIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { pillBottleIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        pillBottleIcon.SetActive(false);
        gameObject.SetActive(false);

        pillBottlePopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotPillBottle = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region medal
    IEnumerator ClickedMedal()
    {
        TreasureSoundEffect();
        medalIcon.transform.localPosition = new Vector2(0, -17f);
        medalIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        medalIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_MEDAL;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { medalIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { medalIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        medalIcon.SetActive(false);
        gameObject.SetActive(false);

        medalPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotMedal = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region cookie
    IEnumerator ClickedCookie()
    {
        TreasureSoundEffect();
        cookieIcon.transform.localPosition = new Vector2(0, -17f);
        cookieIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        cookieIcon.SetActive(true); treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_COOKIE;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { cookieIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { cookieIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        cookieIcon.SetActive(false);
        gameObject.SetActive(false);

        cookiePopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotCookie = true; exPopUpPreviousPage.SetActive(true);
    }
    #endregion

    #region Present
    IEnumerator ClickedPresent()
    {
        TreasureSoundEffect();
        presentIcon.transform.localPosition = new Vector2(0, -17f);
        presentIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        presentIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_CHRISTMAS_PRESENT;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { presentIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { presentIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        presentIcon.SetActive(false);
        gameObject.SetActive(false);

        presentPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotPresent = true;
        exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region Axe
    IEnumerator ClickedAxe()
    {
        TreasureSoundEffect();
        axeIcon.transform.localPosition = new Vector2(0, -17f);
        axeIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        axeIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_BATTLE_AXE;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { axeIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { axeIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        axeIcon.SetActive(false);
        gameObject.SetActive(false);

        axePopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotAxe = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region coin100X
    IEnumerator ClickedCoin100X()
    {
        TreasureSoundEffect();
        coin100XIcon.transform.localPosition = new Vector2(0, -17f);
        coin100XIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        coin100XIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_100X_GOLD_COIN;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { coin100XIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { coin100XIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        coin100XIcon.SetActive(false);
        gameObject.SetActive(false);

        coin100XPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.got100X = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region envelope
    IEnumerator ClickedEnvelope()
    {
        TreasureSoundEffect();
        envelopeIcon.transform.localPosition = new Vector2(0, -17f);
        envelopeIcon.transform.localScale = new Vector2(2.054635f, 2.054635f);
        envelopeIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_SEALED_ENVELOPE;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { envelopeIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { envelopeIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        envelopeIcon.SetActive(false);
        gameObject.SetActive(false);

        envelopePopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotEnvelope = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region potion
    IEnumerator ClickedPotion()
    {
        TreasureSoundEffect();
        potionIcon.transform.localPosition = new Vector2(0, -17f);
        potionIcon.transform.localScale = new Vector2(1.706918f, 1.706918f);
        potionIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_STRANGE_POTION;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { potionIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { potionIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        potionIcon.SetActive(false);
        gameObject.SetActive(false);

        potionPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotPotion = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region soulGem
    IEnumerator ClickedSoulGem()
    {
        TreasureSoundEffect();
        souldGemIcon.transform.localPosition = new Vector2(0, -17f);
        souldGemIcon.transform.localScale = new Vector2(1.706918f, 1.706918f);
        souldGemIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_SOUL_GEM;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { souldGemIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { souldGemIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        souldGemIcon.SetActive(false);
        gameObject.SetActive(false);

        soulGemPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotSoulGem = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region scroll
    IEnumerator ClickedScroll()
    {
        TreasureSoundEffect();
        scrollIcon.transform.localPosition = new Vector2(0, -17f);
        scrollIcon.transform.localScale = new Vector2(2.173478f, 2.173478f);
        scrollIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_AN_ANCIENT_SCROLL;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { scrollIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { scrollIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        scrollIcon.SetActive(false);
        gameObject.SetActive(false);

        scrollPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotScroll = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region brick
    IEnumerator ClickedBrick()
    {
        TreasureSoundEffect();
        brickIcon.transform.localPosition = new Vector2(0, -17f);
        brickIcon.transform.localScale = new Vector2(2.173478f, 2.173478f);
        brickIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_BRICK;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { brickIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { brickIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        brickIcon.SetActive(false);
        gameObject.SetActive(false);

        brickPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotBrick = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    #region chicken
    IEnumerator ClickedChicken()
    {
        TreasureSoundEffect();
        chickenIcon.transform.localPosition = new Vector2(0, -17f);
        chickenIcon.transform.localScale = new Vector2(2.173478f, 2.173478f);
        chickenIcon.SetActive(true);
        treasuresBar.SetActive(true);
        treasureText.text = Localization.YOU_FOUND_A_RUBBER_CHICKEN;

        yield return new WaitForSeconds(waitTime1);
        treasuresBar.SetActive(false);
        SwoshSound();

        if (PlaceMobileButtons.isMobile == false) { chickenIcon.GetComponent<Animation>().Play("treasuresAnimation"); }
        else { chickenIcon.GetComponent<Animation>().Play("TreasureAnimMobile"); }

        yield return new WaitForSeconds(waittime2);
        chickenIcon.SetActive(false);
        gameObject.SetActive(false);

        chickenPopUp.SetActive(true);
        SetExPopUp();

        clickedARareTreasure = true;
        RareTreasures.gotChicken = true; exPopUpNextPage.SetActive(true);
    }
    #endregion

    public GameObject exPopUp, exPopUpNextPage, exPopUpPreviousPage;

    public void SetExPopUp()
    {
        exPopUp.SetActive(true);
    }

    public void SwoshSound()
    {
        if (AudioManager.audioMuted == 1) { FindObjectOfType<AudioManager>().Play("PrestigeAnimSound"); }
    }

    public void TreasureSoundEffect()
    {
        Stats.rareTreasuresFound += 1;
        //Debug.Log(Stats.rareTreasuresFound);

        if (AudioManager.audioMuted == 1)
        {
            int random = Random.Range(1, 3);
            if (random == 1) { FindObjectOfType<AudioManager>().Play("RareTreasureSound1"); }
            if (random == 2) { FindObjectOfType<AudioManager>().Play("RareTreasureSound2"); }
        }
    }

}
