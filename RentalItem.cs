namespace LatefeeCalc_c0842810
{
    public class RentalItem
    {
        //public field
        private int movieNo;
        private string description;
        private string rating;

        /// <summary>
        /// No-argument constructor
        /// </summary>
        public RentalItem() { }

        /// <summary>
        /// Three argument constructor
        /// </summary>
        /// <param name="movieNo">string </param>
        /// <param name="description">string</param>
        /// <param name="price">decimal</param>
        public RentalItem(int movieNo, string description, string rating) {
            this.movieNo = movieNo;
            this.description = description;
            this.rating = rating;
        }
        public int MovieNo
        {
            get { return movieNo; }
            set { movieNo = value; }
        }

        public string Description { 
            get { return description; }
            set { description = value; }
        }

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        /// <summary>
        /// Return a string that contains the movie`s number, description and rating
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return movieNo.ToString() + "  " + description + "  " + rating;
        }
    }
}
