using Pets;

namespace Pets
{
    public class Cat : IPet
    {
        public string TalkToOwner()
        {
            return "Meow!";
        }
    }
}