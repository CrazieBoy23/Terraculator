using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaCalculator
{
    public partial class Output : UserControl
    {
        public Output(Form1 form)
        {
            InitializeComponent();
            DamageOutput.Text = "0";
            SpeedOutput.Text = "-";
            CritChanceOutput.Text = "0";
            AvgDamageOutput.Text = "-";
        }
        public void TryCalculateAvg()
        {
            if (int.TryParse(DamageOutput.Text, out int damage) &&
                float.TryParse(SpeedOutput.Text, out float speed) &&
                float.TryParse(CritChanceOutput.Text, out float critChance))
            {
                float avgDamage = damage * (1 + critChance / 100) * speed;
                AvgDamageOutput.Text = avgDamage.ToString("0.###");
            }
            else
                AvgDamageOutput.Text = "-";
        }
    }
}
