using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantReferences
{
    public class Elephant
    {
        public string Name;
        public int earSize;

        public void WhoAmI()
        {
            Console.WriteLine($"Na imię mi {Name}.");
            Console.WriteLine($"Długość moich uszu to {earSize}cm.");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{Name} usłyszał(a) wiadomość.");
            Console.WriteLine($"{whoSaidIt.Name} powiedział(a): {message}");
        }
        public void SpeakTo(Elephant WhoToTalkTo, string message)
        {
            WhoToTalkTo.HearMessage(message, this);
        }
    }
}
