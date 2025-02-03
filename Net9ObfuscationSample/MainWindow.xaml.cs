using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace Net9ObfuscationSample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private const string CorrectPasswordHash = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8"; // Example hash for "password"

    public MainWindow()
    {
        InitializeComponent();
    }

    private void CheckPassword_Click(object sender, RoutedEventArgs e)
    {
        string enteredPassword = PasswordBox.Password;
        string enteredPasswordHash = ComputeSha256Hash(enteredPassword);

        if (enteredPasswordHash == CorrectPasswordHash)
        {
            ResultTextBlock.Text = "Password is correct!";
            ResultTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Green);
        }
        else
        {
            ResultTextBlock.Text = "Incorrect password!";
            ResultTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
        }
    }

    private string ComputeSha256Hash(string rawData)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}

