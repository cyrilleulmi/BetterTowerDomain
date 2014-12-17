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
using BetterTowerDomain.Tower;
using BetterTowerDomain.Ui.ViewModel;

namespace BetterTowerDomain.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private MainViewModel context
        {
            get
            {
                return (MainViewModel)this.DataContext;
            }
        }

        private void CreateTower_Click(object sender, RoutedEventArgs e)
        {
            this.context.CreateTower();
        }

        private void UpgradeRange_Click(object sender, RoutedEventArgs e)
        {
            this.context.UpgradeRange();
        }

        private void UpgradeDamage_Click(object sender, RoutedEventArgs e)
        {
            this.context.UpgradeDamage();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.context.ChangeSelectionTo((ITower)((ListView)sender).SelectedItem);
        }
    }
}
