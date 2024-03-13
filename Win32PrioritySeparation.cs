using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win32PrioritySeparationTool
{
    public partial class FormMain : UIForm
    {
        int? Win32PrioritySeparationValue;
        RegistryKey registryKey;
        public FormMain()
        {
            InitializeComponent();
            StyleManager.Style = UIStyle.Purple;
            registryKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\PriorityControl", true);
        }
        private int GetCurrentValueOfItemsIdx()
        {
            return cbg_options.Items.IndexOf(Win32PrioritySeparationValue.ToString());
        }
        private void LoadCurrentValue()
        {
            if (registryKey == null)
            {
                MessageBox.Show("Registry key not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Win32PrioritySeparationValue = (int)registryKey.GetValue("Win32PrioritySeparation");
            led_DisplayCurrentValue.Text = Win32PrioritySeparationValue.ToString();
        }
        private void cbg_options_Load(object sender, EventArgs e)
        {
            if (registryKey == null)
            {
                MessageBox.Show("Registry key not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadCurrentValue();
            var selectedIdx = cbg_options.Items.IndexOf(Win32PrioritySeparationValue.ToString());
            // if the value is not found, set the selected index to 0 and set registry value to first item of the options
            if(selectedIdx < 0)
            {
                selectedIdx = 0;
                var valueString = cbg_options.Items[selectedIdx].ToString();
                var value = Convert.ToInt32(valueString);
                registryKey.SetValue("Win32PrioritySeparation", value, RegistryValueKind.DWord);
                LoadCurrentValue();
            }
            cbg_options.SelectedIndexes = new List<int>() { selectedIdx };
        }

        private void cbg_options_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {
            if(registryKey == null)
            {
                MessageBox.Show("Registry key not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // default selected index
            var tmpIdx = e.SelectedIndexes.FirstOrDefault();

            // if more than 1 item selected, must set the item that not equal to current value
            if (e.SelectedIndexes.Count() > 1) 
                tmpIdx = e.SelectedIndexes.FirstOrDefault(x => x != GetCurrentValueOfItemsIdx());
            // if only 1 item selected and it's the same as current value, return
            else if (tmpIdx == e.SelectedIndexes.FirstOrDefault())
                return;

            cbg_options.SelectedIndexes.Clear();
            cbg_options.SelectedIndexes = new List<int>() { tmpIdx };

            var selectedValueString = cbg_options.Items[tmpIdx].ToString();
            var selectedValue = Convert.ToInt32(selectedValueString);

            if(selectedValue != Win32PrioritySeparationValue && Win32PrioritySeparationValue > 0)
            {
                registryKey.SetValue("Win32PrioritySeparation", selectedValue, RegistryValueKind.DWord);
                LoadCurrentValue();
            }
        }
    }
}
