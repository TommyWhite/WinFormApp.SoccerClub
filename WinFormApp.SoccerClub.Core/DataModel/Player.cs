using System;

namespace WinFormApp.SoccerClub.Core.DataModel
{
    /// <summary>
    /// Football player data model.
    /// </summary>
    public class Player : IComparable, IEquatable<Player>
    {
        /// <summary>
        /// Player id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Player name of fullname.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Player age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Player's current position.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns
        /// an integer that indicates whether the current instance precedes, follows, or
        /// occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The
        /// return value has these meanings: Value Meaning Less than zero This instance precedes
        /// obj in the sort order. Zero This instance occurs in the same position in the
        /// sort order as obj. Greater than zero This instance follows obj in the sort order.
        /// </returns>
        public int CompareTo(object obj)
        {
            if (obj is Player)
            {
                Player otherPlayer = (Player)obj;
                return Id.CompareTo(otherPlayer.Id);
            }
            else
            {
                throw new ArgumentException("Instances of different types are not comparable.", nameof(obj));
            }
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>True if the current object is equal to the other parameter; otherwise, false.</returns>
        public bool Equals(Player other)
        {
            return Name == other.Name
                && Age == other.Age
                && Position == other.Position;
        }
    }
}