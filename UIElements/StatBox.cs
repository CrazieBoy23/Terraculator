using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace TerrariaCalculator
{
    public partial class StatBox : UserControl
    {
        private string inputValue = "";
        private bool ValidInput = true;
        public StatBox()
        {
            InitializeComponent();
            this.Resize += StatBox_Resize;
            InputBox.TextChanged += ReadInput;
        }
        public void StatBox_Resize(object? sender, EventArgs e)
        {
            StatDescription.Left = (this.ClientSize.Width - StatDescription.Width) / 2;
            InputBox.Left = (this.ClientSize.Width - InputBox.Width) / 2;
        }
        private void ReadInput(object? sender, EventArgs e)
        {
            inputValue = InputBox.Text;
            bool isFloat = float.TryParse(inputValue, out float result);
            if (isFloat || inputValue == "")
            {
                System.Diagnostics.Debug.WriteLine(inputValue);
                if(!ValidInput)
                {
                    ValidInput = true;
                    WarningText.Visible = false;
                } 
            }
            else if (ValidInput)
            {
                ValidInput = false;
                WarningText.Visible = true;
            }
        }
        public string GetInput()
        {
            if(ValidInput)
            {
                return inputValue;
            }
            return "";
        }
        public string LabelText
        {
            get => StatDescription.Text;
            set => StatDescription.Text = value;
        }
    }
}
