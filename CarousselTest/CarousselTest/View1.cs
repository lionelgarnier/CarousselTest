﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CarousselTest
{
    public class View1 : ContentView
    {
        public View1()
        {
            Content = new Label { Text = "Hello ContentView", BackgroundColor = Color.Red };
        }
    }
}
