using SharpimoteClient.Credentials;
using SharpimoteClient.Networking;
using SharpimoteClient.Networking.CredentialsSenderClient;
using SharpimoteClient.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SharpimoteClient
{
    /// <summary>
    /// Interaction logic for ConnectionRecords.xaml
    /// </summary>
    public partial class ConnectionRecords : Page
    {
        private PasswordSeeker seeker;
        public ConnectionRecords()
        {
            InitializeComponent();
            InitializeCred();
            InitializeClient();
            seeker = new(PasswordText, passwordField);
        }
        private void InitializeCred()
        {
            CodeText.Text = CredGenerator.GenerateCode();
            PasswordText.Text = CredGenerator.GeneratePassword();
            passwordField.Password = PasswordText.Text;
        }

        private void RefreshCode_MouseUp(object sender, MouseButtonEventArgs e)
        {
            CodeText.Text = CredGenerator.GenerateCode();
        }

        private void RefreshPassword_MouseUp(object sender, MouseButtonEventArgs e)
        {
            PasswordText.Text = CredGenerator.GeneratePassword();
            passwordField.Password = PasswordText.Text;
        }

        private void SeekPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            seeker.Seek();
        }
        private void SeekPassword_MouseUp(object sender, MouseButtonEventArgs e)
        {
            seeker.Hide();
        }
        private void InitializeClient()
        {
            CredentialsJSON initialCreds = new CredentialsJSON(NetworkProvider.GetLocalIPAddress(), CodeText.Text, passwordField.Password);
            CredClientManager client = new CredClientManager();
            client.StartClient();
            client.SerializeCredAndSend(initialCreds);
        }
    }
}
