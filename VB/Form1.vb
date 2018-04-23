Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WinTileItemCodeCreating
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub contentGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles contentGenerate.Click
			Dim newTile As TileItem = New TileItem()
			'First Frame - Image only
			Dim logoDXFrame As TileItemFrame = New TileItemFrame()
			logoDXFrame.UseImage = True
			logoDXFrame.UseText = True
			logoDXFrame.AnimateImage = True
			logoDXFrame.AnimateText = True
			Dim logoEl As TileItemElement = New TileItemElement()
            logoEl.Image = Global.Resources.DXv2Logo_small
			logoEl.ImageAlignment = TileItemContentAlignment.MiddleCenter
			logoDXFrame.Elements.Add(logoEl)
			logoDXFrame.Elements(0).AnimateTransition = DevExpress.Utils.DefaultBoolean.True
			'Second Frame - Text only
			Dim mottoDXFrame As TileItemFrame = New TileItemFrame()
			Dim mottoEl As TileItemElement = New TileItemElement()
			mottoEl.Text = "<Size=+2><Color=Sienna><b>Let's see what develops.</b></Color></Size>"
			mottoEl.TextAlignment = TileItemContentAlignment.MiddleCenter
			mottoDXFrame.Elements.Add(mottoEl)
			mottoDXFrame.Elements(0).AnimateTransition = DevExpress.Utils.DefaultBoolean.True
			mottoDXFrame.UseImage = True
			mottoDXFrame.UseText = True
			mottoDXFrame.AnimateImage = True
			mottoDXFrame.AnimateText = True
			'Global Tile Item Settings
			newTile.Frames.Add(logoDXFrame)
			newTile.Frames.Add(mottoDXFrame)
			newTile.Appearance.BackColor = System.Drawing.Color.Bisque
			newTile.Appearance.BackColor2 = System.Drawing.Color.SandyBrown
			newTile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
			newTile.Appearance.BorderColor = System.Drawing.Color.Bisque
			newTile.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
			newTile.FrameAnimationInterval = 2500
			newTile.IsLarge = True
			tileControl1.Groups.Add(New TileGroup())
			tileControl1.Groups(0).Items.Add(newTile)
			newTile.StartAnimation()
		End Sub
	End Class
End Namespace
