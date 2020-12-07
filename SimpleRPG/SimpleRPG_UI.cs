using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace SimpleRPG
{
    public partial class SimpleRPG : Form
    {
        private Player _player;
        public SimpleRPG()
        {
            InitializeComponent();

            _player = new Player();
            _player.CurrentHP = 10;
            _player.MaximumHP = 10;
            _player.Level = 1;
            _player.EXP = 0;
            _player.Gold = 20;

            lblHP.Text = _player.CurrentHP.ToString();
            lblLevel.Text = _player.Level.ToString();
            lblEXP.Text = _player.EXP.ToString();
            lblGold.Text = _player.Gold.ToString();
        }

    }
}
