using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using BetterTowerDomain.Tower;
using BetterTowerDomain.Ui.Annotations;

namespace BetterTowerDomain.Ui.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int range;
        private Game game;
        

        public MainViewModel()
        {
            this.game = new Game(Difficulty.Medium);
            this.Towers = new ObservableCollection<ITower>();
            AddTower();
        }

        private void AddTower()
        {
            this.game.CreateNewTower();
            this.OnPropertyChanged("Towers");

            RenewTowers();
        }

        private IEnumerable<ITower> towers
        {
            get { return this.game.Towers; }
        }

        public ObservableCollection<ITower> Towers
        {
            get; private set;
        }

        public double DisplayedRange
        {
            get 
            {
                return this.SelectedTower != null ? this.SelectedTower.Range : 0;
            }
        }

        public double DisplayedDamage
        {
            get
            {
                return this.SelectedTower != null ? this.SelectedTower.Damage : 0;
            }
        }

        public int DisplayedLevel
        {
            get
            {
                return this.SelectedTower != null ? this.SelectedTower.Level : 0;
            }
        }

        private ITower selectedTower;

        public ITower SelectedTower
        {
            get { return selectedTower; }
            set
            {
                this.selectedTower = value;
                this.OnPropertyChanged("DisplayedRange");
                this.OnPropertyChanged("DisplayedDamage");
                this.OnPropertyChanged("DisplayedLevel");
            }
                
        }

        public void ChangeSelectionTo(ITower tower)
        {
            this.SelectedTower = tower;
        }

        public void UpgradeRange()
        {
            try
            {
                if (this.SelectedTower != null)
                {
                    this.game.UpgradeRangeFromTower(SelectedTower);
                    this.OnPropertyChanged("DisplayedRange");
                    this.RenewTowers();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You cannot upgrade this tower any further", "Error");
            }
            
        }

        public void UpgradeDamage()
        {
            try
            {
                if (this.SelectedTower != null)
                {
                    this.game.UpgradeDamageFromTower(this.SelectedTower);
                    this.OnPropertyChanged("DisplayedDamage");
                    this.RenewTowers();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You cannot upgrade this tower any further", "Error");
            }
        }

        public void CreateTower()
        {
            this.AddTower();
        }

        private void RenewTowers()
        {
            this.Towers.Clear();

            foreach (var tower in this.towers)
            {
                this.Towers.Add(tower);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}