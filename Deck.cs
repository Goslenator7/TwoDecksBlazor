namespace TwoDecksBlazor
{
    public class Deck : List<Card>
    {
        private readonly Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            this.Clear();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 0; value <= 13; value++)
                {
                    this.Add(new Card((Values)value, (Suits)suit));
                }
            }
        }


    }
}
