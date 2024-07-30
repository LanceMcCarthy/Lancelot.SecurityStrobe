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
using Microsoft.Phone.Tasks;

namespace SecurityStrobe
{
    public partial class shapesPage : PhoneApplicationPage
    {
        public shapesPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposer = new EmailComposeTask();
            emailComposer.To = "lancewmccarthy@gmail.com";
            emailComposer.Body = "";
            emailComposer.Subject = "SecurityStrobe";
            emailComposer.Show();
        }
    }
}
