﻿using AirportTimetable.Models;
using AirportTimetableWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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

namespace AirportTimetableWPF
{
    /// <summary>
    /// Логика взаимодействия для TimeTableColumn.xaml
    /// </summary>
    public partial class TimeTableColumn : UserControl
    {
        public List<Flight> context = new List<Flight>();
        public Property Font = new Property();
        public TimeTableColumn()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            list.DataContext = Font;
            list.ItemsSource = context;
        }
    }
}
