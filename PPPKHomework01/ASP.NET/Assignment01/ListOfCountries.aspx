<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListOfCountries.aspx.cs" Inherits="Assignment01.ListOfCountries" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .okvir{border:1px solid #cccccc; width:120px; height:22px;}
        .celija{vertical-align:top;}
        .style4
        {
            width: 60px;
            text-align:right;
        }
        .style5
        {
            width: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
      <fieldset><legend>List of countries</legend>
          <table cellpadding="5" cellspacing="0" class="style1">
              <tr>
                  <td class="style4" style="text-align:left">
                      <asp:ListBox ID="lbCountry" runat="server" Width="150px" SelectionMode="Multiple"></asp:ListBox>
                  </td>  
              </tr>
              <tr>
                  <td>
                      <asp:Button ID="Button1" runat="server" CssClass="okvir" Font-Bold="True"
                          Font-Size="11px" Height="30px" Text="Delete from DB"
                          Width="125px" BackColor="Red" OnClick="Button1_Click"
                          ForeColor="White" />
                  </td>
              </tr>
          </table>
</fieldset> 
        <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="11px" 
            ForeColor="Red"></asp:Label>

</asp:Content>
