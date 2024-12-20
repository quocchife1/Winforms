﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyWarriorsClashofTitans
{
    public partial class PauseScreen : Form
    {
        public bool IsResume {  get;private set; }
        SoundPlayer hoverSound;
        SoundPlayer clickSound;
        public PauseScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void playHoverSound()
        {
            hoverSound = new SoundPlayer(@"SE2.wav");
            hoverSound.Play();
        }
        private void playClickSound()
        {
            clickSound = new SoundPlayer(@"SE1.wav");
            clickSound.Play();
        }

        private void PauseScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                IsResume = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            playClickSound();
            IsResume = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            playClickSound();
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void ResumeBtn_MouseHover(object sender, EventArgs e)
        {
            playHoverSound();
            ResumeBtn.Image = Properties.Resources.resume_hover;
        }

        private void ResumeBtn_MouseLeave(object sender, EventArgs e)
        {
            ResumeBtn.Image= Properties.Resources.ResumeBtn;
        }

        private void BackBtn_MouseHover(object sender, EventArgs e)
        {
            playHoverSound();
            BackBtn.Image = Properties.Resources.Back_hover;
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.Image = Properties.Resources.BackBtn__2_;
        }
    }
}
