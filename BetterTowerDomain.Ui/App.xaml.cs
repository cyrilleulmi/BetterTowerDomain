﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BetterTowerDomain.Ui.ViewModel;

namespace BetterTowerDomain.Ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mWindow = new MainWindow();
            MainViewModel mainViewModel = new MainViewModel();

            mWindow.DataContext = mainViewModel;
            mWindow.ShowDialog();
            Application.Current.Shutdown();
        }
    }
}
