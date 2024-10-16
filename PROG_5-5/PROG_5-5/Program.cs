using System;

// Abstracte klasse Speak
abstract class Speak
{
    // Virtuele methode SpeakSomething()
    public virtual void SpeakSomething()
    {
        Console.WriteLine("Hey ik praat nu Nederlands");
    }
}

// Interface Language
interface Language
{
    void ShowLanguage();
}

// Klasse Afrikaans erft van Speak en implementeert Language
class Afrikaans : Speak, Language
{
    // Override van SpeakSomething() met Afrikaanse tekst
    public override void SpeakSomething()
    {
        Console.WriteLine("Hey, ek praat nou Afrikaans");
    }

    // Implementatie van ShowLanguage() voor Afrikaans
    public void ShowLanguage()
    {
        Console.WriteLine("Taal: Afrikaans");
    }
}

// Klasse English erft van Speak en implementeert Language
class English : Speak, Language
{
    // Override van SpeakSomething() met Engelse tekst
    public override void SpeakSomething()
    {
        Console.WriteLine("Hey, I'm speaking English now");
    }

    // Implementatie van ShowLanguage() voor English
    public void ShowLanguage()
    {
        Console.WriteLine("Language: English");
    }
}

// Klasse German erft van Speak en implementeert Language
class German : Speak, Language
{
    // Override van SpeakSomething() met Duitse tekst
    public override void SpeakSomething()
    {
        Console.WriteLine("Hey, ich spreche jetzt Deutsch");
    }

    // Implementatie van ShowLanguage() voor German
    public void ShowLanguage()
    {
        Console.WriteLine("Sprache: Deutsch");
    }
}

// Klasse French erft van Speak en implementeert Language
class French : Speak, Language
{
    // Override van SpeakSomething() met Franse tekst
    public override void SpeakSomething()
    {
        Console.WriteLine("Salut, je parle français maintenant");
    }

    // Implementatie van ShowLanguage() voor French
    public void ShowLanguage()
    {
        Console.WriteLine("Langue: Français");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Maak objecten aan voor elke taal, inclusief Afrikaans
        Speak[] speakers = new Speak[] { new Afrikaans(), new English(), new German(), new French() };

        // Laat elke object praten en hun taal tonen
        foreach (Speak speaker in speakers)
        {
            speaker.SpeakSomething();

            if (speaker is Language lang)
            {
                lang.ShowLanguage();
            }

            Console.WriteLine(); // Voor leesbaarheid
        }
    }
}
