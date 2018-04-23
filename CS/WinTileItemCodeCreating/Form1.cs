using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinTileItemCodeCreating {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void contentGenerate_Click(object sender, EventArgs e) {
            TileItem newTile = new TileItem();
            //First Frame - Image only
            TileItemFrame logoDXFrame = new TileItemFrame();
            logoDXFrame.UseImage = true;
            logoDXFrame.UseText = true;
            logoDXFrame.AnimateImage = true;
            logoDXFrame.AnimateText = true;
            TileItemElement logoEl = new TileItemElement();
            logoEl.Image = global::WinTileItemCodeCreating.Properties.Resources.DXv2Logo_small;logoEl.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            logoDXFrame.Elements.Add(logoEl);
            logoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            //Second Frame - Text only
            TileItemFrame mottoDXFrame = new TileItemFrame();
            TileItemElement mottoEl = new TileItemElement();
            mottoEl.Text = "<Size=+2><Color=Sienna><b>Let's see what develops.</b></Color></Size>";
            mottoEl.TextAlignment = TileItemContentAlignment.MiddleCenter;
            mottoDXFrame.Elements.Add(mottoEl);
            mottoDXFrame.Elements[0].AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            mottoDXFrame.UseImage = true;
            mottoDXFrame.UseText = true;
            mottoDXFrame.AnimateImage = true;
            mottoDXFrame.AnimateText = true;
            //Global Tile Item Settings
            newTile.Frames.Add(logoDXFrame);
            newTile.Frames.Add(mottoDXFrame);
            newTile.Appearance.BackColor = System.Drawing.Color.Bisque;
            newTile.Appearance.BackColor2 = System.Drawing.Color.SandyBrown;
            newTile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            newTile.Appearance.BorderColor = System.Drawing.Color.Bisque;
            newTile.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            newTile.FrameAnimationInterval = 2500;
            newTile.IsLarge = true;
            tileControl1.Groups.Add(new TileGroup());
            tileControl1.Groups[0].Items.Add(newTile);
            newTile.StartAnimation();
        }
    }
}