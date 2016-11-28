using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightObject
{
    class Document
    {
        string _text;
        public List<Character> characters = new List<Character>();

        public Document(string input)
        {
            this._text = input;

            Style style = new Style();
            style._fontColor = "Red";
            style._fontName = "Times New Roman";
            style._fontSize = 12;


            foreach (char c in input)
            {
                characters.Add(new Character(style, c));
            }
        }
    }
}
