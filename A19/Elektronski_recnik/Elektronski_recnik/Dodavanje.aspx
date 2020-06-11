<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Dodavanje.aspx.cs" Inherits="Elektronski_recnik.Dodavanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 26px; top: 72px; position: absolute" Text="Rec na engleskom:"></asp:Label>
<p style="height: 239px; width: 586px">
    <asp:TextBox ID="TextBoxEngleski" runat="server" style="z-index: 1; left: 193px; top: 70px; position: absolute" CssClass="textbox"></asp:TextBox>
    <asp:TextBox ID="TextBoxSrpski" runat="server" style="z-index: 1; left: 195px; top: 111px; position: absolute" CssClass="textbox"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 28px; top: 115px; position: absolute" Text="Rec na srpskom:"></asp:Label>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 30px; top: 155px; position: absolute" Text="Opis reci:"></asp:Label>
    <asp:TextBox ID="TextBoxOpis" runat="server" style="z-index: 1; left: 170px; top: 158px; position: absolute; height: 84px; width: 154px" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
    <asp:Button ID="ButtonSnimi" runat="server" OnClick="ButtonSnimi_Click" style="z-index: 1; left: 418px; top: 134px; position: absolute" Text="Snimi" />
    <asp:Label ID="LabelGreska" runat="server" style="z-index: 1; left: 430px; top: 220px; position: absolute"></asp:Label>
</p>
</asp:Content>
