using System;
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

namespace WindowsPhoneApplication1
{
    public partial class fullBlackAndWhite : PhoneApplicationPage
    {
        public fullBlackAndWhite()
        {
            InitializeComponent();
        }

        private void ContentPanel_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	// TODO: Add event handler implementation here.
			  this.black_and_white.Begin();
		
			

        }
    }
}
