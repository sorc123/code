<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Recnik.aspx.cs" Inherits="Elektronski_recnik.Recnik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #TextArea1 {
        z-index: 1;
        left: 112px;
        top: 188px;
        position: absolute;
        height: 36px;
        width: 131px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="height: 366px; width: 601px">
    <asp:TextBox ID="TextBoxRec" runat="server" style="z-index: 1; left: 174px; top: 97px; position: absolute" CssClass="textbox"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 19px; top: 62px; position: absolute" Text="Smer prevodjenja:"></asp:Label>
    <asp:DropDownList ID="DropDownListSmer" runat="server" style="z-index: 1; left: 174px; top: 59px; position: absolute">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Srpsko - Engleski</asp:ListItem>
        <asp:ListItem>Englesko - Srpski</asp:ListItem>
    </asp:DropDownList>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 27px; top: 99px; position: absolute" Text="Rec za prevod:"></asp:Label>
    <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 25px; top: 142px; position: absolute" Text="Prevod:"></asp:Label>
    <asp:TextBox ID="TextBoxPrevod" runat="server" style="z-index: 1; left: 121px; top: 139px; position: absolute" ReadOnly="True" CssClass="textbox"></asp:TextBox>
    <asp:Button ID="ButtonPrevedi" runat="server" OnClick="ButtonPrevedi_Click" style="z-index: 1; left: 386px; top: 136px; position: absolute" Text="Prevedi" />
    <asp:Label ID="LabelGreska" runat="server" style="z-index: 1; left: 135px; top: 305px; position: absolute"></asp:Label>
    <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 25px; top: 182px; position: absolute" Text="Opis reci:"></asp:Label>
    <asp:TextBox ID="TextBoxOpis" runat="server" ReadOnly="True" style="z-index: 1; left: 115px; top: 179px; position: absolute; height: 47px; width: 138px" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
</p>
</asp:Content>
