using System.Windows;
using System.Windows.Media;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Esta linea NO SE TOCA, JAMAS DE LOS JAMASES //
            // Es el metodo que se encarga de crear los controladores en la vista a la 
            // hora de ejecutar el programa (Traducción de XAML a objetos de C#).
            InitializeComponent();
            
        }

        private void SaludarButton_Click(object sender, RoutedEventArgs e)
        {
            MensajeTextBlock.Text = "Hola " + NombreTextBox.Text + "!";
            MensajeTextBlock.Foreground = Brushes.Blue;
        }
    }
}
