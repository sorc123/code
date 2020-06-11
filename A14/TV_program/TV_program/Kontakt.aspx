<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="TV_program.Kontakt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 71px; position: absolute" Text="Ime:"></asp:Label>
<p style="height: 315px; width: 571px">
</p>
<asp:TextBox ID="TextBoxEmail" runat="server" style="z-index: 1; left: 124px; top: 109px; position: absolute"></asp:TextBox>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 21px; top: 113px; position: absolute" Text="Email:"></asp:Label>
<asp:TextBox ID="TextBoxIme" runat="server" style="z-index: 1; left: 124px; top: 68px; position: absolute"></asp:TextBox>
<asp:Label ID="Label3" runat="server" style="z-index: 1; left: 23px; top: 150px; position: absolute" Text="Naslov:"></asp:Label>
<asp:Label ID="Label4" runat="server" style="z-index: 1; left: 25px; top: 192px; position: absolute" Text="Sardrzaj:"></asp:Label>
<asp:TextBox ID="TextBoxNaslov" runat="server" style="z-index: 1; left: 123px; top: 148px; position: absolute"></asp:TextBox>
<asp:TextBox ID="TextBoxSadrzaj" runat="server" style="z-index: 1; left: 124px; top: 191px; position: absolute; height: 106px; width: 182px" TextMode="MultiLine"></asp:TextBox>
<asp:Button ID="ButtonPosalji" runat="server" style="z-index: 1; left: 145px; top: 338px; position: absolute" Text="Posalji" CssClass="dugme" />
</asp:Content>
