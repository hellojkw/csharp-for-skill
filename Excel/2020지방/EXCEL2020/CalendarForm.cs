﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL2020
{
    public partial class CalendarForm : Form
    {
        List<Label> _labels;
        List<Button> _buttons;

        public CalendarForm()
        {
            InitializeComponent();

            InitLabels();
            InitButtons();

            InitDate(DateTime.Now.Year, DateTime.Now.Month);
        }

        private void InitLabels()
        {
            _labels = new List<Label>
            {
                label0,
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
            };

            var days = new[] { "일", "월", "화", "수", "목", "금", "토", };

            _labels
                .Select((label, i) => new { Label = label, Index = i })
                .ToList()
                .ForEach(x =>
                {
                    x.Label.Top = label0.Top;
                    x.Label.Left = label0.Left + 40 * x.Index;
                    x.Label.Text = days[x.Index];
                });
        }

        private void InitButtons()
        {
            _buttons = new List<Button>
            {
                button0, button1, button2, button3, button4, button5, button6,
                button7, button8, button9, button10, button11, button12, button13,
                button14, button15, button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25, button26, button27,
                button28, button29, button30, button31, button32, button33, button34,
                button35, button36, button37, button38, button39, button40, button41,
            };

            _buttons
                .Select((button, i) => new { Button = button, Index = i })
                .ToList()
                .ForEach(x =>
                {
                    var row = x.Index / 7;
                    var column = x.Index % 7;
                    x.Button.Top = button0.Top + row * 40;
                    x.Button.Left = button0.Left + column * 40;
                    x.Button.Margin = new Padding(0);
                });
        }

        private void InitDate(int year, int month)
        {
            var firstDate = new DateTime(year, month, 1);
            var dayOfWeekIndex = (int)firstDate.DayOfWeek;
            var lastDate = Enumerable.Range(28, 5)
                .Select(x => firstDate.AddDays(x))
                .Where(x => x.Month == firstDate.Month)
                .Last();

            _buttons
                .Select((button, i) => new { Button = button, Index = i })
                .ToList()
                .ForEach(x =>
                {
                    if (x.Index >= dayOfWeekIndex
                        && x.Index <= dayOfWeekIndex + lastDate.Subtract(firstDate).TotalDays)
                    {
                        x.Button.Text = (x.Index - dayOfWeekIndex + 1).ToString();
                    }
                    else
                    {
                        x.Button.Visible = false;
                    };
                });

            TitleLabel.Text = $"{year}년 {month}월";
        }
    }
}
