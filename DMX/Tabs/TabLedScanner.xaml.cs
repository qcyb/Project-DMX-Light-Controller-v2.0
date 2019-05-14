﻿using DMX.Entities;
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

namespace DMX.Tabs
{
    /// <summary>
    /// Interaction logic for TabLedScanner.xaml
    /// </summary>
    public partial class TabLedScanner : TabItem
    {
        public TabLedScanner(LedScanner ledScannerDevice)
        {
            InitializeComponent();
            this.DataContext = ledScanner = ledScannerDevice;
        }

        private LedScanner ledScanner;
        public LedScanner LedScanner
        {
            get { return ledScanner; }
            set { ledScanner = value; }
        }

    }
}
