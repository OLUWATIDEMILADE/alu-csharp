// 4-enemy.cs
namespace Enemies
{
    /// <summary>
    /// Class that defines a Zombie.
    /// </summary>
    public class Zombie
    {
        // Private field 'health' without initial value
        private int health;

        // Private field 'name' with a default value in parentheses
        private string name = "(No name)";

        /// <summary>
        /// Default constructor that sets health to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Constructor that sets health to a specific value.
        /// </summary>
        /// <param name="value">The health value to set.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }

        /// <summary>
        /// Public property to get and set the name of the Zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Method to get the health of the Zombie.
        /// </summary>
        /// <returns>The current health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
