using UnityEngine;
using UnityEngine.UI;

/*
 * 
 *  Script Written by Altamash Kalania.
 * 
 */


public class PlanetsInformation : MonoBehaviour
{
    public enum planet
    {
        Earth,
        Mars,
        Mercury,
        Venus,
        Saturn,
        Neptune,
        Jupiture,
        Uranus,
    }

    public planet planetType = planet.Earth;
    public TextMesh titleText;
    public TextMesh informationText;
    public Text funFactsButtonText;

    public Transform planetsHolder;

    public AudioClip EarthSound;
    public AudioClip MarsSound;
    public AudioClip VenusSound;
    public AudioClip MercurySound;
    public AudioClip SaturnSound;
    public AudioClip JupiterSound;
    public AudioClip NeptuneSound;
    public AudioClip UranusSound;

    public AudioSource thePlayer;

    public Sprite muteUI;
    public Sprite unmuteUI;

    public Image soundButton;

    // Planetary Statistics in Metric system.
    private string EarthInformationInMetric = "Average Distace from Sun = 149,600,000 km \nDiameter = 12,756 km \nA day = 23 hours, 56 mins\nA year = 365.25 days\nAverage Temperature = 14 °C\nNumber of Moons = 1";
    private string MarsInformationInMetric = "Average Distace from Sun = 227,936,640 km \nDiameter = 6,794 km \nA day = 24 hours, 37 mins\nA year = 687 days\nAverage Temperature = -63 °C \nNumber of Moons = 2";
    private string MercuryInformationInMetric = "Average Distace from Sun = 57,900,000 km \nDiameter = 4,878 km \nA day = 59 days\nA year = 88 days\nAverage Temperature = -183 °C to 427 °C\nNumber of Moons = 0";
    private string VenusInformationInMetric = "Average Distace from Sun = 108,160,000 km \nDiameter = 12,104 km \nA day = 243 days\nA year = 224 days\nAverage Temperature = 480 °C\nNumber of Moons = 0";
    private string JupiterInformationInMetric = "Average Distace from Sun = 778,369,000 km \nDiameter = 142,984 km \nA day = 9 hours, 55 mins\nA year = 11.86 years\nAverage Temperature = -130 °C\nNumber of Moons = 66";
    private string SaturnInformationInMetric = "Average Distace from Sun = 1,427,034,000 km \nDiameter = 120,536 km \nA day = 10 hours, 39 mins\nA year = 29 years\nAverage Temperature = -130 °C\nNumber of Moons = 62";
    private string UranusInformationInMetric = "Average Distace from Sun = 2,870,658,186 km \nDiameter = 51,118 km \nA day = 17 hours, 14 mins\nA year = 84 years\nAverage Temperature =  -200 °C\nNumber of Moons = 27";
    private string NeptuneInformationInMetric = "Average Distace from Sun = 4,496,976,000 km \nDiameter = 49,532 km \nA day = 16 hours, 7 mins\nA year = 164.8 years\nAverage Temperature =  -200 °C\nNumber of Moons = 14";

    // Planetary Statistics in Imperial System.
    private string EarthInformationInImperial = "Average Distace from Sun = 92,960,000 miles\nDiameter = 7,926 miles\nA day = 23 hours, 56 mins\nA year = 365.25 days\nAverage Temperature = 57 °F\nNumber of Moons = 1";
    private string MarsInformationInImperial = "Average Distace from Sun = 141,700,000 miles\nDiameter = 4,222 miles\nA day = 24 hours, 37 mins\nA year = 687 days\nAverage Temperature = -81 °F\nNumber of Moons = 2";
    private string MercuryInformationInImperial = "Average Distace from Sun = 36,000,000 miles\nDiameter = 3,031 miles\nA day = 59 days\nA year = 88 days\nAverage Temperature = -297 °F to 800 °F\nNumber of Moons = 0";
    private string VenusInformationInImperial = "Average Distace from Sun = 67,000,000 miles\nDiameter = 7,521 miles\nA day = 243 days\nA year = 224 days\nAverage Temperature = 896 °F\nNumber of Moons = 0";
    private string JupiterInformationInImperial = "Average Distace from Sun = 483,500,000 miles\nDiameter = 88,846 miles\nA day = 9 hours, 55 mins\nA year = 11.86 years\nAverage Temperature = -202 °F\nNumber of Moons = 66";
    private string SaturnInformationInImperial = "Average Distace from Sun = 888,750,000 miles\nDiameter = 74,900 miles\nA day = 10 hours, 39 mins\nA year = 29 years\nAverage Temperature = -202 °F\nNumber of Moons = 62";
    private string UranusInformationInImperial = "Average Distace from Sun = 1,783,744,300 miles\nDiameter = 31,763 miles\nA day = 17 hours, 14 mins\nA year = 84 years\nAverage Temperature =  -328 °F\nNumber of Moons = 27";
    private string NeptuneInformationInImperial = "Average Distace from Sun = 2,797,770,000 miles\nDiameter = 30,779 miles\nA day = 16 hours, 7 mins\nA year = 164.8 years\nAverage Temperature =  -328 °F\nNumber of Moons = 14";


    // Planetary fun facts 
    private string EarthFacts = "1. Earth's rotation is gradually slowing down.\n2. The gravity between the Earth and the Moon causes the tides on Earth.\n3. The Earth was once believed to be the centre of the universe.\n4. The first life on Earth developed in the oceans.";
    private string MarsFacts = "1. Mars has seasons like Earth, but they last twice as long.\n2. Pieces of Mars have fallen to Earth.\n3. One day Mars will have a ring.";
    private string MercuryFacts = "1. Your weight on Mercury would be 38% of your weight on Earth.\n2. Mercury does not experience any seasons.\n3. Only two spacecraft have ever visited Mercury.";
    private string VenusFacts = "1. Venus is the closest planet to Earth\n2. Venus is the second brightest natural object in the sky after the Moon.\n3. Billions of years ago, the climate of Venus may been similar to that of Earth.";
    private string JupiterFacts = "1. Jupiter is so big that all the other planets in \nthe solar system could fit inside it or 1,300 Earths.\n2. Jupiter has a faint ring system around it.\n3. Jupiter’s Great Red Spot is an enormous storm \nthat has been raging for over 300 years.";
    private string SaturnFacts = "1. Saturn is one of five planets able to be seen with the naked eye.\n2. Saturn has the fastest winds in our solar system with 1,800 km/ 1,118 miles per hour\n(Four times faster than the strongest wind in the Earth's history).\n3. Saturn is 1,424,600,000 km (0,9 billion miles) from the Sun.";
    private string UranusFacts = "1. Uranus is the coldest planet in the solar system with -224 °C or -371.2 °F.\n2. Only one spacecraft named  Voyager 2 has flown by Uranus.\n3. Uranus has 13 presently known rings.";
    private string NeptuneFacts = "1. Only one spacecraft, the Voyager 2, has flown past Neptune.\n2. Like the other outer planets, Neptune possesses a ring system though its rings are very faint.\n3. Neptune has a storm similar the Great Red Spot on Jupiter, which is commonly known as \nthe Great Dark Spot and is roughly the size of Earth.";


    private int index = 0;
    private int maxLength = 0;

    private GameObject[] planets;
    private GameObject currentPlanet;

    private bool isMetric = true;
    private bool statsOn = true;
    private bool isSoundOn = false;

    private AudioClip currentAudioClip;


    private void Start()
    {
        selectInitialPlanet();
        SetPlanetInformation();
    }

    private void selectInitialPlanet()
    {
        maxLength = planetsHolder.childCount;
        planets = new GameObject[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            planets[i] = planetsHolder.GetChild(i).gameObject;
            planets[i].SetActive(false);
        }
        currentPlanet = planets[0];
        currentPlanet.SetActive(true);
    }

    // This function will set the information about the current active planet (Statistics or Facts).
    private void SetPlanetInformation()
    {
        switch (currentPlanet.name)
        {
            case "Earth":
                Earth();
                PlayAudio(EarthSound);
                break;

            case "Uranus":
                Uranus();
                PlayAudio(UranusSound);
                break;

            case "Venus":
                Venus();
                PlayAudio(VenusSound);
                break;

            case "Mars":
                Mars();
                PlayAudio(MarsSound);
                break;

            case "Jupiter":
                Jupiter();
                PlayAudio(JupiterSound);
                break;

            case "Neptune":
                Neptune();
                PlayAudio(NeptuneSound);
                break;

            case "Mercury":
                Mercury();
                PlayAudio(MercurySound);
                break;

            case "Saturn":
                Saturn();
                PlayAudio(SaturnSound);
                break;

            default:
                print("Current planet was empty!");
                Earth();
                PlayAudio(EarthSound);
                break;
        }
    }

    private void Earth()
    {
        planetType = planet.Earth;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? EarthInformationInMetric : EarthInformationInImperial;
        else
            informationText.text = EarthFacts;

        currentAudioClip = EarthSound;
    }

    private void Uranus()
    {
        planetType = planet.Uranus;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? UranusInformationInMetric : UranusInformationInImperial;
        else
            informationText.text = UranusFacts;
        currentAudioClip = UranusSound;
    }

    private void Mars()
    {
        planetType = planet.Mars;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? MarsInformationInMetric : MarsInformationInImperial;
        else
            informationText.text = MarsFacts;
        currentAudioClip = MarsSound;
    }

    private void Jupiter()
    {
        planetType = planet.Jupiture;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? JupiterInformationInMetric : JupiterInformationInImperial;
        else
            informationText.text = JupiterFacts;
        currentAudioClip = JupiterSound;
    }

    private void Neptune()
    {
        planetType = planet.Neptune;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? NeptuneInformationInMetric : NeptuneInformationInImperial;
        else
            informationText.text = NeptuneFacts;
        currentAudioClip = NeptuneSound;
    }

    private void Mercury()
    {
        planetType = planet.Mercury;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? MercuryInformationInMetric : MercuryInformationInImperial;
        else
            informationText.text = MercuryFacts;
        currentAudioClip = MercurySound;
    }

    private void Saturn()
    {
        planetType = planet.Saturn;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? SaturnInformationInMetric : SaturnInformationInImperial;
        else
            informationText.text = SaturnFacts;
        currentAudioClip = SaturnSound;
    }
    private void Venus()
    {
        planetType = planet.Venus;
        titleText.text = planetType.ToString();
        if (statsOn)
            informationText.text = isMetric ? VenusInformationInMetric : VenusInformationInImperial;
        else
            informationText.text = VenusFacts;
        currentAudioClip = VenusSound;
    }

    private void PlayAudio(AudioClip theClip)
    {
        if (isSoundOn)
        {
            thePlayer.Stop();
            thePlayer.clip = theClip;
            thePlayer.Play();
        } 
    }

    private void PlayAudio()
    {
        if (isSoundOn)
        {
            thePlayer.clip = currentAudioClip;
            thePlayer.Play();
        }

        print(currentAudioClip.name);
    }
    private void StopAudio()
    {
        thePlayer.Pause();
    }

    public void SetAudio()
    {
        isSoundOn = !isSoundOn;
        if (isSoundOn)
        {
            PlayAudio();
            soundButton.sprite = muteUI;
        }
        else
        {
            StopAudio();
            soundButton.sprite = unmuteUI;
        }
    }
    //This will choose the next planet and update the information.
    public void nextPlanet()
    {
        index++;
        if (index >= maxLength)
            index = 0;

        currentPlanet.SetActive(false);
        currentPlanet = planets[index];
        currentPlanet.SetActive(true);

        SetPlanetInformation();
    }

    public void switchUnit()
    {
        isMetric = !isMetric;
        SetPlanetInformation();
    }

    public void switchStatsToFacts()
    {
        statsOn = !statsOn;
        funFactsButtonText.text = statsOn ? "Facts" : "Stats";

        SetPlanetInformation();

    }
}
