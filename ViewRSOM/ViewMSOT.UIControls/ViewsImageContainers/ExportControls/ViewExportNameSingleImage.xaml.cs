﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ViewMSOT.UIControls
{
	/// <summary>
	/// Interaction logic for ViewSaveStudyAs.xaml
	/// </summary>
	public partial class ViewExportNameSingleImage : Window
	{
		public ViewExportNameSingleImage()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
	}
}