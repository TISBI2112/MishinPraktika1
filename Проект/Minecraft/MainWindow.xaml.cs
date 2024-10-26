using Minecraft.BD;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Xml.Linq;

namespace Minecraft
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CBAuthor.ItemsSource = App.BD.Music.ToList();
            CBSort.Items.Add("По Алфавиту Авторов");
            CBSort.Items.Add("По Алфавиту Названий");

            ListMusic.ItemsSource = App.BD.Music.ToList();
        }

        private void Sell(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Жители пока не хотят торговать", "Что-то пошло не так");
        }

        private void Broke(object sender, RoutedEventArgs e)
        {
            var music = (sender as Button).DataContext as BD.Music;
            App.BD.Music.Remove(music);
            App.BD.SaveChanges();
            ListMusic.ItemsSource = App.BD.Music.ToList();
        }

        private void CBAuthor_SC(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
        
        private void Refresh()
        {
            var Filtr = App.BD.Music.ToList();
            var SelectedAuthor = CBAuthor.SelectedItem as Music;
            var SerchText = TBSerch.Text;
            var SortSelectedIndex = CBSort.SelectedIndex;

            if (SelectedAuthor != null)
            {
                Filtr = Filtr.Where(x => x.Author == SelectedAuthor.Author).ToList();
            }
            
            if (!string.IsNullOrWhiteSpace(SerchText)) 
            {
                Filtr = Filtr.Where(x => x.Name.Contains(SerchText) || x.Author.Contains(SerchText)).ToList();
            }

            if (SortSelectedIndex == 0) 
            { 
                Filtr = Filtr.OrderBy(x => x.Author).ToList();
            }

            if (SortSelectedIndex == 1)
            {
                Filtr = Filtr.OrderBy(x => x.Name).ToList();
            }

            ListMusic.ItemsSource = Filtr.ToList();
        }

        private void TBSerch_TC(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            TBSerch.Text = "";
            CBSort.SelectedItem = null;
            CBAuthor.SelectedItem = null;
            Refresh();
        }

        private void CBSort_SC(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}