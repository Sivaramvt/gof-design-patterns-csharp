using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightObject
{
    //Flyweight object
    class Character
    {
        char _value;
        Style _style;

        public Character(Style style, char value)
        {
            this._style = style;
            this._value = value;
        }

        public string getCharacterColor()
        {
            return _style._fontColor;
        }
    }
}
