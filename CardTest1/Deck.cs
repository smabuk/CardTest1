namespace CardTest1;

public class Deck {
	public static List<Card> DeckOfCards() =>
		Enum.GetValues<Suit>()
			.SelectMany(suit => Enum.GetValues<Rank>()
				.Select(rank => new Card(rank, suit)))
			.ToList();
}
