using PokerOddsPro.OddsEngine.Dto;
using PokerOddsPro.Shared.Helpers;
using PokerOddsPro.Shared.Services;
using PokerOddsPro.Shared.ViewModels;

namespace PokerConsoleApp;

// https://github.com/dyh1213/PokerOddsPro

class Program
{
    // PokerOddsPro.Shared/Pages/Index.razor
    private static HoldemCardGameManager _cardGameController { get; set; }
    private static int PlayerCount => _cardGameController.Players.Count();

    static async Task Main(string[] args)
    {
        Console.WriteLine("♥♣♦♠");

        await CalculateOdds();

        Console.WriteLine("Press <Enter> to close");
        Console.ReadLine();
    }

    // PokerOddsPro.Shared/Pages/Index.razor
    //Task AddPlayer() => await _cardGameController.AddPlayer();
    //Task RemovePlayer(PlayerController player) => await _cardGameController.RemovePlayer(player);

    // PokerOddsPro.Shared/Components/CardSelectionPanel.razor
    //private async Task SetSelectedCard(Card CardInfo) => await _cardGameController.SetSelectedCard(CardInfo);


    static async Task CalculateOdds()
    {

        // PokerOddsPro.Shared/Pages/Index.razor
        _cardGameController = new HoldemCardGameManager(numberOfPlayers: 2, minimumBoardCards: 2);

        // Print all cards to get details for below.
        //var cards = Helper.GetAllCards();
        //cards.ForEach(Console.WriteLine);

        // PokerOddsPro.Shared/Components/CardSelectionPanel.razor
        // SetSelectedCard

        //CardSlot cardSlot;
        //cardSlot.SelectCardSlot();

        // Set the first card of the first player as selected??
        _cardGameController.Players.FirstOrDefault().Cards.FirstOrDefault().SelectCardSlot();
        var cardSlot = _cardGameController.Players.FirstOrDefault().Cards.FirstOrDefault();
        _cardGameController.UpdateSelectedCard(cardSlot);

        // ♥♣♦♠
        // Player 1
        Card card1 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 1, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Club } }; // 2♣
        await _cardGameController.SetSelectedCard(card1);
        PrintCards();

        Card card2 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 3, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Club } }; // 3♣
        await _cardGameController.SetSelectedCard(card2);
        PrintCards();

        // Player 2
        Card card3 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        await _cardGameController.SetSelectedCard(card3);
        Card card4 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 28, CardNumber = CardNumberEnum.Three, CardSuit = CardSuitEnum.Heart } }; // 3♥
        await _cardGameController.SetSelectedCard(card4);

        // Board
        Card flop1 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 42, CardNumber = CardNumberEnum.Four, CardSuit = CardSuitEnum.Spade } }; // 4♠
        await _cardGameController.SetSelectedCard(flop1);
        Card flop2 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 43, CardNumber = CardNumberEnum.Five, CardSuit = CardSuitEnum.Spade } }; // 5♠
        await _cardGameController.SetSelectedCard(flop2);
        Card flop3 = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 44, CardNumber = CardNumberEnum.Six, CardSuit = CardSuitEnum.Spade } }; // 6♠
        await _cardGameController.SetSelectedCard(flop3);
        //Card turn = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        //await _cardGameController.SetSelectedCard(turn);
        //Card river = new Card() { IsAvailable = false, CardInfo = new CardInfo() { CardId = 27, CardNumber = CardNumberEnum.Two, CardSuit = CardSuitEnum.Heart } }; // 2♥
        //await _cardGameController.SetSelectedCard(river);

        PrintCards();

        Console.WriteLine("%s");
        _cardGameController.Players.ForEach(p => Console.WriteLine($"{p.WinPercentage} {p.TiePercentage} {p.LoosePercentage}"));
    }

    static void PrintCards()
    {
        Console.WriteLine("Player's cards:");
        _cardGameController.Players.ForEach(p =>
        {
            p.Cards.ForEach(c => Console.WriteLine(c.Card));
        });
    }
}

