using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Card_Game
{
    public partial class Form1 : Form
    {
        Random rdm = new Random();
        Deck deck1;
        Deck deck2;
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }
        private void ResetDeck(int deckNumber)
        {
            if(deckNumber == 1)
            {
                int numberOfCards = rdm.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for(int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card(rdm.Next(4), rdm.Next(1, 14)));
                }
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }
        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                listBox1.Items.Clear();
                string[] names = deck1.GetCardNames();
                foreach (string cardName in deck1.GetCardNames())
                {
                    if(cardName != null)
                    {
                        listBox1.Items.Add(cardName);
                    }
                    
                }
                label1.Text = $"Deck #1 {deck1.Count} cards";
            }
            else
            {
                listBox2.Items.Clear();
                string[] names = deck2.GetCardNames();
                foreach(string cardName in deck2.GetCardNames())
                {
                    if(cardName != null)
                    {
                        listBox2.Items.Add(cardName);
                    }                    
                }
                label2.Text = $"Deck #2 {deck2.Count} cards";
            }
        }

        private void MoveToDeck1Button_Click(object sender, EventArgs e)
        {
            int IndexCardToMove = listBox2.SelectedIndex;
            if (IndexCardToMove >= 0 && deck2.Count > 0)
            {
                deck1.Add(deck2.Deal(IndexCardToMove));
                RedrawDeck(1);
                RedrawDeck(2);
            }
                
            
        }
        

        private void ShuffleDeck1Button_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void ShuffleDeck2Button_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void ResetDeck1Button_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void ResetDeck2Button_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void MoveToDeck2Button_Click(object sender, EventArgs e)
        {
            int IndexCardToMove = listBox1.SelectedIndex;
            if (IndexCardToMove >= 0 && deck1.Count > 0)
            {
                deck2.Add(deck1.Deal(IndexCardToMove));
                RedrawDeck(1);
                RedrawDeck(2);
            }
        }
    }
}
