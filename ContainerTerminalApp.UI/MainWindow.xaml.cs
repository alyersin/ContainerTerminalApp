﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContainerTerminalApp.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        string date = DateTime.Now.ToString("d.M.yy");
        this.Title = $"Container Terminal App - {date}.developer build";
    }




    private void UnitsTab_Loaded(object sender, RoutedEventArgs e)
    {

    }
}