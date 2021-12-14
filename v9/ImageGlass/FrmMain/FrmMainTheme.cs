﻿
using ImageGlass.Settings;
using ImageGlass.UI;

namespace ImageGlass;

public partial class FrmMain
{

    public void SetUpFrmMainTheme()
    {
        Load += FrmMainTheme_Load;


        // set toolbar theme
        Toolbar.Theme = Config.Theme;

        BackColor = Config.Theme.Settings.BgColor;

        // Thumbnail bar
        Sp1.SplitterBackColor =
            PanBot.BackColor = Config.Theme.Settings.ThumbnailBarBgColor;

        // Side panels
        Sp2.SplitterBackColor =
            Sp3.SplitterBackColor =
            PanLeft.BackColor =
            PanRight.BackColor = Config.Theme.Settings.ThumbnailBarBgColor;
    }


    private void FrmMainTheme_Load(object? sender, EventArgs e)
    {
        UpdateTheme();
    }


    private void UpdateTheme(SystemThemeMode theme = SystemThemeMode.Unknown)
    {
        //var newTheme = theme;
        //if (theme == SystemThemeMode.Unknown)
        //{
        //    newTheme = ThemeUtils.GetSystemThemeMode();
        //}

        //if (newTheme == SystemThemeMode.Light)
        //{
        //    BackColor = Color.FromArgb(255, 255, 255, 255);
        //}
        //else
        //{
        //    BackColor = Color.FromArgb(255, 26, 34, 39);
        //}
    }

}
