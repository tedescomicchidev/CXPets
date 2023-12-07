using Pets;

namespace Pets
{
    /// <summary>
    /// Represents a bird pet.
    /// </summary>
    public class Bird : IPet
    {
        /// <summary>
        /// Makes the bird talk to its owner.
        /// </summary>
        /// <returns>The sound the bird makes when talking to its owner.</returns>
        public string TalkToOwner()
        {
            return "Chirp!";
        }
    }
}