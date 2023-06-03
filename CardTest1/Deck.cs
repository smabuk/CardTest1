namespace CardTest1;

public class Deck {
	public static List<Card> GetDeckOfCards() =>
		Enum.GetValues<Suit>()
			.SelectMany(suit => Enum.GetValues<Rank>()
				.Select(rank => new Card(rank, suit)))
			.ToList();

	public static IEnumerable<Card> GetShuffledDeck(IEnumerable<Card> deck) {
		List<Card> cards = new(deck);
		for (int i = cards.Count; i > 0; i--) {
			int ix = Random.Shared.Next(0, i);
			yield return cards[ix];
			cards.RemoveAt(ix);
		}
	}
}
