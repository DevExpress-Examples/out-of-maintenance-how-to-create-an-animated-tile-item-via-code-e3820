<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616518/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3820)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinTileItemCodeCreating/Form1.cs)
<!-- default file list end -->
# How To: Create An Animated Tile Item Via Code


<p>This example demonstrates how implement animation for a Tile.</p><p>In the example, two frames are added. The first frame will display a company logo, and the second one - its motto.</p><p>Neither frame uses a background image. Background colors are specified by the parent tile item itself via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressUtilsAppearanceObject_BackColortopic"><u>Backcolor</u></a><strong> </strong>and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressUtilsAppearanceObject_BackColor2topic"><u>Backcolor2</u></a> properties, so the frames' <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsTileItemFrame_AnimateBackgroundImagetopic"><u>AnimateBackgroundImage</u></a> property is set to <strong>false </strong>to prevent the background from being animated.</p><p>Note that the text in the second frame is formatted using HTML tags.</p>

<br/>


