using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_DB
{
    class SmartCard
    {
        private string CardId;
        private string CardContent;

        private CardMeta CardProperties = new CardMeta();


        public SmartCard(string cardId)
        {
            CardId = cardId;
        }
        public SmartCard(string cardId, string cardContent)
        {
            CardId = cardId;
            CardContent = cardContent;

        }

        public bool NewCard()
        {
            return true;
        }

        public bool RemoveCard()
        {
            return true;
        }

        public bool UpdateCard()
        {
            return true;
        }
    }
}
