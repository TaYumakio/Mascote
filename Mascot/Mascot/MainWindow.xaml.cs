﻿using System;
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

namespace Mascot {
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
      timer.Tick += new EventHandler(TimerTick);
      timer.Interval = new TimeSpan(0, 0, 3);
      timer.Start();
    }

    private void TimerTick(object sender, EventArgs e) {
      MainWindow1.Left += 10;
      MainWindow1.Top += 10;
      
    }
  }
}