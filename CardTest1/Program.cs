//foreach (Card card in Deck.DeckOfCards()) {
//	Console.WriteLine(card);
//}

List<Card> shuffledDeck = Deck.GetShuffledDeck(Deck.GetDeckOfCards()).ToList();

foreach (Card card in shuffledDeck) {
	Console.WriteLine(card);
}
Console.WriteLine($"Count: {shuffledDeck.Count}");
foreach (Card card in shuffledDeck) {
	Console.WriteLine(card);
}
Console.WriteLine($"Count: {shuffledDeck.Count}");
