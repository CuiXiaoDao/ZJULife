﻿

#pragma checksum "D:\OneDrive\Documents\Visual Studio 2015\Projects\ZJULife\ZJULife\Map.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C5F7A3EC78A180DC53BA961D29508BF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZJULife
{
    partial class Map : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PlacesButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 75 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.LocationButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 60 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).TextChanged += this.AutoSuggestBox_TextChanged;
                 #line default
                 #line hidden
                #line 60 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.FindRouteTextBox_KeyDown;
                 #line default
                 #line hidden
                #line 61 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.PositionTextBox_GotFocus;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 68 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).TextChanged += this.AutoSuggestBox_TextChanged;
                 #line default
                 #line hidden
                #line 68 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.FindRouteTextBox_KeyDown;
                 #line default
                 #line hidden
                #line 69 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.PositionTextBox_GotFocus;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 42 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).TextChanged += this.AutoSuggestBox_TextChanged;
                 #line default
                 #line hidden
                #line 42 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target)).SuggestionChosen += this.FindPositionTextBox_SuggestionChosen;
                 #line default
                 #line hidden
                #line 43 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.PositionTextBox_GotFocus;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 88 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.Maps.MapControl)(target)).MapTapped += this.MyMap_MapTapped;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 121 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.CampusComboBox_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 139 "..\..\..\Map.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ListView_ItemClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


