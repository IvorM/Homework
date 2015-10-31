<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="InsertCountry.aspx.cs" Inherits="Assignment01.InsertCountry" %>
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
      <fieldset><legend>Add country</legend>
          <table cellpadding="5" cellspacing="0" class="style1">
              <tr>
                  <td class="style4" style="text-align:left">
                      <asp:Label ID="lblCountryName" runat="server" Text="Country name:"></asp:Label>
                  </td>  
                  <td style="text-align:left">
                      <asp:TextBox ID="tbCountryName" runat="server"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>&nbsp;</td>
                  <td style="text-align:left">
                      <asp:Button ID="btnAddCountry" runat="server" CssClass="okvir" Font-Bold="True"
                          Font-Size="11px" Height="30px" Text="Add country to DB"
                          Width="125px" BackColor="Green" OnClick="btnAddCountry_Click" 
                          ForeColor="White" />
                  </td>
              </tr>
          </table>
</fieldset> 

        <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="11px" 
            ForeColor="Green"></asp:Label>

</asp:Content>
