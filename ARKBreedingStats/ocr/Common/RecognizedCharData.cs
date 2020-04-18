﻿using System;
using System.Collections.Generic;

namespace ARKBreedingStats.ocr.Common
{
    public class RecognizedCharData
    {
        public RecognizedCharData(int x, int y)
        {
            this.Coords = new Coords(x, y);
        }

        public Coords Coords { get; }

        public bool[,] Pattern { get; set; }

        public TextData ToCharData(string s)
        {
            return new TextData
            {
                Text = s,
                Patterns = new List<Pattern> { this.Pattern }
            };
        }
    }
}