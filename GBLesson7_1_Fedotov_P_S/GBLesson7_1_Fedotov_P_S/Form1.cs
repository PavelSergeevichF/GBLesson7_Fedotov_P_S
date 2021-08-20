using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBLesson7_1_Fedotov_P_S
{
    public partial class Form1 : Form, IView, IInfo
    {
        string IInfo.Task { set => TaskLabel.Text = value; }
        string IInfo.Info { set => InfoLabel.Text = value; }
        string IView.Number { set => LabelNumber.Text=value; }
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            Adapter adapter=null;
            ResetButton.Click += delegate { adapter = new Adapter(new Model(rnd.Next(20, 40)), this, this); };
            IncreaseButton.Click += delegate { adapter?.AddClick(); };
            GeminationButton.Click += delegate { adapter?.GeminationClick(); };
            BakcButton.Click += delegate { adapter?.BackStep(); };
        }
    }
}
