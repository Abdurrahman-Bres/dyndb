using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_DB
{
    class CardMeta
    {
        private float X;
        private float Y;
        private float Width;
        private float Height;
        private List<string> Tags;

        public CardMeta()
        {

        }

        public CardMeta(float x, float y, float width, float height)
        {
        X = x;
        Y = y;
        Width = width;
        Height = height;
        Tags = new List<string>();
        }

        public bool Move(float x, float y)
        {
            X = x;
            Y = y;

            return true;
        }

        public bool Resize(float width, float height)
        {
            Width = width;
            Height = height;

            return true;
        }

        public bool AddTag(string tag)
        {

            Tags.Add(tag);

            return true;
        }

        public bool RemoveTag(string tag)
        {
            Tags.Remove(tag);

            return true;
        }
    }
}
