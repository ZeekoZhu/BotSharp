﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Rasa.Adapters.Dialogflow
{
    public class DialogflowIntentExpressionPart
    {
        public String Text { get; set; }
        public String Alias { get; set; }
        public String Meta { get; set; }
        public Boolean UserDefined { get; set; }
    }
}