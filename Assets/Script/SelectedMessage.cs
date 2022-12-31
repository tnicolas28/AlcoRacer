using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectedMessage : MonoBehaviour
{
    public TextMeshProUGUI Placeholder;


    private string[] messages = {
        "“A drunk driver is very dangerous. So is a drunk backseat driver if he’s persuasive.” – Demetri Martin",
        "“Each drink you have before driving impairs your judgment, don’t drink and drive.” – Unknown",
        "“If you drink don’t drive. Don’t even putt.” – Dean Martin",
        "“An intoxicated person might become angry if others suggest that he or she should not drive.” – Valerie Mendrala",
        "“Drunk driving is a killer disease.” – Unknown",
        "“Drinking and driving: there are stupider things, but it’s a very short list.” – Unknown",
        "“It takes only one drink to get me drunk. The trouble is, I can’t remember if it’s the thirteenth or the fourteenth.” – George Burns",
        "“There’s only one thing worse than being driven to drink, and that’s driving yourself home from it.” – Evan Esar",
        "“Alcohol is a make-you-stupid drug.” – Beverly A. Potter",
        "“Drinking and driving can destroy lives and families.” – Valerie Mendrall",
        "“Drinking and driving is safer than either drinking or driving – and no one has ever died drinking, driving and juggling.” – Lee Mack",
        "“I know some people are against drunk driving, but you know, sometimes you’ve got no choice. Those kids got to get to school.” – Dave Attell",
        "“Don’t drink and drive – stay alive.” – Unknown",
        "“A woman drove me to drink. I don’t drink and drive.” – Brian Spellman",
        "“Driving under the influence is a highway to detention, or ends in a death zone.” – Martin Uzochukwu Ugwu",
        "“Teens who get behind the wheel after drinking may also hurt innocent bystanders or other drivers.” – Valerie Mendralla",
        "“Drive hammered, get slammered.” – Unknown",
        "“It’s as if people used the invention of seat belts as an opportunity to take up drunk driving.” –  John Lanchester",
        "“First you take a drink, then the drink takes a drink, then the drink takes you.” – Francis Scott Key Fitzgerald",
        "“I want to thank everyone out there who has chosen not to drive after they have had something to drink.” – Audrey Conn",
        "“Nobody, at least sitting in my seat, is defending drunk driving. I am not for drunk driving.” – Tucker Carlson",
        "“More people die on a per-mile basis from drunk walking than from drunk driving.” – A. J. Jacobs",
        "“The one for the road may be two for the cemetery.” – Evan Esar",
        "“I drive better when I am drunk because I do back seat driving.” – Amit Abraham",
        "“Baseball is like driving, it’s the one who gets home safely that count” – Tommy Lasorda",
        "“Drinking and driving is a gamble that you just can’t win.” – Unknown",
        "“The best car safety device is a rear-view mirror with a cop in it.” – Dudley Moore",
        "“Drinking and driving kills someone every 48 minutes, don’t be a murderer.” – Unknown",
        "“Teens talking to other teens about safe driving and having fun without alcohol can be very effective in changing attitudes and perceptions and, in turn, behaviors.” – Valerie Mendralla",
        "“The problem with drinking and driving is the mourning after.” – Unknown",
    };


    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(0, messages.Length);
        Placeholder.text = messages[rnd];
    }



}
