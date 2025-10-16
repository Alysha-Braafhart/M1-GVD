using UnityEngine;

public class Discort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Discord Bot Simulator - versie 1.0
        Debug.Log("🤖 GamerBot is online!");

        // Welkomstbericht
        Debug.Log("📢 Welcome to the server!");

        /*
        Simuleer verschillende bot commando's
        Elke regel doet alsof een user een commando heeft gebruikt
        */

        // Weather commando
        Debug.Log("🌤️ Today's weather: Sunny, 22°C - Perfect gaming weather!");

        // Music commando
        Debug.Log("🎵 Now playing: Minecraft OST - Sweden");

        // Meme commando
        Debug.Log("😂 Random meme: Why did the creeper cross the road? To get to the other ssside!");

        // Server stats
        Debug.Log("📊 Server Stats: 1,337 members online");

        // Game night announcement
        Debug.Log("🎮 Game Night Tonight: Among Us at 20:00!");

        Debug.Log("💤 GamerBot going to sleep mode...");

        //Person commando
        Debug.Log("👋😁 Someone has joined! Everyone say hi!");
        Debug.Log("👋🙁 A person has left. We wish you well.");
        Debug.Log("👎😠 A person has been kicked for bad behavior.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
