using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    // Career Options
    private int careerOption01;
    private int careerOption02;
    private int careerOption03;
    private int careerOption04;
    private int careerOption05;

    // Options
    // Options - Questions
    // Options - Questions - Main Questions
    // Options - Questions - Main Questions - Question 01
    private GameObject q01Option01;
    private GameObject q01Option02;
    private GameObject q01Option03;
    private GameObject q01Option04;
    private GameObject q01Option05;
    // Options - Questions - Main Questions - Question 02
    private GameObject q02Option01;
    private GameObject q02Option02;
    private GameObject q02Option03;
    private GameObject q02Option04;
    private GameObject q02Option05;
    // Options - Questions - Main questions - Question 03
    private GameObject q03Option01;
    private GameObject q03Option02;
    private GameObject q03Option03;
    private GameObject q03Option04;
    private GameObject q03Option05;
    // Options - Questions - Main Questions - Question 04
    private GameObject q04Option01;
    private GameObject q04Option02;
    private GameObject q04Option03;
    private GameObject q04Option04;
    private GameObject q04Option05;
    // Options - Questions - Main Questions - Question 05
    private GameObject q05Option01;
    private GameObject q05Option02;
    private GameObject q05Option03;
    private GameObject q05Option04;
    private GameObject q05Option05;
    // Options - Questions - Main Questions - Question 06
    private GameObject q06Option01;
    private GameObject q06Option02;
    private GameObject q06Option03;
    private GameObject q06Option04;
    private GameObject q06Option05;
    // Options - Questions - Main Questions - Question 07
    private GameObject q07Option01;
    private GameObject q07Option02;
    private GameObject q07Option03;
    private GameObject q07Option04;
    private GameObject q07Option05;
    // Options - Questions - Main Questions - Question 08
    private GameObject q08Option01;
    private GameObject q08Option02;
    private GameObject q08Option03;
    private GameObject q08Option04;
    private GameObject q08Option05;
    // Options - Questions - Main Questions - Question 09
    private GameObject q09Option01;
    private GameObject q09Option02;
    private GameObject q09Option03;
    private GameObject q09Option04;
    private GameObject q09Option05;
    // Options - Questions - Main Questions - Question 10
    private GameObject q10Option01;
    private GameObject q10Option02;
    private GameObject q10Option03;
    private GameObject q10Option04;
    private GameObject q10Option05;
    // Options - Questions - Main Questions - Question 11
    private GameObject q11Option01;
    private GameObject q11Option02;
    private GameObject q11Option03;
    private GameObject q11Option04;
    private GameObject q11Option05;
    // Options - Questions - Main Questions - Question 12
    private GameObject q12Option01;
    private GameObject q12Option02;
    private GameObject q12Option03;
    private GameObject q12Option04;
    private GameObject q12Option05;
    // Options - Questions - Main Questions - Question 13
    private GameObject q13Option01;
    private GameObject q13Option02;
    private GameObject q13Option03;
    private GameObject q13Option04;
    private GameObject q13Option05;
    // Options - Questions - Main Questions - Question 14
    private GameObject q14Option01;
    private GameObject q14Option02;
    private GameObject q14Option03;
    private GameObject q14Option04;
    private GameObject q14Option05;
    // Options - Questions - Main Questions - Question 15
    private GameObject q15Option01;
    private GameObject q15Option02;
    private GameObject q15Option03;
    private GameObject q15Option04;
    private GameObject q15Option05;
    // Options - Questions - Bonus Questions
    // Options - Questions - Bonus Questions - Question 01
    private GameObject qB01Option01;
    private GameObject qB01Option02;
    private GameObject qB01Option03;
    private GameObject qB01Option04;
    private GameObject qB01Option05;
    // Options - Questions - Bonus Questions - Question 02
    private GameObject qB02Option01;
    private GameObject qB02Option02;
    private GameObject qB02Option03;
    private GameObject qB02Option04;
    private GameObject qB02Option05;
    // Options - Questions - Bonus Questions - Question 03
    private GameObject qB03Option01;
    private GameObject qB03Option02;
    private GameObject qB03Option03;
    private GameObject qB03Option04;
    private GameObject qB03Option05;
    // Options - Questions - Bonus Questions - Question 04
    private GameObject qB04Option01;
    private GameObject qB04Option02;
    private GameObject qB04Option03;
    private GameObject qB04Option04;
    private GameObject qB04Option05;
    // Options - Questions - Bonus Questions - Question 05
    private GameObject qB05Option01;
    private GameObject qB05Option02;
    private GameObject qB05Option03;
    private GameObject qB05Option04;
    private GameObject qB05Option05;


    // Screens
    // Screens - Start Game
    private GameObject startGameScreen;
    // Screens - Questions
    // Screens - Questions - Main Questions
    private GameObject question01Screen;
    private GameObject question02Screen;
    private GameObject question03Screen;
    private GameObject question04Screen;
    private GameObject question05Screen;
    private GameObject question06Screen;
    private GameObject question07Screen;
    private GameObject question08Screen;
    private GameObject question09Screen;
    private GameObject question10Screen;
    private GameObject question11Screen;
    private GameObject question12Screen;
    private GameObject question13Screen;
    private GameObject question14Screen;
    private GameObject question15Screen;
    // Screens - Questions - Bonus Questions
    private GameObject questionB01Screen;
    private GameObject questionB02Screen;
    private GameObject questionB03Screen;
    private GameObject questionB04Screen;
    private GameObject questionB05Screen;
    // Screens - Job Options
    private GameObject careerOption01Screen;
    private GameObject careerOption02Screen;
    private GameObject careerOption03Screen;
    private GameObject careerOption04Screen;
    private GameObject careerOption05Screen;

    // Buttons
    // Buttons - Questions
    // Buttons - Questions - Main Questions
    private GameObject q01NextButton;
    private GameObject q02NextButton;
    private GameObject q03NextButton;
    private GameObject q04NextButton;
    private GameObject q05NextButton;
    private GameObject q06NextButton;
    private GameObject q07NextButton;
    private GameObject q08NextButton;
    private GameObject q09NextButton;
    private GameObject q10NextButton;
    private GameObject q11NextButton;
    private GameObject q12NextButton;
    private GameObject q13NextButton;
    private GameObject q14NextButton;
    private GameObject q15NextButton;
    // Buttons - Questions - Bonus Questions
    private GameObject qB01NextButton;
    private GameObject qB02NextButton;
    private GameObject qB03NextButton;
    private GameObject qB04NextButton;
    private GameObject qB05NextButton;

    // Data
    // Data - Variables
    // Data - Variables - 
    // Data - Variables - Random
    private int questionNumber;
    private int questionsAnswered;
    private int bonusQuestionNumber;
    // Data - Bools
    // Data - Bools - Main Questions
    private bool question01Answered = false;
    private bool question02Answered = false;
    private bool question03Answered = false;
    private bool question04Answered = false;
    private bool question05Answered = false;
    private bool question06Answered = false;
    private bool question07Answered = false;
    private bool question08Answered = false;
    private bool question09Answered = false;
    private bool question10Answered = false;
    private bool question11Answered = false;
    private bool question12Answered = false;
    private bool question13Answered = false;
    private bool question14Answered = false;
    private bool question15Answered = false;
    // Data - Bools - Bonus Questions
    private bool questionB01Answered = false;
    private bool questionB02Answered = false;
    private bool questionB03Answered = false;
    private bool questionB04Answered = false;
    private bool questionB05Answered = false;


    // Start is called before the first frame update
    void Awake()
    {
        // Options
        // Options - Question 01
        q01Option01 = GameObject.Find("Q01Option01");
        q01Option02 = GameObject.Find("Q01Option02");
        q01Option03 = GameObject.Find("Q01Option03");
        q01Option04 = GameObject.Find("Q01Option04");
        q01Option05 = GameObject.Find("Q01Option05");
        // Options - Question 02
        q02Option01 = GameObject.Find("Q02Option01");
        q02Option02 = GameObject.Find("Q02Option02");
        q02Option03 = GameObject.Find("Q02Option03");
        q02Option04 = GameObject.Find("Q02Option04");
        q02Option05 = GameObject.Find("Q02Option05");
        // Options - Question 03
        q03Option01 = GameObject.Find("Q03Option01");
        q03Option02 = GameObject.Find("Q03Option02");
        q03Option03 = GameObject.Find("Q03Option03");
        q03Option04 = GameObject.Find("Q03Option04");
        q03Option05 = GameObject.Find("Q03Option05");
        // Options - Question 04
        q04Option01 = GameObject.Find("Q04Option01");
        q04Option02 = GameObject.Find("Q04Option02");
        q04Option03 = GameObject.Find("Q04Option03");
        q04Option04 = GameObject.Find("Q04Option04");
        q04Option05 = GameObject.Find("Q04Option05");
        // Options - Question 05
        q05Option01 = GameObject.Find("Q05Option01");
        q05Option02 = GameObject.Find("Q05Option02");
        q05Option03 = GameObject.Find("Q05Option03");
        q05Option04 = GameObject.Find("Q05Option04");
        q05Option05 = GameObject.Find("Q05Option05");
        // Options - Question 06
        q06Option01 = GameObject.Find("Q06Option01");
        q06Option02 = GameObject.Find("Q06Option02");
        q06Option03 = GameObject.Find("Q06Option03");
        q06Option04 = GameObject.Find("Q06Option04");
        q06Option05 = GameObject.Find("Q06Option05");
        // Options - Question 07
        q07Option01 = GameObject.Find("Q07Option01");
        q07Option02 = GameObject.Find("Q07Option02");
        q07Option03 = GameObject.Find("Q07Option03");
        q07Option04 = GameObject.Find("Q07Option04");
        q07Option05 = GameObject.Find("Q07Option05");
        // Options - Question 08
        q08Option01 = GameObject.Find("Q08Option01");
        q08Option02 = GameObject.Find("Q08Option02");
        q08Option03 = GameObject.Find("Q08Option03");
        q08Option04 = GameObject.Find("Q08Option04");
        q08Option05 = GameObject.Find("Q08Option05");
        // Options - Question 09
        q09Option01 = GameObject.Find("Q09Option01");
        q09Option02 = GameObject.Find("Q09Option02");
        q09Option03 = GameObject.Find("Q09Option03");
        q09Option04 = GameObject.Find("Q09Option04");
        q09Option05 = GameObject.Find("Q09Option05");
        // Options - Question 10
        q10Option01 = GameObject.Find("Q10Option01");
        q10Option02 = GameObject.Find("Q10Option02");
        q10Option03 = GameObject.Find("Q10Option03");
        q10Option04 = GameObject.Find("Q10Option04");
        q10Option05 = GameObject.Find("Q10Option05");
        // Options - Question 11
        q11Option01 = GameObject.Find("Q11Option01");
        q11Option02 = GameObject.Find("Q11Option02");
        q11Option03 = GameObject.Find("Q11Option03");
        q11Option04 = GameObject.Find("Q11Option04");
        q11Option05 = GameObject.Find("Q11Option05");
        // Options - Question 12
        q12Option01 = GameObject.Find("Q12Option01");
        q12Option02 = GameObject.Find("Q12Option02");
        q12Option03 = GameObject.Find("Q12Option03");
        q12Option04 = GameObject.Find("Q12Option04");
        q12Option05 = GameObject.Find("Q12Option05");
        // Options - Question 13
        q13Option01 = GameObject.Find("Q13Option01");
        q13Option02 = GameObject.Find("Q13Option02");
        q13Option03 = GameObject.Find("Q13Option03");
        q13Option04 = GameObject.Find("Q13Option04");
        q13Option05 = GameObject.Find("Q13Option05");
        // Options - Question 14
        q14Option01 = GameObject.Find("Q14Option01");
        q14Option02 = GameObject.Find("Q14Option02");
        q14Option03 = GameObject.Find("Q14Option03");
        q14Option04 = GameObject.Find("Q14Option04");
        q14Option05 = GameObject.Find("Q14Option05");
        // Options - Question 15
        q15Option01 = GameObject.Find("Q15Option01");
        q15Option02 = GameObject.Find("Q15Option02");
        q15Option03 = GameObject.Find("Q15Option03");
        q15Option04 = GameObject.Find("Q15Option04");
        q15Option05 = GameObject.Find("Q15Option05");
        // Options - Bonus Questions
        // Options - Bonus Questions - Question 01
        qB01Option01 = GameObject.Find("QB01Option01");
        qB01Option02 = GameObject.Find("QB01Option02");
        qB01Option03 = GameObject.Find("QB01Option03");
        qB01Option04 = GameObject.Find("QB01Option04");
        qB01Option05 = GameObject.Find("QB01Option05");
        // Options - Bonus Questions - Question 02
        qB02Option01 = GameObject.Find("QB02Option01");
        qB02Option02 = GameObject.Find("QB02Option02");
        qB02Option03 = GameObject.Find("QB02Option03");
        qB02Option04 = GameObject.Find("QB02Option04");
        qB02Option05 = GameObject.Find("QB02Option05");
        // Options - Bonus Questions - Question 03
        qB03Option01 = GameObject.Find("QB03Option01");
        qB03Option02 = GameObject.Find("QB03Option02");
        qB03Option03 = GameObject.Find("QB03Option03");
        qB03Option04 = GameObject.Find("QB03Option04");
        qB03Option05 = GameObject.Find("QB03Option05");
        // Options - Bonus Questions - Question 04
        qB04Option01 = GameObject.Find("QB04Option01");
        qB04Option02 = GameObject.Find("QB04Option02");
        qB04Option03 = GameObject.Find("QB04Option03");
        qB04Option04 = GameObject.Find("QB04Option04");
        qB04Option05 = GameObject.Find("QB04Option05");
        // Options - Bonus Questions - Question 05
        qB05Option01 = GameObject.Find("QB05Option01");
        qB05Option02 = GameObject.Find("QB05Option02");
        qB05Option03 = GameObject.Find("QB05Option03");
        qB05Option04 = GameObject.Find("QB05Option04");
        qB05Option05 = GameObject.Find("QB05Option05");


        // Screens
        // Screens - Start Game Screen
        startGameScreen = GameObject.Find("StartGameScreen");
        // Screens - Questions
        // Screens - Questions - Main Questions
        question01Screen = GameObject.Find("Question01Screen");
        question02Screen = GameObject.Find("Question02Screen");
        question03Screen = GameObject.Find("Question03Screen");
        question04Screen = GameObject.Find("Question04Screen");
        question05Screen = GameObject.Find("Question05Screen");
        question06Screen = GameObject.Find("Question06Screen");
        question07Screen = GameObject.Find("Question07Screen");
        question08Screen = GameObject.Find("Question08Screen");
        question09Screen = GameObject.Find("Question09Screen");
        question10Screen = GameObject.Find("Question10Screen");
        question11Screen = GameObject.Find("Question11Screen");
        question12Screen = GameObject.Find("Question12Screen");
        question13Screen = GameObject.Find("Question13Screen");
        question14Screen = GameObject.Find("Question14Screen");
        question15Screen = GameObject.Find("Question15Screen");
        // Screens - Questions - Bonus Questions
        questionB01Screen = GameObject.Find("QuestionB01Screen");
        questionB02Screen = GameObject.Find("QuestionB02Screen");
        questionB03Screen = GameObject.Find("QuestionB03Screen");
        questionB04Screen = GameObject.Find("QuestionB04Screen");
        questionB05Screen = GameObject.Find("QuestionB05Screen");
        // Screens - Job Options
        careerOption01Screen = GameObject.Find("CareerOption01Screen");
        careerOption02Screen = GameObject.Find("CareerOption02Screen");
        careerOption03Screen = GameObject.Find("CareerOption03Screen");
        careerOption04Screen = GameObject.Find("CareerOption04Screen");
        careerOption05Screen = GameObject.Find("CareerOption05Screen");

        // Buttons
        // Buttons - Main Questions
        q01NextButton = GameObject.Find("q01NextButton");
        q02NextButton = GameObject.Find("q02NextButton");
        q03NextButton = GameObject.Find("q03NextButton");
        q04NextButton = GameObject.Find("q04NextButton");
        q05NextButton = GameObject.Find("q05NextButton");
        q06NextButton = GameObject.Find("q06NextButton");
        q07NextButton = GameObject.Find("q07NextButton");
        q08NextButton = GameObject.Find("q08NextButton");
        q09NextButton = GameObject.Find("q09NextButton");
        q10NextButton = GameObject.Find("q10NextButton");
        q11NextButton = GameObject.Find("q11NextButton");
        q12NextButton = GameObject.Find("q12NextButton");
        q13NextButton = GameObject.Find("q13NextButton");
        q14NextButton = GameObject.Find("q14NextButton");
        q15NextButton = GameObject.Find("q15NextButton");
        // Buttons - Bonus Questions
        qB01NextButton = GameObject.Find("qB01NextButton");
        qB02NextButton = GameObject.Find("qB02NextButton");
        qB03NextButton = GameObject.Find("qB03NextButton");
        qB04NextButton = GameObject.Find("qB04NextButton");
        qB05NextButton = GameObject.Find("qB05NextButton");
    }

    void Start()
    {
        // Screens
        // Screens - Questions
        // Screens - Questions - Main Questions
        question01Screen.SetActive(false);
        question02Screen.SetActive(false);
        question03Screen.SetActive(false);
        question04Screen.SetActive(false);
        question05Screen.SetActive(false);
        question06Screen.SetActive(false);
        question07Screen.SetActive(false);
        question08Screen.SetActive(false);
        question09Screen.SetActive(false);
        question10Screen.SetActive(false);
        question11Screen.SetActive(false);
        question12Screen.SetActive(false);
        question13Screen.SetActive(false);
        question14Screen.SetActive(false);
        question15Screen.SetActive(false);
        // Screens - Questions - Bonus Questions
        questionB01Screen.SetActive(false);
        questionB02Screen.SetActive(false);
        questionB03Screen.SetActive(false);
        questionB04Screen.SetActive(false);
        questionB05Screen.SetActive(false);
        // Screens - Job Options
        careerOption01Screen.SetActive(false);
        careerOption02Screen.SetActive(false);
        careerOption03Screen.SetActive(false);
        careerOption04Screen.SetActive(false);
        careerOption05Screen.SetActive(false);

        // Buttons
        // Buttons - Main Questions
        q01NextButton.SetActive(false);
        q02NextButton.SetActive(false);
        q03NextButton.SetActive(false);
        q04NextButton.SetActive(false);
        q05NextButton.SetActive(false);
        q06NextButton.SetActive(false);
        q07NextButton.SetActive(false);
        q08NextButton.SetActive(false);
        q09NextButton.SetActive(false);
        q10NextButton.SetActive(false);
        q11NextButton.SetActive(false);
        q12NextButton.SetActive(false);
        q13NextButton.SetActive(false);
        q14NextButton.SetActive(false);
        q15NextButton.SetActive(false);
        // Buttons - Bonus Questions
        qB01NextButton.SetActive(false);
        qB02NextButton.SetActive(false);
        qB03NextButton.SetActive(false);
        qB04NextButton.SetActive(false);
        qB05NextButton.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void StartGame()
    {
        startGameScreen.SetActive(false);
        RandomQuestion01();
    }

    // Question 01
    public void Q01Option01()
    {
        q01Option01.SetActive(true);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        careerOption01 += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option02()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(true);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        careerOption02 += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option03()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(true);
        q01Option04.SetActive(false);
        q01Option05.SetActive(false);

        careerOption03 += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option04()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(true);
        q01Option05.SetActive(false);

        careerOption04 += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Option05()
    {
        q01Option01.SetActive(false);
        q01Option02.SetActive(false);
        q01Option03.SetActive(false);
        q01Option04.SetActive(false);
        q01Option05.SetActive(true);

        careerOption05 += 1;
        q01NextButton.SetActive(true);
    }
    public void Q01Completed()
    {
        question01Screen.SetActive(false);

        question01Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 02
    public void Q02Option01()
    {
        q02Option01.SetActive(true);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        careerOption01 += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option02()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(true);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        careerOption02 += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option03()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(true);
        q02Option04.SetActive(false);
        q02Option05.SetActive(false);

        careerOption03 += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option04()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(true);
        q02Option05.SetActive(false);

        careerOption04 += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Option05()
    {
        q02Option01.SetActive(false);
        q02Option02.SetActive(false);
        q02Option03.SetActive(false);
        q02Option04.SetActive(false);
        q02Option05.SetActive(true);

        careerOption05 += 1;
        q02NextButton.SetActive(true);
    }
    public void Q02Completed()
    {
        question02Screen.SetActive(false);

        question02Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 03
    public void Q03Option01()
    {
        q03Option01.SetActive(true);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        careerOption01 += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option02()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(true);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        careerOption02 += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option03()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(true);
        q03Option04.SetActive(false);
        q03Option05.SetActive(false);

        careerOption03 += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option04()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(true);
        q03Option05.SetActive(false);

        careerOption04 += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Option05()
    {
        q03Option01.SetActive(false);
        q03Option02.SetActive(false);
        q03Option03.SetActive(false);
        q03Option04.SetActive(false);
        q03Option05.SetActive(true);

        careerOption05 += 1;
        q03NextButton.SetActive(true);
    }
    public void Q03Completed()
    {
        question03Screen.SetActive(false);

        question03Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 04
    public void Q04Option01()
    {
        q04Option01.SetActive(true);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        careerOption01 += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option02()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(true);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        careerOption02 += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option03()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(true);
        q04Option04.SetActive(false);
        q04Option05.SetActive(false);

        careerOption03 += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option04()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(true);
        q04Option05.SetActive(false);

        careerOption04 += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Option05()
    {
        q04Option01.SetActive(false);
        q04Option02.SetActive(false);
        q04Option03.SetActive(false);
        q04Option04.SetActive(false);
        q04Option05.SetActive(true);

        careerOption05 += 1;
        q04NextButton.SetActive(true);
    }
    public void Q04Completed()
    {
        question04Screen.SetActive(false);

        question04Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 05
    public void Q05Option01()
    {
        q05Option01.SetActive(true);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        careerOption01 += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option02()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(true);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        careerOption02 += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option03()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(true);
        q05Option04.SetActive(false);
        q05Option05.SetActive(false);

        careerOption03 += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option04()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(true);
        q05Option05.SetActive(false);

        careerOption04 += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Option05()
    {
        q05Option01.SetActive(false);
        q05Option02.SetActive(false);
        q05Option03.SetActive(false);
        q05Option04.SetActive(false);
        q05Option05.SetActive(true);

        careerOption05 += 1;
        q05NextButton.SetActive(true);
    }
    public void Q05Completed()
    {
        question05Screen.SetActive(false);

        question05Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 06
    public void Q06Option01()
    {
        q06Option01.SetActive(true);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        careerOption01 += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option02()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(true);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        careerOption02 += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option03()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(true);
        q06Option04.SetActive(false);
        q06Option05.SetActive(false);

        careerOption03 += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option04()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(true);
        q06Option05.SetActive(false);

        careerOption04 += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Option05()
    {
        q06Option01.SetActive(false);
        q06Option02.SetActive(false);
        q06Option03.SetActive(false);
        q06Option04.SetActive(false);
        q06Option05.SetActive(true);

        careerOption05 += 1;
        q06NextButton.SetActive(true);
    }
    public void Q06Completed()
    {
        question06Screen.SetActive(false);

        question06Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 07
    public void Q07Option01()
    {
        q07Option01.SetActive(true);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        careerOption01 += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option02()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(true);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        careerOption02 += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option03()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(true);
        q07Option04.SetActive(false);
        q07Option05.SetActive(false);

        careerOption03 += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option04()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(true);
        q07Option05.SetActive(false);

        careerOption04 += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Option05()
    {
        q07Option01.SetActive(false);
        q07Option02.SetActive(false);
        q07Option03.SetActive(false);
        q07Option04.SetActive(false);
        q07Option05.SetActive(true);

        careerOption05 += 1;
        q07NextButton.SetActive(true);
    }
    public void Q07Completed()
    {
        question07Screen.SetActive(false);

        question07Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 08
    public void Q08Option01()
    {
        q08Option01.SetActive(true);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        careerOption01 += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option02()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(true);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        careerOption02 += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option03()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(true);
        q08Option04.SetActive(false);
        q08Option05.SetActive(false);

        careerOption03 += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option04()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(true);
        q08Option05.SetActive(false);

        careerOption04 += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Option05()
    {
        q08Option01.SetActive(false);
        q08Option02.SetActive(false);
        q08Option03.SetActive(false);
        q08Option04.SetActive(false);
        q08Option05.SetActive(true);

        careerOption05 += 1;
        q08NextButton.SetActive(true);
    }
    public void Q08Completed()
    {
        question08Screen.SetActive(false);

        question08Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 09
    public void Q09Option01()
    {
        q09Option01.SetActive(true);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        careerOption01 += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option02()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(true);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        careerOption02 += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option03()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(true);
        q09Option04.SetActive(false);
        q09Option05.SetActive(false);

        careerOption03 += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option04()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(true);
        q09Option05.SetActive(false);

        careerOption04 += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Option05()
    {
        q09Option01.SetActive(false);
        q09Option02.SetActive(false);
        q09Option03.SetActive(false);
        q09Option04.SetActive(false);
        q09Option05.SetActive(true);

        careerOption05 += 1;
        q09NextButton.SetActive(true);
    }
    public void Q09Completed()
    {
        question09Screen.SetActive(false);

        question09Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 10
    public void Q10Option01()
    {
        q10Option01.SetActive(true);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        careerOption01 += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option02()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(true);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        careerOption02 += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option03()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(true);
        q10Option04.SetActive(false);
        q10Option05.SetActive(false);

        careerOption03 += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option04()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(true);
        q10Option05.SetActive(false);

        careerOption04 += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Option05()
    {
        q10Option01.SetActive(false);
        q10Option02.SetActive(false);
        q10Option03.SetActive(false);
        q10Option04.SetActive(false);
        q10Option05.SetActive(true);

        careerOption05 += 1;
        q10NextButton.SetActive(true);
    }
    public void Q10Completed()
    {
        question10Screen.SetActive(false);

        question10Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 11
    public void Q11Option01()
    {
        q11Option01.SetActive(true);
        q11Option02.SetActive(false);
        q11Option03.SetActive(false);
        q11Option04.SetActive(false);
        q11Option05.SetActive(false);

        careerOption01 += 1;
        q11NextButton.SetActive(true);
    }
    public void Q11Option02()
    {
        q11Option01.SetActive(false);
        q11Option02.SetActive(true);
        q11Option03.SetActive(false);
        q11Option04.SetActive(false);
        q11Option05.SetActive(false);

        careerOption02 += 1;
        q11NextButton.SetActive(true);
    }
    public void Q11Option03()
    {
        q11Option01.SetActive(false);
        q11Option02.SetActive(false);
        q11Option03.SetActive(true);
        q11Option04.SetActive(false);
        q11Option05.SetActive(false);

        careerOption03 += 1;
        q11NextButton.SetActive(true);
    }
    public void Q11Option04()
    {
        q11Option01.SetActive(false);
        q11Option02.SetActive(false);
        q11Option03.SetActive(false);
        q11Option04.SetActive(true);
        q11Option05.SetActive(false);

        careerOption04 += 1;
        q11NextButton.SetActive(true);
    }
    public void Q11Option05()
    {
        q11Option01.SetActive(false);
        q11Option02.SetActive(false);
        q11Option03.SetActive(false);
        q11Option04.SetActive(false);
        q11Option05.SetActive(true);

        careerOption05 += 1;
        q11NextButton.SetActive(true);
    }
    public void Q11Completed()
    {
        question11Screen.SetActive(false);

        question11Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 12
    public void Q12Option01()
    {
        q12Option01.SetActive(true);
        q12Option02.SetActive(false);
        q12Option03.SetActive(false);
        q12Option04.SetActive(false);
        q12Option05.SetActive(false);

        careerOption01 += 1;
        q12NextButton.SetActive(true);
    }
    public void Q12Option02()
    {
        q12Option01.SetActive(false);
        q12Option02.SetActive(true);
        q12Option03.SetActive(false);
        q12Option04.SetActive(false);
        q12Option05.SetActive(false);

        careerOption02 += 1;
        q12NextButton.SetActive(true);
    }
    public void Q12Option03()
    {
        q12Option01.SetActive(false);
        q12Option02.SetActive(false);
        q12Option03.SetActive(true);
        q12Option04.SetActive(false);
        q12Option05.SetActive(false);

        careerOption03 += 1;
        q12NextButton.SetActive(true);
    }
    public void Q12Option04()
    {
        q12Option01.SetActive(false);
        q12Option02.SetActive(false);
        q12Option03.SetActive(false);
        q12Option04.SetActive(true);
        q12Option05.SetActive(false);

        careerOption04 += 1;
        q12NextButton.SetActive(true);
    }
    public void Q12Option05()
    {
        q12Option01.SetActive(false);
        q12Option02.SetActive(false);
        q12Option03.SetActive(false);
        q12Option04.SetActive(false);
        q12Option05.SetActive(true);

        careerOption05 += 1;
        q12NextButton.SetActive(true);
    }
    public void Q12Completed()
    {
        question12Screen.SetActive(false);

        question12Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 13
    public void Q13Option01()
    {
        q13Option01.SetActive(true);
        q13Option02.SetActive(false);
        q13Option03.SetActive(false);
        q13Option04.SetActive(false);
        q13Option05.SetActive(false);

        careerOption01 += 1;
        q13NextButton.SetActive(true);
    }
    public void Q13Option02()
    {
        q13Option01.SetActive(false);
        q13Option02.SetActive(true);
        q13Option03.SetActive(false);
        q13Option04.SetActive(false);
        q13Option05.SetActive(false);

        careerOption02 += 1;
        q13NextButton.SetActive(true);
    }
    public void Q13Option03()
    {
        q13Option01.SetActive(false);
        q13Option02.SetActive(false);
        q13Option03.SetActive(true);
        q13Option04.SetActive(false);
        q13Option05.SetActive(false);

        careerOption03 += 1;
        q13NextButton.SetActive(true);
    }
    public void Q13Option04()
    {
        q13Option01.SetActive(false);
        q13Option02.SetActive(false);
        q13Option03.SetActive(false);
        q13Option04.SetActive(true);
        q13Option05.SetActive(false);

        careerOption04 += 1;
        q13NextButton.SetActive(true);
    }
    public void Q13Option05()
    {
        q13Option01.SetActive(false);
        q13Option02.SetActive(false);
        q13Option03.SetActive(false);
        q13Option04.SetActive(false);
        q13Option05.SetActive(true);

        careerOption05 += 1;
        q13NextButton.SetActive(true);
    }
    public void Q13Completed()
    {
        question13Screen.SetActive(false);

        question13Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 14
    public void Q14Option01()
    {
        q14Option01.SetActive(true);
        q14Option02.SetActive(false);
        q14Option03.SetActive(false);
        q14Option04.SetActive(false);
        q14Option05.SetActive(false);

        careerOption01 += 1;
        q14NextButton.SetActive(true);
    }
    public void Q14Option02()
    {
        q14Option01.SetActive(false);
        q14Option02.SetActive(true);
        q14Option03.SetActive(false);
        q14Option04.SetActive(false);
        q14Option05.SetActive(false);

        careerOption02 += 1;
        q14NextButton.SetActive(true);
    }
    public void Q14Option03()
    {
        q14Option01.SetActive(false);
        q14Option02.SetActive(false);
        q14Option03.SetActive(true);
        q14Option04.SetActive(false);
        q14Option05.SetActive(false);

        careerOption03 += 1;
        q14NextButton.SetActive(true);
    }
    public void Q14Option04()
    {
        q14Option01.SetActive(false);
        q14Option02.SetActive(false);
        q14Option03.SetActive(false);
        q14Option04.SetActive(true);
        q14Option05.SetActive(false);

        careerOption04 += 1;
        q14NextButton.SetActive(true);
    }
    public void Q14Option05()
    {
        q14Option01.SetActive(false);
        q14Option02.SetActive(false);
        q14Option03.SetActive(false);
        q14Option04.SetActive(false);
        q14Option05.SetActive(true);

        careerOption05 += 1;
        q14NextButton.SetActive(true);
    }
    public void Q14Completed()
    {
        question14Screen.SetActive(false);

        question14Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // Question 15
    public void Q15Option01()
    {
        q15Option01.SetActive(true);
        q15Option02.SetActive(false);
        q15Option03.SetActive(false);
        q15Option04.SetActive(false);
        q15Option05.SetActive(false);

        careerOption01 += 1;
        q15NextButton.SetActive(true);
    }
    public void Q15Option02()
    {
        q15Option01.SetActive(false);
        q15Option02.SetActive(true);
        q15Option03.SetActive(false);
        q15Option04.SetActive(false);
        q15Option05.SetActive(false);

        careerOption02 += 1;
        q15NextButton.SetActive(true);
    }
    public void Q15Option03()
    {
        q15Option01.SetActive(false);
        q15Option02.SetActive(false);
        q15Option03.SetActive(true);
        q15Option04.SetActive(false);
        q15Option05.SetActive(false);

        careerOption03 += 1;
        q15NextButton.SetActive(true);
    }
    public void Q15Option04()
    {
        q15Option01.SetActive(false);
        q15Option02.SetActive(false);
        q15Option03.SetActive(false);
        q15Option04.SetActive(true);
        q15Option05.SetActive(false);

        careerOption04 += 1;
        q15NextButton.SetActive(true);
    }
    public void Q15Option05()
    {
        q15Option01.SetActive(false);
        q15Option02.SetActive(false);
        q15Option03.SetActive(false);
        q15Option04.SetActive(false);
        q15Option05.SetActive(true);

        careerOption05 += 1;
        q15NextButton.SetActive(true);
    }
    public void Q15Completed()
    {
        question15Screen.SetActive(false);

        question15Answered = true;
        questionsAnswered++;
        RandomQuestion01();
    }

    // All Questions Answered
    public void AllQuestionsCompleted()
    {
        if ((careerOption01 > careerOption02) && (careerOption01 > careerOption03) && (careerOption01 > careerOption04) && (careerOption01 > careerOption05))
        {
            careerOption01Screen.SetActive(true);
        }
        else if ((careerOption02 > careerOption01) && (careerOption02 > careerOption03) && (careerOption02 > careerOption04) && (careerOption02 > careerOption05))
        {
            careerOption02Screen.SetActive(true);
        }
        else if ((careerOption03 > careerOption02) && (careerOption03 > careerOption01) && (careerOption03 > careerOption04) && (careerOption03 > careerOption05))
        {
            careerOption03Screen.SetActive(true);
        }
        else if ((careerOption04 > careerOption02) && (careerOption04 > careerOption03) && (careerOption04 > careerOption01) && (careerOption04 > careerOption05))
        {
            careerOption04Screen.SetActive(true);
        }
        else if ((careerOption05 > careerOption02) && (careerOption05 > careerOption03) && (careerOption05 > careerOption04) && (careerOption05 > careerOption01))
        {
            careerOption05Screen.SetActive(true);
        }
        else
        {
            RandomBonusQuestion01();
        }
    }


    // Bonus Questions
    // Bonus Question 01
    public void QB01Option01()
    {
        qB01Option01.SetActive(true);
        qB01Option02.SetActive(false);
        qB01Option03.SetActive(false);
        qB01Option04.SetActive(false);
        qB01Option05.SetActive(false);

        careerOption01 += 2;
        qB01NextButton.SetActive(true);
    }
    public void QB01Option02()
    {
        qB01Option01.SetActive(false);
        qB01Option02.SetActive(true);
        qB01Option03.SetActive(false);
        qB01Option04.SetActive(false);
        qB01Option05.SetActive(false);

        careerOption02 += 2;
        qB01NextButton.SetActive(true);
    }
    public void QB01Option03()
    {
        qB01Option01.SetActive(false);
        qB01Option02.SetActive(false);
        qB01Option03.SetActive(true);
        qB01Option04.SetActive(false);
        qB01Option05.SetActive(false);

        careerOption03 += 2;
        qB01NextButton.SetActive(true);
    }
    public void QB01Option04()
    {
        qB01Option01.SetActive(false);
        qB01Option02.SetActive(false);
        qB01Option03.SetActive(false);
        qB01Option04.SetActive(true);
        qB01Option05.SetActive(false);

        careerOption04 += 2;
        qB01NextButton.SetActive(true);
    }
    public void QB01Option05()
    {
        qB01Option01.SetActive(false);
        qB01Option02.SetActive(false);
        qB01Option03.SetActive(false);
        qB01Option04.SetActive(false);
        qB01Option05.SetActive(true);

        careerOption05 += 2;
        qB01NextButton.SetActive(true);
    }
    public void QB01Completed()
    {
        questionB01Answered = true;
        questionB01Screen.SetActive(false);
        QBCompleted();
    }
    // Bonus Question 02
    public void QB02Option01()
    {
        qB02Option01.SetActive(true);
        qB02Option02.SetActive(false);
        qB02Option03.SetActive(false);
        qB02Option04.SetActive(false);
        qB02Option05.SetActive(false);

        careerOption01 += 2;
        qB02NextButton.SetActive(true);
    }
    public void QB02Option02()
    {
        qB02Option01.SetActive(false);
        qB02Option02.SetActive(true);
        qB02Option03.SetActive(false);
        qB02Option04.SetActive(false);
        qB02Option05.SetActive(false);

        careerOption02 += 2;
        qB02NextButton.SetActive(true);
    }
    public void QB02Option03()
    {
        qB02Option01.SetActive(false);
        qB02Option02.SetActive(false);
        qB02Option03.SetActive(true);
        qB02Option04.SetActive(false);
        qB02Option05.SetActive(false);

        careerOption03 += 2;
        qB02NextButton.SetActive(true);
    }
    public void QB02Option04()
    {
        qB02Option01.SetActive(false);
        qB02Option02.SetActive(false);
        qB02Option03.SetActive(false);
        qB02Option04.SetActive(true);
        qB02Option05.SetActive(false);

        careerOption04 += 2;
        qB02NextButton.SetActive(true);
    }
    public void QB02Option05()
    {
        qB02Option01.SetActive(false);
        qB02Option02.SetActive(false);
        qB02Option03.SetActive(false);
        qB02Option04.SetActive(false);
        qB02Option05.SetActive(true);

        careerOption05 += 2;
        qB02NextButton.SetActive(true);
    }
    public void QB02Completed()
    {
        questionB02Answered = true;
        questionB02Screen.SetActive(false);
        QBCompleted();
    }
    // Bonus Question 03
    public void QB03Option01()
    {
        qB03Option01.SetActive(true);
        qB03Option02.SetActive(false);
        qB03Option03.SetActive(false);
        qB03Option04.SetActive(false);
        qB03Option05.SetActive(false);

        careerOption01 += 2;
        qB03NextButton.SetActive(true);
    }
    public void QB03Option02()
    {
        qB03Option01.SetActive(false);
        qB03Option02.SetActive(true);
        qB03Option03.SetActive(false);
        qB03Option04.SetActive(false);
        qB03Option05.SetActive(false);

        careerOption02 += 2;
        qB03NextButton.SetActive(true);
    }
    public void QB03Option03()
    {
        qB03Option01.SetActive(false);
        qB03Option02.SetActive(false);
        qB03Option03.SetActive(true);
        qB03Option04.SetActive(false);
        qB03Option05.SetActive(false);

        careerOption03 += 2;
        qB03NextButton.SetActive(true);
    }
    public void QB03Option04()
    {
        qB03Option01.SetActive(false);
        qB03Option02.SetActive(false);
        qB03Option03.SetActive(false);
        qB03Option04.SetActive(true);
        qB03Option05.SetActive(false);

        careerOption04 += 2;
        qB03NextButton.SetActive(true);
    }
    public void QB03Option05()
    {
        qB03Option01.SetActive(false);
        qB03Option02.SetActive(false);
        qB03Option03.SetActive(false);
        qB03Option04.SetActive(false);
        qB03Option05.SetActive(true);

        careerOption05 += 2;
        qB03NextButton.SetActive(true);
    }
    public void QB03Completed()
    {
        questionB03Answered = true;
        questionB03Screen.SetActive(false);
        QBCompleted();
    }
    // Bonus Question 04
    public void QB04Option01()
    {
        qB04Option01.SetActive(true);
        qB04Option02.SetActive(false);
        qB04Option03.SetActive(false);
        qB04Option04.SetActive(false);
        qB04Option05.SetActive(false);

        careerOption01 += 2;
        qB04NextButton.SetActive(true);
    }
    public void QB04Option02()
    {
        qB04Option01.SetActive(false);
        qB04Option02.SetActive(true);
        qB04Option03.SetActive(false);
        qB04Option04.SetActive(false);
        qB04Option05.SetActive(false);

        careerOption02 += 2;
        qB04NextButton.SetActive(true);
    }
    public void QB04Option03()
    {
        qB04Option01.SetActive(false);
        qB04Option02.SetActive(false);
        qB04Option03.SetActive(true);
        qB04Option04.SetActive(false);
        qB04Option05.SetActive(false);

        careerOption03 += 2;
        qB04NextButton.SetActive(true);
    }
    public void QB04Option04()
    {
        qB04Option01.SetActive(false);
        qB04Option02.SetActive(false);
        qB04Option03.SetActive(false);
        qB04Option04.SetActive(true);
        qB04Option05.SetActive(false);

        careerOption04 += 2;
        qB04NextButton.SetActive(true);
    }
    public void QB04Option05()
    {
        qB04Option01.SetActive(false);
        qB04Option02.SetActive(false);
        qB04Option03.SetActive(false);
        qB04Option04.SetActive(false);
        qB04Option05.SetActive(true);

        careerOption05 += 2;
        qB04NextButton.SetActive(true);
    }
    public void QB04Completed()
    {
        questionB04Answered = true;
        questionB04Screen.SetActive(false);
        QBCompleted();
    }
    // Bonus Question 05
    public void QB05Option01()
    {
        qB05Option01.SetActive(true);
        qB05Option02.SetActive(false);
        qB05Option03.SetActive(false);
        qB05Option04.SetActive(false);
        qB05Option05.SetActive(false);

        careerOption01 += 2;
        qB05NextButton.SetActive(true);
    }
    public void QB05Option02()
    {
        qB05Option01.SetActive(false);
        qB05Option02.SetActive(true);
        qB05Option03.SetActive(false);
        qB05Option04.SetActive(false);
        qB05Option05.SetActive(false);

        careerOption02 += 2;
        qB05NextButton.SetActive(true);
    }
    public void QB05Option03()
    {
        qB05Option01.SetActive(false);
        qB05Option02.SetActive(false);
        qB05Option03.SetActive(true);
        qB05Option04.SetActive(false);
        qB05Option05.SetActive(false);

        careerOption03 += 2;
        qB05NextButton.SetActive(true);
    }
    public void QB05Option04()
    {
        qB05Option01.SetActive(false);
        qB05Option02.SetActive(false);
        qB05Option03.SetActive(false);
        qB05Option04.SetActive(true);
        qB05Option05.SetActive(false);

        careerOption04 += 2;
        qB05NextButton.SetActive(true);
    }
    public void QB05Option05()
    {
        qB05Option01.SetActive(false);
        qB05Option02.SetActive(false);
        qB05Option03.SetActive(false);
        qB05Option04.SetActive(false);
        qB05Option05.SetActive(true);

        careerOption05 += 2;
        qB05NextButton.SetActive(true);
    }
    public void QB05Completed()
    {
        questionB05Answered = true;
        questionB05Screen.SetActive(false);
        QBCompleted();
    }


    public void QBCompleted()
    {
        if ((careerOption01 > careerOption02) && (careerOption01 > careerOption03) && (careerOption01 > careerOption04) && (careerOption01 > careerOption05))
        {
            careerOption01Screen.SetActive(true);
        }
        else if ((careerOption02 > careerOption01) && (careerOption02 > careerOption03) && (careerOption02 > careerOption04) && (careerOption02 > careerOption05))
        {
            careerOption02Screen.SetActive(true);
        }
        else if ((careerOption03 > careerOption02) && (careerOption03 > careerOption01) && (careerOption03 > careerOption04) && (careerOption03 > careerOption05))
        {
            careerOption03Screen.SetActive(true);
        }
        else if ((careerOption04 > careerOption02) && (careerOption04 > careerOption03) && (careerOption04 > careerOption01) && (careerOption04 > careerOption05))
        {
            careerOption04Screen.SetActive(true);
        }
        else if ((careerOption05 > careerOption02) && (careerOption05 > careerOption03) && (careerOption05 > careerOption04) && (careerOption05 > careerOption01))
        {
            careerOption05Screen.SetActive(true);
        }
        else
        {
            RandomBonusQuestion01();
        }
    }

    // Random Question Configuration
    public void RandomQuestion01()
    {
        if (questionsAnswered >= 10)
        {
            AllQuestionsCompleted();
        }
        else
        {
            questionNumber = UnityEngine.Random.Range(1, 16);
            RandomQuestionChecker();
        }
    }
    public void RandomQuestionChecker()
    {
        if (questionNumber == 1 && question01Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 2 && question02Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 3 && question03Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 4 && question04Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 5 && question05Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 6 && question06Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 7 && question07Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 8 && question08Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 9 && question09Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 10 && question10Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 11 && question11Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 12 && question12Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 13 && question13Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 14 && question14Answered == true)
        {
            RandomQuestion01();
        }
        else if (questionNumber == 15 && question15Answered == true)
        {
            RandomQuestion01();
        }
        else
        {
            RandomQuestion02();
        }
    }
    public void RandomQuestion02()
    {
        switch (questionNumber)
        {
            case 1:
                question01Screen.SetActive(true);
                break;
            case 2:
                question02Screen.SetActive(true);
                break;
            case 3:
                question03Screen.SetActive(true);
                break;
            case 4:
                question04Screen.SetActive(true);
                break;
            case 5:
                question05Screen.SetActive(true);
                break;
            case 6:
                question06Screen.SetActive(true);
                break;
            case 7:
                question07Screen.SetActive(true);
                break;
            case 8:
                question08Screen.SetActive(true);
                break;
            case 9:
                question09Screen.SetActive(true);
                break;
            case 10:
                question10Screen.SetActive(true);
                break;
            case 11:
                question11Screen.SetActive(true);
                break;
            case 12:
                question12Screen.SetActive(true);
                break;
            case 13:
                question13Screen.SetActive(true);
                break;
            case 14:
                question14Screen.SetActive(true);
                break;
            case 15:
                question15Screen.SetActive(true);
                break;
        }
    }

    // Random Bonus Question Configuration
    public void RandomBonusQuestion01()
    {
        bonusQuestionNumber = UnityEngine.Random.Range(1, 6);
        RandomBonusQuestionChecker();
    }
    public void RandomBonusQuestionChecker()
    {
        if (bonusQuestionNumber == 1 && questionB01Answered == true)
        {
            RandomBonusQuestion01();
        }
        else if (bonusQuestionNumber == 2 && questionB02Answered == true)
        {
            RandomBonusQuestion01();
        }
        else if (bonusQuestionNumber == 3 && questionB03Answered == true)
        {
            RandomBonusQuestion01();
        }
        else if (bonusQuestionNumber == 4 && questionB04Answered == true)
        {
            RandomBonusQuestion01();
        }
        else if (bonusQuestionNumber == 5 && questionB05Answered == true)
        {
            RandomBonusQuestion01();
        }
        else
        {
            RandomBonusQuestion02();
        }
    }
    public void RandomBonusQuestion02()
    {
        switch (bonusQuestionNumber)
        {
            case 1:
                questionB01Screen.SetActive(true);
                break;
            case 2:
                questionB02Screen.SetActive(true);
                break;
            case 3:
                questionB03Screen.SetActive(true);
                break;
            case 4:
                questionB04Screen.SetActive(true);
                break;
            case 5:
                questionB05Screen.SetActive(true);
                break;
        }
    }


    // Job Option Links
    // Job Option Links - Career Option 01
    // Job Option Links - Career Option 01 - More Information
    public void Job01MoreLink()
    {
        // Job 01 - More Info
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 01 - Companies
    public void Job01Comp01Link()
    {
        // Job 01 - Comapny 01
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job01Comp02Link()
    {
        // Job 01 - Comapny 02
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job01Comp03Link()
    {
        // Job 01 - Comapny 03
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job01Comp04Link()
    {
        // Job 01 - Comapny 04
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job01Comp05Link()
    {
        // Job 01 - Comapny 05
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 02
    // Job Option Links - Career Option 02 - More Information
    public void Job02MoreLink()
    {
        // Job 02 - More Info
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 02 - Companies
    public void Job02Comp01Link()
    {
        // Job 02 - Comapny 01
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job02Comp02Link()
    {
        // Job 02 - Comapny 02
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job02Comp03Link()
    {
        // Job 02 - Comapny 03
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job02Comp04Link()
    {
        // Job 02 - Comapny 04
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job02Comp05Link()
    {
        // Job 02 - Comapny 05
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 03
    // Job Option Links - Career Option 03 - More Information
    public void Job03MoreLink()
    {
        // Job 03 - More Info
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 03 - Companies
    public void Job03Comp01Link()
    {
        // Job 03 - Comapny 01
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job03Comp02Link()
    {
        // Job 03 - Comapny 02
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job03Comp03Link()
    {
        // Job 03 - Comapny 03
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job03Comp04Link()
    {
        // Job 03 - Comapny 04
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job03Comp05Link()
    {
        // Job 03 - Comapny 05
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 04
    // Job Option Links - Career Option 04 - More Information
    public void Job04MoreLink()
    {
        // Job 04 - More Info
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 04 - Companies
    public void Job04Comp01Link()
    {
        // Job 04 - Comapny 01
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job04Comp02Link()
    {
        // Job 04 - Comapny 02
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job04Comp03Link()
    {
        // Job 04 - Comapny 03
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job04Comp04Link()
    {
        // Job 04 - Comapny 04
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job04Comp05Link()
    {
        // Job 04 - Comapny 05
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 05
    // Job Option Links - Career Option 05 - More Information
    public void Job05MoreLink()
    {
        // Job 05 - More Info
        Application.OpenURL("http://unity3d.com/");
    }
    // Job Option Links - Career Option 05 - Companies
    public void Job05Comp01Link()
    {
        // Job 05 - Comapny 01
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job05Comp02Link()
    {
        // Job 05 - Comapny 02
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job05Comp03Link()
    {
        // Job 05 - Comapny 03
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job05Comp04Link()
    {
        // Job 05 - Comapny 04
        Application.OpenURL("http://unity3d.com/");
    }
    public void Job05Comp05Link()
    {
        // Job 05 - Comapny 05
        Application.OpenURL("http://unity3d.com/");
    }


    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
