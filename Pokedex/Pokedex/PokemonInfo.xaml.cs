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
using System.Windows.Shapes;

namespace Pokedex
{
    /// <summary>
    /// Interaction logic for PokemonInfo.xaml
    /// </summary>
    public partial class PokemonInfo : Window
    {
        public PokemonInfo()
        {
            InitializeComponent();
        }

        private void buttonGetPokemon_Click(object sender, RoutedEventArgs e)
        {
            var pokemon = new Pokemon
            {
                pokemon = textBoxPokemonName

 
            };

        }
    }
}
