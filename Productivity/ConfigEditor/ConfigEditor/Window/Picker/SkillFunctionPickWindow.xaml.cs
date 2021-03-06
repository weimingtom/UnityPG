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
using System.Windows.Shapes;

namespace ConfigEditor
{
    /// <summary>
    /// Interaction logic for SkillFunctionPickWindow.xaml
    /// </summary>
    public partial class SkillFunctionPickWindow : Window
    {
        public Type PickedType;
        public String PickedName;


        public SkillFunctionPickWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lsbFunctions.ItemsSource = AssemblyManager.Instance.SkillFunctionTypes;
        }

        private void onBtn_Confirm(object sender, RoutedEventArgs e)
        {
            if (lsbFunctions.SelectedItem == null)
                return;

            KeyValuePair<string, Type> sel = (KeyValuePair<string, Type>)lsbFunctions.SelectedItem;
            DialogResult = true;
            PickedType = sel.Value;
            PickedName = sel.Key;
            this.Close();
        }

        private void onBtn_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
