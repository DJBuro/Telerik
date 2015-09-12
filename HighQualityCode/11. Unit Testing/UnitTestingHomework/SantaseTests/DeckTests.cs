using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Santase.Logic.Cards;
using NUnit.Framework;
using Santase.Logic;

namespace SantaseTests
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void DeckMustContain24CardsInBegining()
        {
            Deck deck = new Deck();
            Assert.AreEqual(deck.CardsLeft, 24);
        }
        [TestCase(7)]
        public void DeckMustContain17cardsAfterDrawn(int cardDrawnCount)
        {
            Deck deck = new Deck();

            for (int i = 0; i < cardDrawnCount; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(deck.CardsLeft, 17);
        }

        [TestCase(25)]
        [ExpectedException(typeof (InternalGameException))]
        public void InternalGameExceptionShouldBeThrownIfGetNextCardIsCallesAndDeckIsEmpty(int cardDrawnCount)
        {
            Deck deck = new Deck();

            for (int i = 0; i < cardDrawnCount; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void TrumbCardMustBeChangedWithArgumentCardWhenChangeTrumpCardMethodIsCalled()
        {
            Deck deck = new Deck();
            Card card = new Card(CardSuit.Club, CardType.Jack); 
            deck.ChangeTrumpCard(card);
            Assert.AreEqual(deck.GetTrumpCard, card);
            
        }

       
     
    }
}
