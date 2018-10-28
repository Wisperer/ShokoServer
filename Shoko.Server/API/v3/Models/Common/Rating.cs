namespace Shoko.Server.API.v3
{
    /// <summary>
    /// Rating object. Shared between sources, episodes vs series, etc
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// rating
        /// </summary>
        public decimal rating { get; set; }
        
        /// <summary>
        /// out of what? Assuming int, as the max should be
        /// </summary>
        public int max_rating { get; set; }
        
        /// <summary>
        /// AniDB, etc
        /// </summary>
        public string source { get; set; }
        
        /// <summary>
        /// number of votes
        /// </summary>
        public int votes { get; set; }
        
        /// <summary>
        /// for temporary vs permanent, or any other situations that may arise later
        /// </summary>
        public string type { get; set; }
    }
}