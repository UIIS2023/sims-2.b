﻿using InitialProject.Domain.Model;
using InitialProject.WPF.ViewModel;
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
using System.Windows.Navigation;

namespace InitialProject.WPF.View
{
    /// <summary>
    /// Interaction logic for GuideRatings.xaml
    /// </summary>
    public partial class GuideRatings : Page
    {
        public GuideRatings(GuideRatingsViewModel guideRatingsViewModel)
        {
            InitializeComponent();
            DataContext = guideRatingsViewModel;
        }


    }
}
