﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SecurityStrobe
{
    public partial class StarFlasherPage : PhoneApplicationPage
    {
        public StarFlasherPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.StarAnimation.Begin();
			
			// TODO: Add event handler implementation here.
        }
    }
}
